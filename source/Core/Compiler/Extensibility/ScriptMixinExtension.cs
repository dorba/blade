using System.Collections.Generic;
using Blade.Compiler.Models;

namespace Blade.Compiler.Extensibility
{
    internal sealed class ScriptMixinExtension : Extension
    {
        public override void ExtendDeclaration(IDeclarationModel declaration, CompilationModel model)
        {
            // this only applies to methods
            var methodDecl = declaration as MethodDeclaration;
            if (methodDecl == null || methodDecl.Container == null)
                return;

            if (!methodDecl.Definition.Symbol.IsExtensionMethod)
                throw new CompilationException("The ScriptMixin attribute can only be applied to extension methods.", declaration);

            // remove the function from the container
            methodDecl.Container.RemoveMember(methodDecl);

            // get the extension target info
            var extTarget = methodDecl.Parameters[0];
            var extType = extTarget.Definition.Type;

            // rewrite first param as a local declaration to this context
            var thisDecl = new LocalDeclarationStatement { VariableDeclaration = new VariableDeclaration() };
            thisDecl.VariableDeclaration.Variables.Add(new VariableDeclarator
            {
                Definition = new LocalDefinition
                {
                    Name = extTarget.Name,
                    Type = extType
                },
                EqualsValueExpression = new LiteralExpression { Text = "this" }
            });

            // add the declaration to the method body
            methodDecl.Body.Statements.Insert(0, thisDecl);

            // create a lambda using the method body.
            var lambdaExpression = new LambdaExpression();
            lambdaExpression.Body = methodDecl.Body;

            for (int i = 1; i < methodDecl.Parameters.Count; i++)
                lambdaExpression.Parameters.Add(methodDecl.Parameters[i]);

            // create a global statement to set the prototype value
            var target = extType.GetFullName() + ".prototype." + methodDecl.Definition.Name;

            model.GlobalStatements.Add(new ExpressionStatement
            {
                Expression = new BinaryExpression
                {
                    LeftExpression = new LiteralExpression { Text = target },
                    RightExpression = lambdaExpression,
                    Operator = "="
                }
            });
        }

        public override void ExtendDefinition(IDefinition definition)
        {
            var methodDef = definition as MethodDefinition;
            if (methodDef == null || methodDef.Symbol == null)
                return;

            if (methodDef.Symbol.ReducedFrom != null)
            {
                // use the original method symbol and force non static
                methodDef.Symbol = methodDef.Symbol.ReducedFrom;
                methodDef.Modifiers.IsStatic = false;
            }
        }
    }
}
