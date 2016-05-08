using System;

public class Program {
    public static void Main(string[] args) {

        int number1;
        int number2;
        int sum;

        Console.Write("Enter first int: ");
        number1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter second int: ");
        number2 = Convert.ToInt32(Console.ReadLine());

        sum = number1 + number2;

        Console.WriteLine("Sum is {0}", sum);

    }
}