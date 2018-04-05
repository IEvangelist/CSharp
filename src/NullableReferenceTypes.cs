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

public class NewPerson {
  public string FirstName { get; }
  public string? MiddleName { get; }
  public string LastName { get; }
  
  // Same .ctor's
}

public void Warnings() {  
  var person = new NewPerson("David", "Pine");
  
  // Visual Studio Issues a Warning!
  Console.WriteLine(person.MiddleName);
}

public void TakeSuggestion() {  
  var person = new NewPerson("David", "Pine");
  
  // Visual Studio Issues a Warning!
  if (person.MiddleName is null)
  {
     return;
  }
  
  Console.WriteLine(person.MiddleName);
}




// Hacker!
