using System.Collections.Generic;
using Blade.Compiler.Models;
using Roslyn.Compilers.CSharp;

namespace Blade.Compiler.Transformation.CSharp
{
    internal partial class Transformer : SyntaxVisitor<IEnumerable<IModel>>
    {
        public override IEnumerable<IModel> VisitPredefinedType(PredefinedTypeSyntax node)
        {
            var model = Create<PredefinedTypeExpression>(node);
            model.Definition = GetDefinition<IDefinition>(node);

            switch (node.Keyword.Kind)
            {
                case SyntaxKind.ObjectKeyword: model.Kind = PredefinedType.Object; break;
                case SyntaxKind.BoolKeyword: model.Kind = PredefinedType.Bool; break;
                case SyntaxKind.CharKeyword: model.Kind = PredefinedType.Char; break;
                case SyntaxKind.StringKeyword: model.Kind = PredefinedType.String; break;
                case SyntaxKind.SByteKeyword: model.Kind = PredefinedType.SByte; break;
                case SyntaxKind.ShortKeyword: model.Kind = PredefinedType.Short; break;
                case SyntaxKind.IntKeyword: model.Kind = PredefinedType.Int; break;
                case SyntaxKind.LongKeyword: model.Kind = PredefinedType.Long; break;
                case SyntaxKind.ByteKeyword: model.Kind = PredefinedType.Byte; break;
                case SyntaxKind.UShortKeyword: model.Kind = PredefinedType.UShort; break;
                case SyntaxKind.UIntKeyword: model.Kind = PredefinedType.UInt; break;
                case SyntaxKind.ULongKeyword: model.Kind = PredefinedType.ULong; break;
                case SyntaxKind.FloatKeyword: model.Kind = PredefinedType.Float; break;
                case SyntaxKind.DoubleKeyword: model.Kind = PredefinedType.Double; break;
                case SyntaxKind.DecimalKeyword: model.Kind = PredefinedType.Decimal; break;

                default:
                    throw new CompilationException("Unable to determine type kind.", model);
            }

            yield return model;
        }
    }
}
