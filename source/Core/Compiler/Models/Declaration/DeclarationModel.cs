using System;
using System.Linq;
using Roslyn.Compilers.Common;

namespace Blade.Compiler.Models
{
    /// <summary>
    /// Common interface for all declaration models.
    /// </summary>
    public abstract class DeclarationModel<T> : IDeclarationModel
        where T : class, IDefinition
    {
        /// <summary>
        /// Gets or sets the type definition.
        /// </summary>
        public T Definition { get; set; }

        /// <summary>
        /// Explicit interface implementation.
        /// Gets the symbolic definition.
        /// </summary>
        IDefinition ISymbolicModel.Definition
        {
            get { return Definition; }
            set { Definition = value as T; }
        }

        /// <summary>
        /// Gets or sets the tree that produced the model.
        /// </summary>
        public CommonSyntaxTree OriginatingTree { get; set; }

        /// <summary>
        /// Gets or sets the tree that produced the model.
        /// </summary>
        public CommonSyntaxNode OriginatingNode { get; set; }

        /// <summary>
        /// Provides access to the definition name.
        /// </summary>
        public string Name
        {
            get { return Definition.Name; }
            set { Definition.Name = value; }
        }

        /// <summary>
        /// Provides access to the definition modifier static flag.
        /// </summary>
        public bool IsStatic
        {
            get { return Definition.Modifiers.IsStatic; }
            set { Definition.Modifiers.IsStatic = value; }
        }
    }
}
