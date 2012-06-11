using System;
using System.Collections.Generic;

namespace Blade.Compiler.Models
{
    /// <summary>
    /// Represents a constructor declaration.
    /// </summary>
    public sealed class ConstructorDeclaration : MethodDeclarationBase<ConstructorDefinition>
    {
        /// <summary>
        /// Gets the base constructor arguments.
        /// </summary>
        public IList<Argument> BaseArguments
        {
            get { return _baseArguments; }
        } private List<Argument> _baseArguments;

        /// <summary>
        /// Gets the prerequisite constructor arguments.
        /// </summary>
        public IList<Argument> ThisArguments
        {
            get { return _thisArguments; }
        } private List<Argument> _thisArguments;

        /// <summary>
        /// Gets or sets a value indicating whether or not the constructor has an explicit base constructor call.
        /// </summary>
        public bool HasExplicitBaseCall { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether or not the constructor calls another constructor prior to executing.
        /// </summary>
        public bool HasPrerequisite { get; set; }

        /// <summary>
        /// Gets the target class of the constructor.
        /// </summary>
        public ClassDefinition Constructee
        {
            get { return Definition != null ? Definition.ContainingType as ClassDefinition : null; }
        }

        /// <summary>
        /// Creates a new instance of the class.
        /// </summary>
        public ConstructorDeclaration()
        {
            _baseArguments = new List<Argument>();
            _thisArguments = new List<Argument>();
        }
    }
}
