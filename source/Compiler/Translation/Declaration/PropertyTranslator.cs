using Blade.Compiler.Models;

namespace Blade.Compiler.Translation
{
    /// <summary>
    /// Handles the translation of property declarations
    /// </summary>
    [Translator]
    internal class PropertyTranslator : Translator<PropertyDeclaration>
    {
        public override void Translate(PropertyDeclaration model, TranslationContext context)
        {
            if (model == null)
                return;

            string autoGetScript = null;
            string autoSetScript = null;

            if (model.IsAutoProperty)
            {
                // add a backing field
                var fieldName = "$" + model.Definition.Name;
                var backingField = new FieldDeclaration
                {
                    Container = model.Container,
                    OriginatingNode = model.OriginatingNode,
                    OriginatingTree = model.OriginatingTree,
                    Definition = new FieldDefinition
                    {
                        Name = fieldName,
                        ContainingType = model.Definition.ContainingType,
                        Type = model.Definition.Type,
                        Kind = DefinitionKind.Member,
                        MemberKind = MemberDefinitionKind.Field
                    }
                };

                // use same modifier as property, but force private
                backingField.Definition.Modifiers.Apply(model.Definition.Modifiers);
                backingField.Definition.Modifiers.Access = Accessibility.Private;

                context.WriteModel(backingField);

                // manually create get/set body
                var fieldPrefix = model.IsStatic ? model.Container.Name : "this";
                autoGetScript = "return " + fieldPrefix + "." + fieldName + ";";
                autoSetScript = fieldPrefix + "." + fieldName + " = value;";
            }

            // write the get accessor
            if (model.HasGetter || model.IsAutoProperty)
            {
                context.WriteDeclaration(model, "get_");
                context.WriteLine(" = function() {");
                context.Indent();

                if (model.IsAutoProperty)
                    context.WriteLine(autoGetScript);
                else context.WriteModelBody(model.GetAccessor);

                context.Unindent();
                context.WriteLine("};");
            }

            // write the set accessor
            if (model.HasSetter || model.IsAutoProperty)
            {
                context.WriteDeclaration(model, "set_");
                context.WriteLine(" = function(value) {");
                context.Indent();

                if (model.IsAutoProperty)
                    context.WriteLine(autoSetScript);
                else context.WriteModelBody(model.SetAccessor);

                context.Unindent();
                context.WriteLine("};");
            }
        }
    }
}