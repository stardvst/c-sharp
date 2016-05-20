using System;

public class Employee {

    public static int Count { get; private set; }

    public string FirstName { get; private set; }
    public string LastName { get; private set; }
    
    public Employee(string first, string last) {
        FirstName = first;
        LastName = last;
        ++Count;
        Console.WriteLine("Employee constructor: {0} {1}; Count = {2}",
            FirstName, LastName, Count);
    }
  

}