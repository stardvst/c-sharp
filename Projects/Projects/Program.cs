using System;

public class Program {
    public static void Main(string[] args) {

        int[] array = { 87, 68, 94, 100, 83, 78, 85, 91, 76, 87 };
        int total = 0;

        foreach (int number in array) {
            total += number;
        }

        Console.WriteLine("Total: {0}", total);

    }
}