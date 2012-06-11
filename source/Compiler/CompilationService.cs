using System;
using System.IO;
using System.Linq;
using Blade.Compiler.Diagnostics;
using Blade.Compiler.Preprocessing;
using Blade.Compiler.Transformation;
using Blade.Compiler.Translation;
using Blade.Compiler.Validation;
using Roslyn.Compilers;
using Roslyn.Services;

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
        public CompilationResult CompileProject(string projectPath, string scriptPath = null)
        {
            // ensure project path is valid
            if (String.IsNullOrEmpty(projectPath) || !File.Exists(projectPath))
                return CompilationResult.FatalError("Unable to locate project file at " + projectPath);

            // load project and create compilation
            var project = Workspace.LoadStandAloneProject(projectPath)
                .CurrentSolution.Projects.Single();

            if (project == null)
                return CompilationResult.FatalError("Unable to open project file at " + projectPath);

            var compilation = project.GetCompilation();

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
    }
}