using System;
using System.Collections.Generic;
using System.Linq;
using Blade.Compiler.Models;

namespace Blade.Compiler.Translation
{
    /// <summary>
    /// Handles the translation of class declarations.
    /// </summary>
    [Translator]
    internal class ClassTranslator : Translator<ClassDeclaration>
    {
        public override void Translate(ClassDeclaration model, TranslationContext context)
        {
            if (model == null)
                return;

            // make sure the namespace is available
            context.EnsureNamespace(model.Definition.Namespace);

            // begin the class closure
            context.WriteLine();
            context.WriteLine(model.Definition.GetFullName() + " = (function() {");
            context.Indent();

            if (model.IsDerived)
            {
                var baseName = model.Definition.BaseClass.GetFullName();

                // derive from base, and create a local variable to access base
                context.WriteLine(String.Format("Blade.derive({0}, {1});", model.Definition.Name, baseName));
                context.WriteLine("var $base = " + baseName + ".prototype;");
            }

            // write the class constructor
            var instanceCtors = model.Constructors.Where(c => !c.IsStatic);
            if (instanceCtors.Count() > 1)
                throw new CompilationException("Constructor overloading is not supported.", model.Constructors[1]);

            var ctor = instanceCtors.FirstOrDefault() ?? new ConstructorDeclaration();
            var paramsText = String.Join(", ", ctor.Parameters.Select(p => p.Definition.Name));

            // write the ctor
            context.WriteLine(String.Format("function {0}({1}) {{", model.Definition.Name, paramsText));
            context.Indent();

            if (model.IsDerived)
            {
                // write explicit call to base class ctor
                context.Write("$base.constructor.call(this");

                if (ctor.HasExplicitBaseCall)
                {
                    // check for arguments to the base ctor
                    var baseCtor = model.Definition.BaseClass.Constructors.FirstOrDefault();
                    if (baseCtor != null && baseCtor.Parameters.Any())
                    {
                        var baseArgs = TranslationHelper.GetInvocationArgs(baseCtor.Parameters, ctor.BaseArguments);
                        if (baseArgs.Any())
                        {
                            // write base ctor args
                            context.Write(", ");
                            context.WriteModels(baseArgs, ", ");
                        }
                    }
                }

                context.WriteLine(");");
            }

            // filter out fields that are assigned in ctor
            var fields = WriteCtorInitializers(model.Fields, context);

            context.WriteModelBody(ctor.Body);
            context.Unindent();
            context.WriteLine("}");

            // group all members
            var members = Enumerable.Empty<IMemberDeclarationModel>()
                .Concat(fields).Concat(model.Events)
                .Concat(model.Properties).Concat(model.Methods);

            var instanceMembers = new List<IMemberDeclarationModel>();
            var staticMembers = new List<IMemberDeclarationModel>();

            // separate instance and static members
            foreach (var item in members)
            {
                if (item.IsStatic)
                    staticMembers.Add(item);
                else instanceMembers.Add(item);
            }

            // write instance members
            if (instanceMembers.Any())
            {
                context.PrepareForDeclarations(model.Definition.Name);
                context.EnsureLineBreak();

                foreach (var item in instanceMembers)
                    context.WriteModel(item);
            }

            // apply interfaces
            if (model.Definition.Interfaces.Any())
            {
                context.Write("Blade.impl(" + model.Definition.Name);

                foreach (var def in model.Definition.Interfaces)
                    context.Write(", '" + def.GetFullName() + "'");

                context.WriteLine(");");
            }

            // return class constructor and end closure
            context.EnsureLineBreak();
            context.WriteLine("return " + model.Definition.Name + ";");
            context.Unindent();
            context.WriteLine("})();");

            // write static members as global statements
            foreach (var item in staticMembers)
            {
                CompilationContext.Current.Model.GlobalStatements.Add(item);
                context.WriteModel(item);
            }

            // if the class has a static constructor, add to globals
            var staticCtor = model.Constructors.FirstOrDefault(c => c.IsStatic);
            if (staticCtor != null)
            {
                staticCtor.Body.HasBraces = false;
                CompilationContext.Current.Model.GlobalStatements.Add(staticCtor.Body);
            }
        }

        // this writes field initializers that must be in the constructor
        // essentially this applies to any fields that are assigned mutable values
        private static IEnumerable<FieldDeclaration> WriteCtorInitializers(IEnumerable<FieldDeclaration> fields, TranslationContext context)
        {
            var outList = new List<FieldDeclaration>();

            foreach (var f in fields)
            {
                if (f.Initializer != null && !f.IsStatic &&
                    !(f.Initializer is LiteralExpression))
                {
                    context.Write("this." + f.Name + " = ");
                    context.WriteModel(f.Initializer);
                    context.WriteLine(";");
                }
                else outList.Add(f);
            }

            return outList;
        }
    }
}
