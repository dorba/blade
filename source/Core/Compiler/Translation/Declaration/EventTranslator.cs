using Blade.Compiler.Models;

namespace Blade.Compiler.Translation
{
    /// <summary>
    /// Handles the translation of event declarations
    /// </summary>
    [Translator]
    internal class EventTranslator : Translator<EventDeclaration>
    {
        public override void Translate(EventDeclaration model, TranslationContext context)
        {
            if (model == null)
                return;

            string fieldAddScript = null;
            string fieldRemScript = null;

            if (model.IsField)
            {
                // add a backing event list
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
                        Type = new ClassDefinition()
                        {
                            Kind = DefinitionKind.Type,
                            Name = "Event",
                            Namespace = "Blade",
                        }
                    },
                    Initializer = new LiteralExpression
                    {
                        Type = LiteralType.None,
                        Text = "new Blade.Event()"
                    }
                };

                // use same modifier as property, but force private
                backingField.Definition.Modifiers.Apply(model.Definition.Modifiers);
                backingField.Definition.Modifiers.Access = Accessibility.Private;

                context.WriteModel(backingField);

                // manually create get/set body
                var fieldPrefix = model.IsStatic ? model.Container.Name : "this";
                var fieldAccess = fieldPrefix + "." + fieldName;

                fieldAddScript = fieldAccess + ".add(func, ctx);";
                fieldRemScript = fieldAccess + ".rem(func);";

                // add a method to invoke the event
                context.WriteDeclaration(model);
                context.WriteLine(" = function() {");
                context.Indent();
                context.WriteLine(fieldAccess + ".pub.apply(" + fieldAccess + ", arguments);");
                context.Unindent();
                context.WriteLine("}");
            }

            // write the add accessor
            context.WriteDeclaration(model, postfix: "$add");
            context.WriteLine(" = function(func, ctx) {");
            context.Indent();

            if (model.IsField)
                context.WriteLine(fieldAddScript);
            else context.WriteModelBody(model.AddAccessor);

            context.Unindent();
            context.WriteLine("};");

            // write the remove accessor
            context.WriteDeclaration(model, postfix: "$rem");
            context.WriteLine(" = function(func) {");
            context.Indent();

            if (model.IsField)
                context.WriteLine(fieldRemScript);
            else context.WriteModelBody(model.RemoveAccessor);

            context.Unindent();
            context.WriteLine("};");
        }
    }
}