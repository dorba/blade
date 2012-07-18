using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Blade.Tools.Quality.Build.Templates;
using Roslyn.Compilers;
using Roslyn.Compilers.CSharp;

namespace Blade.Tools.Quality.Build
{
    /// <summary>
    /// Utility class for creating template models from source code.
    /// </summary>
    internal class TestCompilation
    {
        /// <summary>
        /// Gets the resulting class template models.
        /// </summary>
        public IEnumerable<TestClassTemplateModel> TemplateModels { get; private set; }

        /// <summary>
        /// Creates a new instance of the class.
        /// </summary>
        /// <param name="sourcePaths">The source files.</param>
        /// <param name="refPaths">The assembly reference paths.</param>
        public TestCompilation(IEnumerable<string> sourcePaths, IEnumerable<string> refPaths)
        {
            var compilation = Compilation.Create("Blade.Test.dll",
                new CompilationOptions(OutputKind.DynamicallyLinkedLibrary),
                sourcePaths.Select(p => SyntaxTree.ParseCompilationUnit(File.ReadAllText(p))),
                refPaths.Select(p => new AssemblyFileReference(p)));

            var targets = new List<Tuple<NamedTypeSymbol, List<MethodSymbol>>>();

            foreach (var tree in compilation.SyntaxTrees)
            {
                var semantics = compilation.GetSemanticModel(tree);

                var targetClasses = tree.GetRoot().DescendantNodes()
                    .OfType<ClassDeclarationSyntax>()
                    .Select(c => semantics.GetDeclaredSymbol(c))
                    .Where(s => s.GetAttributes("Microsoft.VisualStudio.TestTools.UnitTesting", "TestClassAttribute").Any());

                foreach (var item in targetClasses)
                {
                    targets.Add(new Tuple<NamedTypeSymbol, List<MethodSymbol>>(item,
                        item.GetMembers().OfType<MethodSymbol>()
                        .Where(s => s.MethodKind == MethodKind.Ordinary &&
                            s.GetAttributes("Microsoft.VisualStudio.TestTools.UnitTesting", "TestMethodAttribute").Any()).ToList()));
                }
            }

            TemplateModels = targets.Select(t => new TestClassTemplateModel
            {
                Name = t.Item1.Name,
                Namespace = t.Item1.ContainingNamespace.ToDisplayString(),
                Methods = t.Item2.Select(m => m.Name)
            });
        }
    }
}