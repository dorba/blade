using Blade.Compiler.Models;

namespace Blade.Compiler.Translation
{
    /// <summary>
    /// Handles translation of an anonymous type.
    /// </summary>
    [Translator]
    internal class AnonymousTypeExpressionTranslator : Translator<AnonymousObjectExpression>
    {
        public override void Translate(AnonymousObjectExpression model, TranslationContext context)
        {
            context.WriteLine("{");
            context.Indent();

            var first = true;
            foreach (var item in model.Assignments)
            {
                if (first) first = false;
                else context.WriteLine(",");

                context.Write(item.Assignee.Definition.Name + ": ");
                context.WriteModel(item.RightExpression);

                // anonymous type members are created as properties
                // however, we translate the declaration as fields
                // thus must also change the member kind, so that
                // usage of the member is also translated correctly
                ((IMemberDefinition)item.Assignee.Definition).MemberKind = MemberDefinitionKind.Field;
            }

            context.EnsureLineBreak();
            context.Unindent();
            context.Write("}");
        }
    }
}
