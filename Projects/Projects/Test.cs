using System;

public class Program {
    public static void Main(string[] args) {

        Time time = new Time();

        Console.Write("The initial universal time is: ");
        Console.WriteLine(time.toUniversalString());
        Console.Write("The initial standard time is: ");
        Console.WriteLine(time.ToString());
        Console.WriteLine();

        time.SetTime(13, 27, 6);
        Console.Write("Universal time after SetTime is: ");
        Console.WriteLine(time.toUniversalString());
        Console.Write("Standard time after SetTime is: ");
        Console.WriteLine(time.ToString());
        Console.WriteLine();

        try {
            time.SetTime(99, 99, 99);
        }
        catch(ArgumentOutOfRangeException exp) {
            Console.WriteLine(exp.Message + "\n");
        }

        Console.WriteLine("After attempting invalid settings:");
        Console.Write("Universal time: ");
        Console.WriteLine(time.toUniversalString());
        Console.Write("Standard time: ");
        Console.WriteLine(time.ToString());
    }
}