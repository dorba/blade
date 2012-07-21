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

                // normally this will render as a fully qualified name
                // however, there is one exception when a static value 
                // is attached to a type that is being initialized
                if (context.InitializingType != null && memberDef != null)
                {
                    // in this case we only render the local name of the type
                    if (memberDef.ContainingType.Equals(context.InitializingType.Definition))
                        fullName = context.InitializingType.Name + "." + model.Name;
                }

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
