using System.Collections.Generic;
using Blade.Compiler.Models;
using Roslyn.Compilers.CSharp;

namespace Blade.Compiler.Transformation.CSharp
{
    internal partial class Transformer : SyntaxVisitor<IEnumerable<IModel>>
    {
        public override IEnumerable<IModel> VisitQualifiedName(QualifiedNameSyntax node)
        {
            return Visit(node.Right);

            //var model = Create<QualifiedName>(node);
            //model.LeftName = TransformToSingle<IdentifierName>(node.Left);
            //model.RightName = TransformToSingle<IdentifierName>(node.Right);

            //yield return model;
        }
    }
}
