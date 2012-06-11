using System.Collections.Generic;
using Blade.Compiler.Models;

namespace Blade.Compiler.Extensibility
{
    internal sealed class ScriptFieldExtension : Extension
    {
        public override void ExtendDeclaration(IDeclarationModel declaration, CompilationModel model)
        {
            // this only applies to properties
            var propDecl = declaration as PropertyDeclaration;
            if (propDecl == null || propDecl.Container == null)
                return;

            var container = propDecl.Container;
            container.RemoveMember(propDecl);

            var field = new FieldDeclaration
            {
                Container = container,
                OriginatingNode = propDecl.OriginatingNode,
                OriginatingTree = propDecl.OriginatingTree,
                Definition = new FieldDefinition
                {
                    Name = propDecl.Name,
                    ContainingType = propDecl.Definition.ContainingType,
                    Kind = DefinitionKind.Member,
                    MemberKind = MemberDefinitionKind.Field,
                    Type = propDecl.Definition.Type
                }
            };

            field.Definition.Modifiers.Apply(propDecl.Definition.Modifiers);
            container.AddMember(field);
        }

        public override void ExtendDefinition(IDefinition definition)
        {
            var memberDef = definition as IMemberDefinition;
            if (memberDef == null)
                return;

            // change property to field
            if (memberDef.MemberKind == MemberDefinitionKind.Property)
                memberDef.MemberKind = MemberDefinitionKind.Field;
        }
    }
}
