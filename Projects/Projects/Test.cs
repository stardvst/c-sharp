using System;

public class Program {
    public static void Main(string[] args) {

        Date birth = new Date(24, 7, 1949);
        Date hire = new Date(12, 3, 1988);
        Employee employee = new Employee("Bob", "Blue", birth, hire);

        Console.WriteLine(employee);

    }
}