using Blade.Compiler.Models;

namespace Blade.Compiler.Translation
{
    /// <summary>
    /// Handles translation of identifier models.
    /// </summary>
    [Translator]
    internal class IdentifierNameTranslator : Translator<IdentifierName>
    {
        public override void Translate(IdentifierName model, TranslationContext context)
        {
            var typeDef = model.Definition as ITypeDefinition;
            if (typeDef != null)
            {
                switch (typeDef.TypeKind)
                {
                    case TypeDefinitionKind.Delegate:
                    case TypeDefinitionKind.Enum:
                    case TypeDefinitionKind.Generic:
                        return;

                    case TypeDefinitionKind.Interface:
                        context.Write("'" + model.Definition.GetFullName() + "'");
                        return;

                    default:
                        context.Write(model.Definition.GetFullName());
                        return;
                }
            }

            var prefix = "";
            var isGetAccessor = false;

            var memberDef = model.Definition as IMemberDefinition;
            if (memberDef != null)
            {
                if (memberDef.MemberKind == MemberDefinitionKind.Property)
                {
                    if (context.CurrentAssignee != null &&
                        (model.Definition == context.CurrentAssignee.Definition))
                    {
                        prefix += "set_";
                    }
                    else { prefix += "get_"; isGetAccessor = true; }
                }
            }

            if (model.IsStatic)
            {
                var fullName = model.FullName;

                if (!string.IsNullOrEmpty(prefix))
                {
                    var lastDot = fullName.LastIndexOf('.');

                    if (lastDot != -1)
                        fullName = fullName.Substring(0, lastDot + 1) + prefix + fullName.Substring(lastDot + 1);
                    else fullName = prefix + fullName;
                }

                context.Write(fullName);
            }
            else context.Write(prefix + model.Name);

            if (isGetAccessor)
            {
                context.Write(context.UsingExplicitCall ? ".call(this)" : "()");
            }
        }
    }
}
