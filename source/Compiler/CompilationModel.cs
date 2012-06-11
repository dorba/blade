using System;
using System.Collections.Generic;
using System.Linq;
using Blade.Compiler.Models;

namespace Blade.Compiler
{
    /// <summary>
    /// Represents the generated code model.
    /// </summary>
    public sealed class CompilationModel : IModel
    {
        /// <summary>
        /// Gets the enum declaration list.
        /// </summary>
        public IList<EnumDeclaration> Enums
        {
            get { return _enums; }
        } private List<EnumDeclaration> _enums;

        /// <summary>
        /// Gets the class declaration list.
        /// </summary>
        public IList<ClassDeclaration> Classes
        {
            get { return _classes; }
        } private List<ClassDeclaration> _classes;

        /// <summary>
        /// Creates a new instance of the class.
        /// </summary>
        public CompilationModel()
        {
            _enums = new List<EnumDeclaration>();
            _classes = new List<ClassDeclaration>();
        }

        /// <summary>
        /// Merges another compilation model into this one.
        /// </summary>
        /// <param name="model">The model to merge from.</param>
        public void Merge(CompilationModel model)
        {
            foreach (var item in model.Enums)
            {
                Enums.Add(item);
            }

            foreach (var item in model.Classes)
            {
                Classes.Add(item);
            }
        }

        /// <summary>
        /// Gets all available type and member declarations.
        /// </summary>
        /// <returns>A collection of declarations.</returns>
        public IEnumerable<IDeclarationModel> GetAllDeclarations()
        {
            foreach (var item in Enums)
            {
                yield return item;

                foreach (var member in item.Members)
                    yield return member;
            }


            foreach (var item in Classes)
            {
                yield return item;

                foreach (var member in item.GetMemberDeclarations())
                    yield return member;
            }
        }

        /// <summary>
        /// Adds a new type declaration to the model.
        /// </summary>
        /// <param name="typeDecl">The target item.</param>
        public void AddType(ITypeDeclarationModel typeDecl)
        {
            var classDecl = typeDecl as ClassDeclaration;
            if (classDecl != null)
            {
                if (!_classes.Contains(classDecl))
                    _classes.Add(classDecl);

                return;
            }

            var enumDecl = typeDecl as EnumDeclaration;
            if (enumDecl != null)
            {
                if (!_enums.Contains(enumDecl))
                    _enums.Add(enumDecl);

                return;
            }

            throw new NotImplementedException("Type insertion not implemented for type of: " + typeDecl.GetType().FullName);
        }

        /// <summary>
        /// Removes a type declaration from the model.
        /// </summary>
        /// <param name="typeDecl">The target item.</param>
        public void RemoveType(ITypeDeclarationModel typeDecl)
        {
            var classDecl = typeDecl as ClassDeclaration;
            if (classDecl != null)
            {
                if (_classes.Contains(classDecl))
                    _classes.Remove(classDecl);

                return;
            }

            var enumDecl = typeDecl as EnumDeclaration;
            if (enumDecl != null)
            {
                if (_enums.Contains(enumDecl))
                    _enums.Remove(enumDecl);

                return;
            }

            throw new NotImplementedException("Type removal not implemented for type of: " + typeDecl.GetType().FullName);
        }

        /// <summary>
        /// Clears all declarations from the model.
        /// </summary>
        public void Clear()
        {
            Enums.Clear();
            Classes.Clear();
        }
    }
}
