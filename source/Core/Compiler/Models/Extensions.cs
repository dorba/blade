using System;
using System.Linq;
using Roslyn.Compilers.Common;

namespace Blade.Compiler.Models
{
    /// <summary>
    /// Extension methods for models.
    /// </summary>
    public static class Extensions
    {
        /// <summary>
        /// Gets a value indicating if the type is numeric.
        /// </summary>
        /// <param name="this">This context.</param>
        /// <returns>True if the type is numeric, false otherwise.</returns>
        public static bool IsNumericType(this PredefinedType @this)
        {
            return ((int)@this) > 3;
        }

        /// <summary>
        /// Gets a value indicating if the type is integral.
        /// </summary>
        /// <param name="this">This context.</param>
        /// <returns>True if the type is integral, false otherwise.</returns>
        public static bool IsIntegralType(this PredefinedType @this)
        {
            return IsNumericType(@this) && (((int)@this) < 12);
        }

        /// <summary>
        /// Gets the full namespace for the symbol.
        /// </summary>
        /// <param name="this"></param>
        /// <returns></returns>
        public static string GetFullNamespace(this ISymbol @this)
        {
            if (@this == null)
                return "";

            // do not apply namespace to local symbols
            if (@this.Kind == CommonSymbolKind.Local)
                return "";

            var ns = @this.ContainingNamespace;
            if (ns == null || ns.IsGlobalNamespace)
                return "";

            var parentNs = GetFullNamespace(ns);
            var prefix = (!String.IsNullOrEmpty(parentNs) ? (parentNs + ".") : "");

            return prefix + ns.Name;
        }

        /// <summary>
        /// Gets the full type name.
        /// </summary>
        /// <param name="this">This context.</param>
        /// <returns>A type name.</returns>
        public static string GetFullName(this ISymbol @this)
        {
            if (@this == null)
                return null;

            var name = @this.Name;
            if (@this.ContainingType != null)
                name = @this.ContainingType.Name + "." + @this.Name;

            var ns = GetFullNamespace(@this);

            return ((!String.IsNullOrEmpty(ns)) ? (ns + ".") : "") + name;
        }

        /// <summary>
        /// Gets the fully qualified type name.
        /// </summary>
        /// <param name="this">This context.</param>
        /// <returns>A new string.</returns>
        public static string GetFullName(this ITypeDefinition @this)
        {
            if (@this == null)
                return "";

            return String.Join(".", (new[] { @this.Namespace, @this.Name }).Where(x => !String.IsNullOrEmpty(x)));
        }

        /// <summary>
        /// Gets the fully qualified member name.
        /// </summary>
        /// <param name="this">This context.</param>
        /// <returns>A new string.</returns>
        public static string GetFullName(this IMemberDefinition @this)
        {
            if (@this == null)
                return "";

            if (@this.ContainingType == null)
                return @this.Name;

            return String.Join(".", (new[] { @this.ContainingType.GetFullName(), @this.Name }).Where(x => !String.IsNullOrEmpty(x)));
        }

        /// <summary>
        /// Gets the fully qualified name, if applicable.
        /// </summary>
        /// <param name="this">This context.</param>
        /// <returns>A new string.</returns>
        public static string GetFullName(this IDefinition @this)
        {
            if (@this == null)
                return "";

            var typeDefModel = @this as ITypeDefinition;
            if (typeDefModel != null)
                return GetFullName(typeDefModel);

            var memberDefModel = @this as IMemberDefinition;
            if (memberDefModel != null)
                return GetFullName(memberDefModel);

            return @this.Name;
        }

        /// <summary>
        /// Gets the definition associated with a model, or null if not available.
        /// </summary>
        /// <param name="this">This context.</param>
        /// <returns>The definition, or null.</returns>
        public static IDefinition GetDefinition(this IModel @this)
        {
            if (@this == null)
                return null;

            var symModel = @this as ISymbolicModel;
            if (symModel == null)
                return null;

            return symModel.Definition;
        }

        /// <summary>
        /// Gets the definition associated with a model, or null if not available.
        /// </summary>
        /// <typeparam name="T">The expected definition type.</typeparam>
        /// <param name="this">This context.</param>
        /// <returns>The definition, or null.</returns>
        public static T GetDefinitionAs<T>(this IModel @this) where T : class, IDefinition
        {
            return GetDefinition(@this) as T;
        }

        /// <summary>
        /// Gets the symbol associated with a model, or null if not available.
        /// </summary>
        /// <param name="this">This context.</param>
        /// <returns>The symbol, or null.</returns>
        public static ISymbol GetSymbol(this IModel @this)
        {
            var def = GetDefinition(@this);
            if (def == null)
                return null;

            return def.Symbol;
        }

        /// <summary>
        /// Gets the symbol associated with a model, or null if not available.
        /// </summary>
        /// <typeparam name="T">The expected symbol type.</typeparam>
        /// <param name="this">This context.</param>
        /// <returns>The symbol, or null.</returns>
        public static T GetSymbolAs<T>(this IModel @this) where T : class, ISymbol
        {
            return GetSymbol(@this) as T;
        }
    }
}
