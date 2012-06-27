using System.Linq;
using Blade.Compiler.Models;

namespace Blade.Compiler.Extensibility
{
    internal sealed class ScriptObjectLiteralExtension : Extension
    {
        private const string RuntimeClassName = "System.ScriptObjectLiteralAttribute";

        public override void ExtendDeclaration(IDeclarationModel declaration, CompilationModel model)
        {
            var classDecl = declaration as ClassDeclaration;

            if (classDecl.Definition == null)
                throw new CompilationException("A script object literal attribute may only be applied to a class.", declaration);

            ValidateClass(classDecl);

            // remove from the model, this produces no declaration
            model.RemoveType(classDecl);
        }

        public override void ExtendDefinition(IDefinition definition)
        {
            var typeDef = definition as ContainerTypeDefinition;

            if (typeDef == null)
                return;

            // set to anonymous type view
            typeDef.TypeKind = TypeDefinitionKind.Anonymous;

            // set each property to render as a field
            foreach (var prop in typeDef.Properties)
                prop.MemberKind = MemberDefinitionKind.Field;
        }

        private void ValidateClass(ClassDeclaration classDecl)
        {
            if (classDecl.IsStatic)
                throw new CompilationException("A class using the [ScriptObjectLiteral] attribute cannot be declaraed static.", classDecl);

            if (classDecl.Constructors.Count > 0)
                throw new CompilationException("A class using the [ScriptObjectLiteral] attribute cannot contain constructors.", classDecl);

            if (classDecl.Methods.Count > 0)
                throw new CompilationException("A class using the [ScriptObjectLiteral] attribute cannot contain methods.", classDecl);

            if (classDecl.Events.Count > 0)
                throw new CompilationException("A class using the [ScriptObjectLiteral] attribute cannot contain events.", classDecl);

            if (classDecl.Properties.Any(p => !p.IsAutoProperty))
                throw new CompilationException("A class using the [ScriptObjectLiteral] attribute can only contain auto properties.", classDecl);

            if (classDecl.IsDerived)
                ValidateBaseClass(classDecl, classDecl.Definition.BaseClass);
        }


        private void ValidateBaseClass(ClassDeclaration originalDecl, ClassDefinition classDef)
        {
            if (classDef.Constructors.Any(c => !c.Symbol.IsImplicitlyDeclared) ||
                classDef.Methods.Any(m => !m.Symbol.IsImplicitlyDeclared) ||
                classDef.Properties.Any(p => p.MemberKind != MemberDefinitionKind.Field) ||
                classDef.Fields.Any(f => f.MemberKind != MemberDefinitionKind.Field))
            {
                throw new CompilationException("A class using the [ScriptObjectLiteral] attribute cannot inherit from class " + classDef.Symbol.GetFullName() +
                    ", because it contains one or more declarations that are not compatible with object literal notations.", originalDecl);
            }

            if (classDef.BaseClass != null && classDef.BaseClass.Symbol.SpecialType != Roslyn.Compilers.SpecialType.System_Object)
                ValidateBaseClass(originalDecl, classDef.BaseClass);
        }
    }
}
