using System;

public class Program {
    public static void Main(string[] args) {

        ComplexNumber x, y;

        Console.Write("Enter the real part of complex number x: ");
        double realPart = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter the imaginary part of complex number x: ");
        double imaginaryPart = Convert.ToDouble(Console.ReadLine());

        x = new ComplexNumber(realPart, imaginaryPart);

        Console.Write("Enter the real part of complex number y: ");
        realPart = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter the imaginary part of complex number y: ");
        imaginaryPart = Convert.ToDouble(Console.ReadLine());

        y = new ComplexNumber(realPart, imaginaryPart);

        Console.WriteLine();
        Console.WriteLine("{0} + {1} = {2}", x, y, x + y);
        Console.WriteLine("{0} - {1} = {2}", x, y, x - y);
        Console.WriteLine("{0} * {1} = {2}", x, y, x * y);

    }
}