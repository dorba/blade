using System.Collections.Generic;
using System.Linq;
using Blade.Compiler.Models;
using Roslyn.Compilers;

namespace Blade.Compiler.Translation
{
    /// <summary>
    /// Internal helper class for sorting class models in dependency order.
    /// </summary>
    internal static class ClassSorter
    {
        public static IEnumerable<ClassDeclaration> Sort(IEnumerable<ClassDeclaration> input)
        {
            if (input == null)
                yield break;

            // alpha order by default.
            var list = input.OrderBy(c => c.Definition.GetFullName()).ToList();

            for (int i = 0; i < list.Count; i++)
            {
                // items with no dependencies
                if (!HasDependencies(list[i]))
                {
                    yield return list[i];
                    list.Remove(list[i]);
                    i--;
                }
            }

            // items in dependency order
            var target = list.FirstOrDefault();
            while (target != null)
            {
                var next = target;
                while (next != null)
                {
                    target = next;
                    next = list.SingleOrDefault(c => c.Definition.GetFullName() == next.Definition.BaseClass.GetFullName());
                }

                yield return target;
                list.Remove(target);

                target = list.FirstOrDefault();
            }
        }

        private static bool HasDependencies(ClassDeclaration classDecl)
        {
            if (classDecl.Definition.BaseClass != null)
            {
                return classDecl.Definition.BaseClass.Symbol.SpecialType != SpecialType.System_Object;
            }

            return false;
        }
    }
}
