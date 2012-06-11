using Blade.Compiler.Models;

namespace Blade.Compiler.Translation
{
    /// <summary>
    /// Handles translation of an assignment expression.
    /// </summary>
    [Translator]
    internal class AssignmentExpressionTranslator : Translator<AssignmentExpression>
    {
        public override void Translate(AssignmentExpression model, TranslationContext context)
        {
            var origAssignee = context.CurrentAssignee;
            context.CurrentAssignee = model.Assignee;

            context.WriteModel(model.LeftExpression);
            context.CurrentAssignee = origAssignee;

            // handle special member kinds - property, and event
            var memberDef = model.Assignee.Definition as IMemberDefinition;
            if (memberDef != null)
            {
                switch (memberDef.MemberKind)
                {
                    case MemberDefinitionKind.Property:
                        HandlePropertyAssignment(model, context);
                        return;

                    case MemberDefinitionKind.Event:
                        HandleEventAssignment(model, context);
                        return;
                }
            }

            context.Write(" " + model.Operator + " ");
            context.WriteModel(model.RightExpression);
        }

        private void HandlePropertyAssignment(AssignmentExpression model, TranslationContext context)
        {
            context.Write((context.UsingExplicitCall) ? ".call(this, " : "(");

            if (model.Operator.Length > 1)
            {
                // complex assignment, such as +=, %=, etc.
                // create a new binary expression on the fly
                context.WriteModel(new BinaryExpression
                {
                    LeftExpression = model.LeftExpression,
                    RightExpression = model.RightExpression,
                    Operator = model.Operator.Substring(0, 1)
                });
            }
            else context.WriteModel(model.RightExpression);

            context.Write(")");
        }

        private void HandleEventAssignment(AssignmentExpression model, TranslationContext context)
        {
            // field => add_field(func, ctx); -or- rem_field(func, ctx);

            if (model.Operator == "+=")
                context.Write("$add");
            else if (model.Operator == "-=")
                context.Write("$rem");
            else throw new CompilationException("Unexpected event operator of: " + model.Operator, model);

            context.Write((context.UsingExplicitCall) ? ".call(this, " : "(");
            context.WriteModel(model.RightExpression);

            var rtMemberExp = model.RightExpression as MemberAccessExpression;

            if (rtMemberExp == null)
            {
                // events can also be assigned using new syntax
                // in which case we should use the inner expression
                var newExp = model.RightExpression as NewExpression;
                if (newExp != null && newExp.Arguments.Count == 1)
                {
                    rtMemberExp = newExp.Arguments[0].Expression as MemberAccessExpression;
                }
            }

            if (rtMemberExp != null)
            {
                // set the event context
                context.Write(", ");
                context.WriteModel(rtMemberExp.Expression);
            }

            context.Write(")");
        }

        private bool AssumeEventIdentifier(AssignmentExpression model, TranslationContext context)
        {
            if (model == null || model.Assignee == null)
                return false;

            var assignee = model.Assignee;
            if (assignee.Definition == null || !(assignee.Definition is EmptyDefinition))
                return false;

            string prefix = null;

            if (model.Operator == "+=")
                prefix = "add_";
            else if (model.Operator == "-=")
                prefix = "rem_";

            if (prefix == null)
                return false;

            var mbrAcc = model.LeftExpression as MemberAccessExpression;
            if (mbrAcc != null)
                context.WriteModel(mbrAcc.Expression);
            else context.Write("this");

            context.Write("." + prefix + model.Assignee.Definition.Name + "(");
            context.WriteModel(model.RightExpression);
            context.Write(", ");

            if (mbrAcc != null)
                context.WriteModel(mbrAcc.Expression);
            else context.Write("this");

            context.Write(")");

            return true;
        }
    }
}
