using System;
using System.Linq;

public class Program {
    public static void Main(string[] args) {

        Employee[] employees = {
                new Employee( "Jason", "Red", 5000M ),
                new Employee( "Ashley", "Green", 7600M ),
                new Employee( "Matthew", "Indigo", 3587.5M ),
                new Employee( "James", "Indigo", 4700.77M ),
                new Employee( "Luke", "Indigo", 6200M ),
                new Employee( "Jason", "Blue", 3200M ),
                new Employee( "Wendy", "Brown", 4236.4M )
        };

        Console.WriteLine("Original array:");
        foreach (var element in employees) {
            Console.WriteLine(element);
        }

        // between 4000 and 6000
        var between4K6K =
            from employee in employees
            where employee.MonthLySalary >= 4000M &&
                employee.MonthLySalary <= 6000M
            select employee;

        Console.WriteLine(string.Format("\nEmployees earning in the " +
            "range {0:C}-{1:C} per month:", 4000, 6000));
        foreach (var element in between4K6K) {
            Console.WriteLine(element);
        }

        // order by last then first name 
        var nameSorted =
            from employee in employees
            orderby employee.LastName, employee.FirstName
            select employee;

        Console.WriteLine("\nFirst employee when sorted by name:");
        if (nameSorted.Any()) { // if (nameSorted.Count() != 0)
            Console.WriteLine(nameSorted.First());
        } else {
            Console.WriteLine("No first employee found");
        }

        // select last names
        var lastnames =
            from employee in employees
            select employee.LastName;

        // select distinct names in lastnames
        Console.WriteLine("\nUnique employee last names:");
        foreach (var element in lastnames.Distinct()) {
            Console.WriteLine(element);
        }

        // select first and last names
        var names =
            from employee in employees
            // new creates an anonymous type
            // LastName changes to Last, FirstName remains the same
            // the compiler automatically generates a ToString method
            select new { employee.FirstName, Last = employee.LastName }; 

        // display full names
        Console.WriteLine("\nNames only:");
        foreach (var element in names) {
            Console.WriteLine(element);
        }

    }
}