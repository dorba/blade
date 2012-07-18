using System;
using System.IO;
using System.Linq;
using Roslyn.Compilers;
using Roslyn.Compilers.Common;
using CSharpCompilation = Roslyn.Compilers.CSharp.Compilation;
using CSharpTree = Roslyn.Compilers.CSharp.SyntaxTree;

namespace Blade.Compiler
{
    /// <summary>
    /// Handles the creation of the compilation object.
    /// </summary>
    internal class SyntaxParsingProcess : ICompilationProcess
    {
        /// <summary>
        /// Executes the parsing process.
        /// </summary>
        /// <param name="context">The compilation context.</param>
        public void Execute(CompilationContext context)
        {
            if (context.Input == null)
                throw new CompilationException("The compilation input cannot be null.");

            var compilation = CreateCompilation(context.Input);

            // workaround for project refs bug in Roslyn June 2012 CTP
            var fileRefs = compilation.References.OfType<AssemblyFileReference>();
            compilation = compilation.RemoveReferences(fileRefs)
                .AddReferences(fileRefs.Select(r => new AssemblyFileReference(r.Path)));

            // set the compilation
            context.Compilation = compilation;
        }

        // non specific compilation creation
        private CommonCompilation CreateCompilation(CompilationRequest input)
        {
            if (input.SourceFilePaths == null || !input.SourceFilePaths.Any())
                return null;

            if (input.SourceFilePaths.All(p => p.EndsWith(".cs", StringComparison.OrdinalIgnoreCase)))
            {
                // compile as C# compilation
                return CreateCSharpCompilation(input);
            }

            // list the invalid (non .cs) extension file types 
            var invalidFiles = input.SourceFilePaths.Where(p =>
                !p.EndsWith(".cs", StringComparison.OrdinalIgnoreCase));

            throw new CompilationException("The following invalid file types were encountered: " +
                String.Join(", ", invalidFiles.Select(f => Path.GetExtension(f))));
        }

        // create a C# compilation
        private Roslyn.Compilers.CSharp.Compilation CreateCSharpCompilation(CompilationRequest input)
        {
            // create compiler options
            var compileOpts = new Roslyn.Compilers.CSharp.CompilationOptions(OutputKind.DynamicallyLinkedLibrary);

            // create parser options
            var parseOpts = Roslyn.Compilers.CSharp.ParseOptions.Default;
            if (input.Definitions != null && input.Definitions.Any())
                parseOpts = parseOpts.WithPreprocessorSymbols(input.Definitions);

            // build syntax trees
            var trees = input.SourceFilePaths.Select(path =>
                CSharpTree.ParseCompilationUnit(File.ReadAllText(path), path, parseOpts));

            // create assembly references
            var asmRefs = input.ReferencePaths.Select(p =>
                new Roslyn.Compilers.AssemblyFileReference(p));

            // create compilation
            return CSharpCompilation.Create("BladeCsComp.dll", compileOpts, trees, asmRefs);
        }
    }
}
