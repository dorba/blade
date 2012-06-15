using System.Collections.Generic;
using Blade.Compiler.Models;
using Roslyn.Compilers.CSharp;

namespace Blade.Compiler.Transformation.CSharp
{
    internal partial class Transformer : SyntaxVisitor<IEnumerable<IModel>>
    {
        public override IEnumerable<IModel> VisitObjectCreationExpression(ObjectCreationExpressionSyntax node)
        {
            var model = Create<NewExpression>(node);
            model.Initializer = TransformToSingleOrNull<InitializerExpression>(node.Initializer);
            TransformInto<Argument>(node.ArgumentList, model.Arguments);

            // get the type definition
            var def = GetDefinition<IDefinition>(node.Type);
            if (def != null)
            {
                // most definitions are constructors, in order to
                // get the type being created, get the ctor container
                var ctorDef = def as ConstructorDefinition;
                if (ctorDef != null)
                    model.Type = ctorDef.ContainingType;
                else
                {
                    // some cases, e.g, delegates are 
                    // simply type definitions themselves
                    var typeDef = def as ITypeDefinition;
                    if (typeDef != null)
                        model.Type = typeDef;
                }
            }

            yield return model;
        }
    }
}
