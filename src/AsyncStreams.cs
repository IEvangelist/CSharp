namespace System
{
    // Support for both iterator and async methods!
    // This interface is compatible with IDisposable
    // If both are implemented, calling either is acceptable
    // Subsequent calls are nops.
    
    public interface IAsyncDisposable
    {
        Task DisposeAsync();
    }
}

namespace System.Collections.Generic
{
    public interface IEnumerable<out T>
    {
        IEnumerator<T> GetEnumerator();
    }

    public interface IEnumerator<out T> : IDisposable
    {
        bool MoveNext();
        T Current { get; }
    }
}

namespace System.Collections.Generic
{
    public interface IAsyncEnumerable<out T>
    {
        IAsyncEnumerator<T> GetAsyncEnumerator();
    }

    public interface IAsyncEnumerator<out T> : IAsyncDisposable
    {
        Task<bool> MoveNextAsync();
        T Current { get; }
    }
}









// Hacker!
