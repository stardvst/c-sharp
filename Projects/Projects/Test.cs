using System;

public class Program {
    public static void Main(string[] args) {

        Rectangle rect = new Rectangle(5, 3);
        Console.WriteLine("Perimeter: {0}, Area: {1}",
            rect.Perimeter, rect.Area);

    }
}