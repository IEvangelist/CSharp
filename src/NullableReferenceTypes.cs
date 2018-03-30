public class Person {
  public string FirstName { get; }
  public string MiddleName { get; }
  public string LastName { get; }
  
  public Person(
    string firstName,
    string middleName,
    string lastName) {
    FirstName = firstName;
    MiddleName = middleName;
    LastName = lastName;
  }
  
  public Person(string firstName, string lastName)
    : this (firstName, null, lastName) { }
}

public void NullReferenceException() {
  var person = new Person("David", "Pine");
  
  // Will throw NullReferenceException!
  Console.WriteLine(person.MiddleName);
}
