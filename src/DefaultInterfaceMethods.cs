public interface IDataRepository<T> where T : IRecord {
    void Create(T value);
}

public interface IDataRepository<T> where T : IRecord {
    void Create(T value);
    
    void CreateAll(T[] values) {
      foreach (var value in values) {
        Create(value);
      }
    }
}









// Hacker!
