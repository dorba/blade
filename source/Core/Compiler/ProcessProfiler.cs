using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;

namespace Blade.Compiler
{
    /// <summary>
    /// Internal helper class for benchmarking process execution.
    /// </summary>
    internal class ProcessProfiler
    {
        private ICompilationProcess _currentProcess;
        private Dictionary<ICompilationProcess, long> _executionTimes;
        private Stopwatch _timer;

        public Dictionary<string, long> Results
        {
            get { return _executionTimes.ToDictionary(k => k.Key.GetType().Name, v => v.Value); }
        }

        public ProcessProfiler()
        {
            _executionTimes = new Dictionary<ICompilationProcess, long>();
            _timer = new Stopwatch();
        }

        public void Execute(ICompilationProcess process, CompilationContext context)
        {
            Begin(process);
            process.Execute(context);
            End();
        }

        public void Begin(ICompilationProcess process)
        {
            if (!_executionTimes.ContainsKey(process))
                _executionTimes.Add(process, 0);

            _currentProcess = process;
            _timer.Restart();
        }

        public void End()
        {
            if (_currentProcess != null)
            {
                _timer.Stop();

                _executionTimes[_currentProcess] = _timer.ElapsedMilliseconds;
                _currentProcess = null;
            }
        }
    }
}