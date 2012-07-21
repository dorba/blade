using System;
using System.Collections.Generic;
using System.Linq;
using Roslyn.Compilers;

namespace Blade.Compiler.Models
{
    /// <summary>
    /// Represents a class declaration.
    /// </summary>
    public sealed class ClassDeclaration : TypeDeclarationModel<ClassDefinition>
    {
        /// <summary>
        /// Gets the constructor models.
        /// </summary>
        public IList<ConstructorDeclaration> Constructors
        {
            get { return _constructors; }
        } private List<ConstructorDeclaration> _constructors;

        /// <summary>
        /// Gets the field models.
        /// </summary>
        public IList<FieldDeclaration> Fields
        {
            get { return _fields; }
        } private List<FieldDeclaration> _fields;

        /// <summary>
        /// Gets the property models.
        /// </summary>
        public IList<PropertyDeclaration> Properties
        {
            get { return _properties; }
        } private List<PropertyDeclaration> _properties;

        /// <summary>
        /// Gets the method models.
        /// </summary>
        public IList<MethodDeclaration> Methods
        {
            get { return _methods; }
        } private List<MethodDeclaration> _methods;

        /// <summary>
        /// Gets the event models.
        /// </summary>
        public IList<EventDeclaration> Events
        {
            get { return _events; }
        } private List<EventDeclaration> _events;

        /// <summary>
        /// Gets a value indicating whether or not the class is derived.
        /// Note that classes derived explicitly from object still return false.
        /// </summary>
        public bool IsDerived
        {
            get
            {
                return Definition.BaseClass != null &&
                    Definition.BaseClass.Symbol.SpecialType != SpecialType.System_Object;
            }
        }

        /// <summary>
        /// Creates a new instance of the class.
        /// </summary>
        public ClassDeclaration()
        {
            _constructors = new List<ConstructorDeclaration>();
            _fields = new List<FieldDeclaration>();
            _properties = new List<PropertyDeclaration>();
            _methods = new List<MethodDeclaration>();
            _events = new List<EventDeclaration>();
        }

        /// <summary>
        /// Gets all available member declarations.
        /// </summary>
        /// <returns>A collection of member declarations.</returns>
        public override IEnumerable<IMemberDeclarationModel> GetMemberDeclarations()
        {
            return Enumerable.Empty<IMemberDeclarationModel>()
                .Concat(Constructors)
                .Concat(Fields)
                .Concat(Properties)
                .Concat(Methods)
                .Concat(Events);
        }

        /// <summary>
        /// Adds a member to the type.
        /// </summary>
        /// <param name="member">The target member.</param>
        public override void AddMember(IMemberDeclarationModel member)
        {
            var ctor = member as ConstructorDeclaration;
            if (ctor != null && !Constructors.Contains(ctor))
            {
                Constructors.Add(ctor);
                return;
            }

            var field = member as FieldDeclaration;
            if (field != null && !Fields.Contains(field))
            {
                Fields.Add(field);
                return;
            }

            var prop = member as PropertyDeclaration;
            if (prop != null && !Properties.Contains(prop))
            {
                Properties.Add(prop);
                return;
            }

            var method = member as MethodDeclaration;
            if (method != null && !Methods.Contains(method))
            {
                Methods.Add(method);
                return;
            }

            var evt = member as EventDeclaration;
            if (evt != null && !Events.Contains(evt))
            {
                Events.Add(evt);
                return;
            }

            throw new NotImplementedException("Member insertion not implemented for type: " + member.GetType().FullName);
        }
    

        /// <summary>
        /// Removes a member from the type.
        /// </summary>
        /// <param name="member">The target member.</param>
        public override void RemoveMember(IMemberDeclarationModel member)
        {

            var ctor = member as ConstructorDeclaration;
            if (ctor != null && Constructors.Contains(ctor))
            {
                Constructors.Remove(ctor);
                return;
            }

            var field = member as FieldDeclaration;
            if (field != null && Fields.Contains(field))
            {
                Fields.Remove(field);
                return;
            }

            var prop = member as PropertyDeclaration;
            if (prop != null && Properties.Contains(prop))
            {
                Properties.Remove(prop);
                return;
            }

            var method = member as MethodDeclaration;
            if (method != null && Methods.Contains(method))
            {
                Methods.Remove(method);
                return;
            }

            var evt = member as EventDeclaration;
            if (evt != null && Events.Contains(evt))
            {
                Events.Remove(evt);
                return;
            }

            throw new NotImplementedException("Member removal not implemented for type: " + member.GetType().FullName);
        }
    }
}
