using System;

namespace System.Collections.Generic
{
    public interface IEnumerator<out T> : IEnumerator, IDisposable
    {
        T Current { get; }
    }
}
