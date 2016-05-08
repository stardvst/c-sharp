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

        if (number1 == number2) {
            Console.WriteLine("{0} = {1}", number1, number2);
        }

        if (number1 != number2) {
            Console.WriteLine("{0} != {1}", number1, number2);
        }

        if (number1 > number2) {
            Console.WriteLine("{0} > {1}", number1, number2);
        }

        if (number1 < number2) {
            Console.WriteLine("{0} < {1}", number1, number2);
        }

        if (number1 >= number2) {
            Console.WriteLine("{0} >= {1}", number1, number2);
        }

        if (number1 <= number2) {
            Console.WriteLine("{0} <= {1}", number1, number2);
        }

    }
}