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
  
  // Get middle initial, will throw NullReferenceException!
  Console.WriteLine(person.MiddleName.SubString(0, 1));
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
  Console.WriteLine(person.MiddleName.SubString(0, 1));
}

public void TakeSuggestion() {  
  var person = new NewPerson("David", "Pine");
  
  if (person.MiddleName != null)
  {
     Console.WriteLine(person.MiddleName);
  }  
}




// Hacker!
