using System;
using System.Collections.Generic;
using Blade.Compiler.Models;
using Roslyn.Compilers.CSharp;

namespace Blade.Compiler.Validation
{
    /// <summary>
    /// Ensures that no class models have overloaded methods.
    /// </summary>
    [ModelValidator]
    internal class MethodOverloadValidator : IModelValidator
    {
        /// <summary>
        /// Validates the generated model.
        /// </summary>
        /// <param name="model">The compilation model.</param>
        /// <param name="result">The compilation result.</param>
        public void Validate(CompilationModel model, CompilationResult result)
        {
            var instanceMethods = new List<string>();
            var staticMethdos = new List<string>();

            foreach (var item in model.Classes)
            {
                instanceMethods.Clear();
                staticMethdos.Clear();

                foreach (var method in item.Methods)
                {
                    ValidateMethod(method, (method.IsStatic ? staticMethdos : instanceMethods), result);
                }
            }
        }

        private void ValidateMethod(MethodDeclaration method, List<string> list, CompilationResult result)
        {
            var name = method.Name;

            if (String.IsNullOrWhiteSpace(name))
            {
                result.AddError(new CompilationMessage
                {
                    FilePath = method.OriginatingTree != null ? method.OriginatingTree.FilePath : null,
                    Location = DocumentLocation.FromTreeNode(method.OriginatingTree, method.OriginatingNode),
                    Message = "All generated method calls must have a valid name."
                });

                return;
            }

            if (list.Contains(name))
            {
                result.AddError(new CompilationMessage
                {
                    FilePath = method.OriginatingTree != null ? method.OriginatingTree.FilePath : null,
                    Location = DocumentLocation.FromTreeNode(method.OriginatingTree, method.OriginatingNode),
                    Message = "Method overloading is not supported. Consider using optional parameters, " +
                        "or providing an alternate name using the ScriptName attribute."
                });

                return;
            }

            list.Add(name);
        }
    }
}