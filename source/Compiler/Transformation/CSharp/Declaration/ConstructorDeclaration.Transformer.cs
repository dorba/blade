using System.Collections;
using System.Collections.Generic;
using Blade.Compiler.Models;
using Roslyn.Compilers.CSharp;

namespace Blade.Compiler.Transformation.CSharp
{
    internal partial class Transformer : SyntaxVisitor<IEnumerable<IModel>>
    {
        public override IEnumerable<IModel> VisitConstructorDeclaration(ConstructorDeclarationSyntax node)
        {
            var model = CreateSymbolic<ConstructorDeclaration, ConstructorDefinition>(node);
            model.Body = TransformToSingleOrNull<CodeBlock>(node.Body);

            if (node.Initializer != null)
            {
                IList<Argument> targetList = null;

                if (node.Initializer.ThisOrBaseKeyword.Kind == SyntaxKind.ThisKeyword)
                {
                    model.HasPrerequisite = true;
                    targetList = model.ThisArguments;
                }
                else if (node.Initializer.ThisOrBaseKeyword.Kind == SyntaxKind.BaseKeyword)
                {
                    model.HasExplicitBaseCall = true;
                    targetList = model.BaseArguments;
                }

                if (targetList != null)
                    TransformInto<Argument>(node.Initializer.ArgumentList, targetList);
            }

            TransformInto<ParameterDeclaration>(node.ParameterList, model.Parameters);

            yield return model;
        }
    }
}
