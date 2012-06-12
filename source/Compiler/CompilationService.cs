using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Blade.Compiler.Diagnostics;
using Blade.Compiler.Preprocessing;
using Blade.Compiler.Transformation;
using Blade.Compiler.Translation;
using Blade.Compiler.Validation;
using Roslyn.Compilers;
using Roslyn.Compilers.Common;

namespace Blade.Compiler
{
    /// <summary>
    /// Blade compilation service API.
    /// </summary>
    public sealed class CompilationService
    {
        /// <summary>
        /// Compiles from a project file.
        /// </summary>
        /// <param name="projectPath">The project path.</param>
        /// <param name="scriptPath">The script file path.</param>
        /// <returns>The compilation result.</returns>
        public CompilationResult CompileProject(string projectPath, string scriptPath, IEnumerable<string> sourcePaths, IEnumerable<string> refPaths)
        {
            // ensure project path is valid
            if (String.IsNullOrEmpty(projectPath) || !File.Exists(projectPath))
                return CompilationResult.FatalError("Unable to locate project file at " + projectPath);

            // create project compilation
            CommonCompilation compilation = CreateCompilation(projectPath, sourcePaths, refPaths);

            // workaround for project refs bug in Roslyn June 2012 CTP
            var fileRefs = compilation.References.OfType<AssemblyFileReference>();
            compilation = compilation.RemoveReferences(fileRefs)
                .AddReferences(fileRefs.Select(r => new AssemblyFileReference(r.Path)));

            var pipeline = new CompilationPipeline();
            // TODO: add diagnostics process
            //pipeline.AddProcess(new DiagnosticProcess());
            pipeline.AddProcess(new SyntaxValidationProcess());
            pipeline.AddProcess(new PreprocessingProcess());
            pipeline.AddProcess(new TransformationProcess());
            pipeline.AddProcess(new ModelValidationProcess());
            pipeline.AddProcess(new TranslationProcess());
            // TODO: add assembly emit process

            scriptPath = scriptPath ?? Path.ChangeExtension(projectPath, ".js");

            using (var stream = File.Create(scriptPath))
            {
                return pipeline.Compile(compilation, stream);
            }
        }

        // non specific compilation creation
        private CommonCompilation CreateCompilation(string projectPath, IEnumerable<string> sourcePaths, IEnumerable<string> refPaths)
        {
            if (projectPath.EndsWith("", StringComparison.OrdinalIgnoreCase))
                return CreateCSharpCompilation(sourcePaths, refPaths);

            throw new NotImplementedException("Cannot create compilation from file: " + projectPath);
        }

        // create a C# compilation
        private Roslyn.Compilers.CSharp.Compilation CreateCSharpCompilation(IEnumerable<string> sourcePaths, IEnumerable<string> refPaths)
        {

            return Roslyn.Compilers.CSharp.Compilation.Create("CSComp.cll",
            options: new Roslyn.Compilers.CSharp.CompilationOptions(OutputKind.DynamicallyLinkedLibrary),
            syntaxTrees: sourcePaths.Select(p => Roslyn.Compilers.CSharp.SyntaxTree.ParseCompilationUnit(File.ReadAllText(p), p)),
            references: refPaths.Select(p => new Roslyn.Compilers.AssemblyFileReference(p)));
        }
    }
}