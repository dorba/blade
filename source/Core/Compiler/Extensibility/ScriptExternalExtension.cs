using System.Collections.Generic;
using Blade.Compiler.Models;

namespace Blade.Compiler.Extensibility
{
    internal sealed class ScriptExternalExtension : Extension
    {
        public override void ExtendDeclaration(IDeclarationModel declaration, CompilationModel model)
        {
            if (declaration.Definition == null)
                return;

            switch (declaration.Definition.Kind)
            {
                case DefinitionKind.Type:
                    var typeDecl = declaration as ITypeDeclarationModel;
                    if (typeDecl != null)
                        model.RemoveType(typeDecl);
                    break;

                case DefinitionKind.Member:
                    var memberDecl = declaration as IMemberDeclarationModel;
                    if (memberDecl != null && memberDecl.Container != null)
                        memberDecl.Container.RemoveMember(memberDecl);
                    break;
            }
        }

        public override void ExtendCompilation(CompilationModel model)
        {
            model.Clear();
        }
    }
}
