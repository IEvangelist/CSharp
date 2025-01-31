public interface IDataRepository<T> where T : IRecord {
    void Create(T value);
}

public interface IDataRepository<T> where T : IRecord {
    void Create(T value);
    
    // We want to add this API
    // But it will break everyone who
    // doesn't implement it...
    void CreateAll(T[] values);
}

public interface IDataRepository<T> where T : IRecord {
    void Create(T value);
    
    // We can provide a default impl.
    // And allow opt-in, non-breaking!
    void CreateAll(T[] values) {
      foreach (var value in values) {
        Create(value);
      }
    }
}









// Hacker!
