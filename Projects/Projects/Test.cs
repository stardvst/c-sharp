using System;

public class Program {
    public static void Main(string[] args) {

        SalariedEmployee salariedEmployee =
            new SalariedEmployee("John", "Smith", "111-11-1111", 800.00M);
        HourlyEmployee hourlyEmployee =
            new HourlyEmployee("Karen", "Price",
            "222-22-2222", 16.75M, 40.0M);

        Console.WriteLine("Employees processed individually:\n");
        Console.WriteLine("{0}\nearned: {1:C}\n",
            salariedEmployee, salariedEmployee.Earnings());
        Console.WriteLine("{0}\nearned: {1:C}\n",
            hourlyEmployee, hourlyEmployee.Earnings());

        Employee[] employees = new Employee[2];

        employees[0] = salariedEmployee;
        employees[1] = hourlyEmployee;

        Console.WriteLine("Employees processed polymorphically:\n");
        foreach (Employee current in employees) {
            Console.WriteLine(current);
            Console.WriteLine("earned {0:C}\n", current.Earnings());
        }

        for (int j = 0; j < employees.Length; j++)
            Console.WriteLine("Employee {0} is a {1}", j,
            employees[j].GetType());

    }
}