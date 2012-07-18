using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using Blade.Tools.Quality.Build.Templates;
using Microsoft.CSharp;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Blade.Tools.Quality.Build
{
    /// <summary>
    /// Creates a test assembly compatible with mstest.
    /// </summary>
    internal class TestAssemblyBuilder
    {
        // assemblies referenced by the test assembly
        private static string[] ReferencePaths = new[] {
                Assembly.GetExecutingAssembly().Location,
                typeof(object).Assembly.Location,
                typeof(Assert).Assembly.Location,
                typeof(Enumerable).Assembly.Location
            };

        private IEnumerable<string> _sourceFiles;
        private List<CompilerError> _errors;
        private List<CompilerError> _warnings;

        /// <summary>
        /// Gets the errors resulting from the compilation.
        /// </summary>
        public IEnumerable<CompilerError> Errors
        {
            get { return _errors; }
        }

        /// <summary>
        /// Gets the warnings resulting from the compilation.
        /// </summary>
        public IEnumerable<CompilerError> Warnings
        {
            get { return _warnings; }
        }

        /// <summary>
        /// Gets a value indicating if the compilation produced any errors.
        /// </summary>
        public bool HasErrors
        {
            get { return _errors != null && _errors.Any(); }
        }

        /// <summary>
        /// Gets a value indicating if the compilation produced any warnings.
        /// </summary>
        public bool HasWarnings
        {
            get { return _warnings != null && _warnings.Any(); }
        }

        /// <summary>
        /// Creates a new instance of the class
        /// </summary>
        /// <param name="sourceFiles">The source files to use.</param>
        public TestAssemblyBuilder(IEnumerable<string> sourceFiles)
        {
            _sourceFiles = sourceFiles;
            _errors = new List<CompilerError>();
            _warnings = new List<CompilerError>();
        }

        /// <summary>
        /// Creates a new assembly, using the specified info.
        /// </summary>
        /// <param name="info">The info object.</param>
        public void CreateAssembly(TestAssemblyInfo info)
        {
            _errors.Clear();
            _warnings.Clear();

            // create output stream for test source
            var stream = new MemoryStream();
            var writer = new StreamWriter(stream) { AutoFlush = true };
            var compilation = new TestCompilation(_sourceFiles, ReferencePaths);

            // write test classes
            foreach (var model in compilation.TemplateModels)
            {
                var tmpl = new TestClassTemplate { Model = model };
                writer.WriteLine(tmpl.TransformText());
            }

            // write initializer class
            var initTmpl = new InitClassTemplate() { ProjectDir = info.ProjectDir };
            writer.WriteLine(initTmpl.TransformText());

            // create codeDom objects
            var codeProvider = new CSharpCodeProvider();
            var options = new CompilerParameters
            {
                GenerateExecutable = false,
                GenerateInMemory = false,
                OutputAssembly = info.OutputPath,
                IncludeDebugInformation = true
            };

            options.ReferencedAssemblies.AddRange(ReferencePaths);

            stream.Seek(0, SeekOrigin.Begin);
            var reader = new StreamReader(stream);
            var fullSrc = reader.ReadToEnd();
            var result = codeProvider.CompileAssemblyFromSource(options, new[] { fullSrc });

            // log errors and warnings to IDE/console
            foreach (var item in result.Errors.OfType<CompilerError>())
            {
                if (item.IsWarning)
                    _warnings.Add(item);
                else _errors.Add(item);
            }
        }
    }
}
