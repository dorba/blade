using System.Collections.Generic;
using System.Linq;

namespace Blade.Compiler.Preprocessing
{
    /// <summary>
    /// Sorts preprocessors in dependency order.
    /// </summary>
    internal class PreprocessorSorter
    {
        public IEnumerable<IPreprocessor> Sort(IEnumerable<IPreprocessor> preprocessors)
        {
            var preProcList = preprocessors.ToList();

            foreach (var item in preprocessors)
            {
                // return items with no dependencies.
                if (!item.GetDependencies().Any())
                {
                    preProcList.Remove(item);
                    yield return item;
                }
            }

            // return ordered dependent items
            while (preProcList.Any())
            {
                var next = GetNextInstance(preProcList.First(), preProcList);

                yield return next;
                preProcList.Remove(next);
            }
        }

        private IPreprocessor GetNextInstance(IPreprocessor target, IList<IPreprocessor> list)
        {
            var deps = GetDependentInstances(target, list);

            foreach (var item in deps)
            {
                return GetNextInstance(item, list);
            }

            return target;
        }

        private IEnumerable<IPreprocessor> GetDependentInstances(IPreprocessor target, IList<IPreprocessor> list)
        {
            var targetDeps = target.GetDependencies();

            return list.Where(p => targetDeps
                    .Any(d => p.GetType().Equals(d)));
        }
    }
}