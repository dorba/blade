using System;
using System.Collections.Generic;
using System.Linq;
using Blade.Compiler.Models;
using Roslyn.Compilers.CSharp;

namespace Blade.Compiler.Transformation.CSharp
{
    internal partial class Transformer : SyntaxVisitor<IEnumerable<IModel>>
    {
        public override IEnumerable<IModel> VisitClassDeclaration(ClassDeclarationSyntax node)
        {
            var model = CreateSymbolic<ClassDeclaration, ClassDefinition>(node);

            foreach (var member in node.Members)
            {
                var memberModel = Visit(member).SingleOrDefault() as IMemberDeclarationModel;
                if (memberModel == null)
                    continue;

                memberModel.Container = model;

                switch (member.Kind)
                {
                    case SyntaxKind.ConstructorDeclaration:
                        model.Constructors.Add((ConstructorDeclaration)memberModel);
                        break;

                    case SyntaxKind.FieldDeclaration:
                        model.Fields.Add((FieldDeclaration)memberModel);
                        break;

                    case SyntaxKind.PropertyDeclaration:
                        model.Properties.Add((PropertyDeclaration)memberModel);
                        break;

                    case SyntaxKind.MethodDeclaration:
                        model.Methods.Add((MethodDeclaration)memberModel);
                        break;

                    case SyntaxKind.EventDeclaration:
                    case SyntaxKind.EventFieldDeclaration:
                        model.Events.Add((EventDeclaration)memberModel);
                        break;

                    default: throw new NotImplementedException("Unexpected class member of type: " + member.Kind);
                }
            }

            yield return model;
        }
    }
}
