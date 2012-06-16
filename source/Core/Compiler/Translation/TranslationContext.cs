using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Blade.Compiler.Models;

namespace Blade.Compiler.Translation
{
    /// <summary>
    /// The model translation context.
    /// </summary>
    internal class TranslationContext
    {
        private const string IndentationValue = "    ";
        private List<string> _namespaces;
        private string _currentIndention;
        private TranslatorProvider _provider;

        /// <summary>
        /// Gets or sets the script output stream.
        /// </summary>
        public Stream OutputStream { get; set; }

        /// <summary>
        /// Gets a value indicating if methods should use explicit call mode.
        /// </summary>
        internal bool UsingExplicitCall { get; set; }

        /// <summary>
        /// Gets or sets the current assignee.
        /// </summary>
        internal IdentifierName CurrentAssignee { get; set; }

        /// <summary>
        /// Gets or sets the target expression for an extension method call.
        /// </summary>
        internal ExpressionModel ExtensionMethodTarget { get; set; }

        /// <summary>
        /// Gets the current output length.
        /// </summary>
        public int Length
        {
            get { return OutputStream != null ? (int)OutputStream.Length : 0; }
        }

        /// <summary>
        /// Creates a new instance of the class.
        /// </summary>
        public TranslationContext()
        {
            _namespaces = new List<string>();
            _provider = new TranslatorProvider(null);
        }

        /// <summary>
        /// Resolves and writes a model into the context.
        /// </summary>
        /// <param name="model">The model.</param>
        public virtual void WriteModel(IModel model)
        {
            if (model == null)
                return;

            var translator = ResolveTranslator(model.GetType());

            if (translator == null)
            {
                var syntacticModel = model as ISyntacticModel;
                var hasSyntax = (syntacticModel != null);

                throw new CompilationException("No translator was found to handle model of type "
                    + model.GetType().FullName, model as ISyntacticModel);
            }

            translator.Translate(model, this);
        }

        /// <summary>
        /// Writes a collection of models, with a separator string between each model.
        /// </summary>
        /// <param name="models">The model collection.</param>
        /// <param name="separator">The separator.</param>
        public void WriteModels(IEnumerable<IModel> models, string separator)
        {
            if (models == null || !models.Any())
                return;

            var isFirst = true;
            foreach (var m in models)
            {
                if (isFirst) isFirst = false;
                else Write(separator);

                WriteModel(m);
            }
        }

        /// <summary>
        /// Writes a shorthand statment to access the object prototype prior to writing declarations.
        /// </summary>
        /// <param name="objName">The name of the prototype container.</param>
        public void PrepareForDeclarations(string objName)
        {
            Write("var p = " + objName + ".prototype;");
        }

        /// <summary>
        /// Writes the member declaration.
        /// </summary>
        /// <param name="model">The model class.</param>
        /// <param name="prefix">The name prefix.</param>
        /// <param name="postfix">The name postfix.</param>
        public void WriteDeclaration(IMemberDeclarationModel model, string prefix = null, string postfix = null)
        {
            if (model == null)
                return;

            Write((model.IsStatic ? model.Container.Name : "p") + "." + prefix + model.Name + postfix);
        }

        /// <summary>
        /// Writes a model and prevents rendering of braces.
        /// </summary>
        /// <param name="model">The model.</param>
        public void WriteModelBody(ISyntacticModel model)
        {
            if (model != null)
            {
                // prevent braces in code blocks
                var block = model as CodeBlock;
                if (block != null)
                    block.HasBraces = false;
            }

            WriteModel(model);
        }

        /// <summary>
        /// Ensures that a namespace is declared.
        /// </summary>
        /// <param name="value">The namespace fully qualified name.</param>
        public void EnsureNamespace(string value)
        {
            if (String.IsNullOrWhiteSpace(value))
                return;

            value = value.Trim();

            if (_namespaces.Contains(value))
                return;

            var split = value.Split('.');
            var current = split[0];

            if (!_namespaces.Contains(current))
            {
                // we must check for undefined on the root
                EnsureLineBreak();
                WriteLine("if(typeof " + current + " == 'undefined') " + current + " = {};");
                _namespaces.Add(current);
            }

            for (int i = 1; i < split.Length; i++)
            {
                current = current + '.' + split[i];

                if (!_namespaces.Contains(current))
                {
                    // parts after root can simply check for null
                    EnsureLineBreak();
                    WriteLine("if(!" + current + ") " + current + " = {};");
                    _namespaces.Add(current);
                }
            }
        }

        /// <summary>
        /// Increases the indention level once.
        /// </summary>
        public void Indent()
        {
            _currentIndention += IndentationValue;
        }

        /// <summary>
        /// Decreases the indention level once.
        /// </summary>
        public void Unindent()
        {
            if (_currentIndention != null && _currentIndention.Length >= IndentationValue.Length)
                _currentIndention = _currentIndention.Remove(_currentIndention.Length - IndentationValue.Length);
        }

        /// <summary>
        /// Resolves a translator by model type.
        /// </summary>
        /// <param name="type">The model type.</param>
        /// <returns>The associated translator.</returns>
        public ITranslator ResolveTranslator(Type type)
        {
            return _provider.ResolveImport(type);
        }

        /// <summary>
        /// Gets the default value of a type.
        /// </summary>
        /// <param name="definition">The type definition.</param>
        /// <returns>The default value string.</returns>
        public string GetDefaultValue(ITypeDefinition definition)
        {
            if (definition == null)
                return "null";

            if (definition.TypeKind == TypeDefinitionKind.Enum)
            {
                return "0";
            }
            else if (definition.TypeKind == TypeDefinitionKind.Struct)
            {
                var name = definition.GetFullName();

                if (name == "Number")
                    return "0";
            }

            return "null";
        }

        /// <summary>
        /// Creates a new positional writer for this context at the current stream position.
        /// </summary>
        /// <returns>The newly created writer.</returns>
        public PositionalWriter CreatePositionalWriter()
        {
            return new PositionalWriter(this, (int)OutputStream.Position);
        }

        #region Text Writing

        /// <summary>
        /// Writes a text value to the context.
        /// </summary>
        /// <param name="value">The value to write.</param>
        public virtual void Write(string value)
        {
            if (String.IsNullOrEmpty(value))
                return;

            if (IsLineStart())
                value = _currentIndention + value;

            var bytes = Encoding.UTF8.GetBytes(value);
            OutputStream.Write(bytes, 0, bytes.Length);
        }

        /// <summary>
        /// Writes a new line to the context.
        /// </summary>
        public void WriteLine()
        {
            Write(Environment.NewLine);
        }

        /// <summary>
        /// Writes a text value, followed by a new line to the context.
        /// </summary>
        /// <param name="value">The value to write.</param>
        public void WriteLine(string value)
        {
            Write(value + Environment.NewLine);
        }

        /// <summary>
        /// Writes a value at a specific position in the stream.
        /// </summary>
        /// <param name="index">The position.</param>
        /// <param name="value">The value to write.</param>
        /// <param name="overwrite">True to overwrite the existing text, false to insert.</param>
        public void WriteAt(int index, string value, bool overwrite = false)
        {
            var origin = OutputStream.Position;

            try
            {
                // load a specific char
                OutputStream.Seek(index, SeekOrigin.Begin);

                if (!overwrite)
                {
                    // capture the original data
                    var buffer = new byte[OutputStream.Length - OutputStream.Position];
                    var origData = OutputStream.Read(buffer, 0, buffer.Length);

                    // write the new value
                    OutputStream.Seek(index, SeekOrigin.Begin);
                    Write(value);

                    // re-write the original data
                    OutputStream.Write(buffer, 0, buffer.Length);
                    origin += value.Length;
                }
                else Write(value);
            }
            finally
            {
                // always return to the end origin
                OutputStream.Seek(origin, SeekOrigin.Begin);
            }
        }

        /// <summary>
        /// Ensures that a the current line is only whitespace.
        /// </summary>
        public void EnsureLineBreak()
        {
            if (OutputStream.Length == 0)
            {
                WriteLine();
                return;
            }

            var last = OutputStream.Length - 1;
            while (last > 1)
            {
                var c = GetCharAt(last);
                if (!Char.IsWhiteSpace(c))
                {
                    // if non whitespace, write new line
                    WriteLine();
                    return;
                }

                // if line only consists of whitespace, do nothing
                if (c == '\n' && GetCharAt(last - 1) == '\r')
                    return;

                last--;
            }
        }

        /// <summary>
        /// Gets the character at the specified position.
        /// </summary>
        /// <param name="index">The index.</param>
        /// <returns>A character.</returns>
        public char GetCharAt(long index)
        {
            if (index < 0 || index >= OutputStream.Length)
                throw new IndexOutOfRangeException();

            var origin = OutputStream.Position;

            try
            {
                // load a specific char
                OutputStream.Seek(index, SeekOrigin.Begin);
                return (char)OutputStream.ReadByte();
            }
            finally
            {
                // always return to the end origin
                OutputStream.Seek(origin, SeekOrigin.Begin);
            }
        }

        /// <summary>
        /// Gets the last characters as a string.
        /// </summary>
        /// <param name="count">The number of characters to get.</param>
        /// <returns></returns>
        public string GetLast(int count)
        {
            if (count > OutputStream.Length)
                count = (int)OutputStream.Length;

            var origin = OutputStream.Position;

            try
            {
                // fill buffer from stream
                var buffer = new byte[count];
                OutputStream.Seek(-count, SeekOrigin.End);
                OutputStream.Read(buffer, 0, count);
                return Encoding.UTF8.GetString(buffer);
            }
            finally
            {
                // always return to the end origin
                OutputStream.Seek(origin, SeekOrigin.Begin);
            }
        }

        /// <summary>
        /// Gets a value indicating if the current position is the start of a line.
        /// </summary>
        /// <returns>True if starting a new line, false otherwise.</returns>
        public bool IsLineStart()
        {
            if (OutputStream.Length < 1)
                return true;

            return (GetLast(Environment.NewLine.Length) == Environment.NewLine);
        }

        #endregion
    }
}
