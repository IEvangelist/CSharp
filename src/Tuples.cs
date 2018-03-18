void LegacyTuple() {
    var letters = new Tuple<string, string>("a", "b");
    var a = letters.Item1;
    var b = letters.Item2;

    // Compile error!
    // letters.Item1 = "c";
}

void ValueTuple() {
    var letters = ("a", "b"); // Literal
    var a = letters.Item1;
    var b = letters.Item2;

    // Valid, do NOT do!
    letters.Item1 = "c";

    // Note: ToTuple extension method
    var systemTuple = letters.ToTuple();
    var c = systemTuple.Item1;
    var d = systemTuple.Item2;

    var stringAndNumber = ("programming is fun", 7);
    var s = stringAndNumber.Item1;
    var n = stringAndNumber.Item2;

    // Example to show IntelliSense
    var wordAndNum = (Word: "programming", Number: 7);

    // .Item1 and .Item2 are actually hidden
    var word = wordAndNum.Word; 
    var number = wordAndNum.Number;

    // Complete re-assign
    wordAndNum = ("is fun", 10);

    // Deconstruction
    (string str0, int num0) = wordAndNum;
    (var str1, var num1) = wordAndNum;
    var (str2, num2) = wordAndNum;

    if (s == str0 && n == num0 &&
        s == str1 && n == num1 &&
        s == str2 && n == num2)
    {
        // This would get executed...
    }

    // Liteal instantly deconstructed
    var (now, tenSeconds) =
        (DateTime.Now, TimeSpan.FromSeconds(10));
}

void InstantiatePerson() {
    var person = new Person(("David", "Pine"), 32);
    var firstName = person.Name.First;
    var lastName = person.Name.Last;
    var age = person.Age;

    // Using explicitly defined "Deconstruct"
    // method on a non-tuple object
    var (_, _, _) = person;
    var (first, _, _) = person;
    var (frst, lst, _) = person;
    var (f, l, a) = person;

    // Cherry pick
    var (_, theLastName, _) = person;

    // Note: the use of the _ doesn't actually declare the variable
    // It is not available, it is a way to ignore that ordinal.
}

class Person {
  internal (string First, string Last) Name { get; private set; }

  internal int Age { get; private set; }

  internal Person((string FirstName, string LastName) name, 
                  int age) {
      Name = name;
      Age = age;
  }

  public void Deconstruct(out (string, string) name,
                          out int age) {
      name = Name;
      age = Age;
  }

  public void Deconstruct(out string first, 
                          out string last, 
                          out int age) {
      first = Name.First;
      last = Name.Last;
      age = Age;
  }

  public void CopyTo(Person person) 
      => (person.Name, person.Age) = (Name, Age);

  public override string ToString() 
      => $"{Name.First} {Name.Last} ({Age})";
}










// Hacker!
