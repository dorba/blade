using Blade.Compiler.Models;

namespace Blade.Compiler.Translation
{
    /// <summary>
    /// Handles translation of lambda expressions
    /// </summary>
    [Translator]
    internal class LambdaExpressionTranslator : Translator<LambdaExpression>
    {
        public override void Translate(LambdaExpression model, TranslationContext context)
        {
            if (context.IsWritingGlobalStatements)
            {
                // write function declaration, with params
                context.Write("function(");
                context.WriteModels(model.Parameters, ", ");
                context.WriteLine(") {");

                // write inner body
                context.Indent();
                context.WriteModelBody(model.Body);
                context.Unindent();

                // close function declaration
                context.Write("}");
            }
            else
            {
                // write function declaration, with params
                context.Write("Blade.del(this, function(");
                context.WriteModels(model.Parameters, ", ");
                context.WriteLine(") {");

                // write inner body
                context.Indent();
                context.WriteModelBody(model.Body);
                context.Unindent();

                // close function declaration
                context.Write("})");
            }
        }
    }
}
