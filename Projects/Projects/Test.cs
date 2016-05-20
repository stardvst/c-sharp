using System;

public class Program {
    public static void Main(string[] args) {

        Console.WriteLine("Employees before instantiation: {0}",
            Employee.Count);

        Employee e1 = new Employee("Susan", "Baker");
        Employee e2 = new Employee("Bob", "Blue");

        Console.WriteLine("\nEmployees after instantiation: {0}",
            Employee.Count);

        Console.WriteLine("\nEmployee 1: {0} {1}\nEmployee 2: {2} {3}\n",
            e1.FirstName, e1.LastName,
            e2.FirstName, e2.LastName);

        e1 = null; // mark object referenced by e1 as no longer needed
        e2 = null; // mark object referenced by e2 as no longer needed

    }
}