using System.IO;
using Blade.Utilities.Interop;
using Microsoft.Build.Framework;
using Microsoft.Build.Utilities;
using System;

namespace Blade.Build
{
    /// <summary>
    /// A task which writes dependent script files to the output directory.
    /// </summary>
    public class ScriptDependencyTask : AppDomainIsolatedTask
    {
        /// <summary>
        /// Gets or sets the target assembly path.
        /// </summary>
        [Required]
        public string AssemblyPath { get; set; }

        /// <summary>
        /// Gets or sets the target output directory.
        /// </summary>
        [Required]
        public string TargetDir { get; set; }

        /// <summary>
        /// Gets or sets the target framework path.
        /// </summary>
        public string FrameworkPath { get; set; }

        /// <summary>
        /// Executes the task.
        /// </summary>
        /// <returns></returns>
        public override bool Execute()
        {
            //System.Diagnostics.Debugger.Launch();

            if (!String.IsNullOrEmpty(FrameworkPath))
                ScriptDomain.CurrentDomain.AddSearchDirectory(FrameworkPath);

            var assembly = ScriptAssembly.Load(AssemblyPath);
            var dependencies = assembly.GetDependencyChain();

            // copy all dependent script files into output dir
            foreach (var item in dependencies)
            {
                if (item.HasScriptResource)
                {
                    var path = Path.Combine(TargetDir, item.ScriptName + ".js");
                    File.WriteAllText(path, item.GetScriptResourceText());
                }
            }

            // also, if the target assembly has specified a name
            // for the output script, rename the existing file
            if (assembly.Name != assembly.ScriptName)
            {
                var original = Path.Combine(TargetDir, assembly.Name + ".js");
                var target = Path.Combine(TargetDir, assembly.ScriptName + ".js");

                // move will not overwrite files
                if (File.Exists(target))
                    File.Delete(target);

                File.Move(original, target);
            }

            return true;
        }
    }
}