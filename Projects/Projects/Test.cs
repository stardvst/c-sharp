using System;

public class Program {
    public static void Main(string[] args) {

        Time t1 = new Time(); // 00:00:00
        Time t2 = new Time(2); // 02:00:00
        Time t3 = new Time(21, 34); // 21:34:00
        Time t4 = new Time(12, 25, 42); // 12:25:42
        Time t5 = new Time(t4); // 12:25:42
        Time t6; // initialized later in the program

        Console.WriteLine("Constructed with:\n");
        Console.WriteLine("t1: all arguments defaulted");
        Console.WriteLine(" {0}", t1.ToUniversalString()); // 00:00:00
        Console.WriteLine(" {0}\n", t1.ToString()); // 12:00:00 AM

        Console.WriteLine("t2: hour specified; minute and second defaulted");
        Console.WriteLine(" {0}", t2.ToUniversalString()); // 02:00:00
        Console.WriteLine(" {0}\n", t2.ToString()); // 2:00:00 AM

        Console.WriteLine("t3: hour and minute specified; second defaulted");
        Console.WriteLine(" {0}", t3.ToUniversalString()); // 21:34:00
        Console.WriteLine(" {0}\n", t3.ToString()); // 9:34:00 PM

        Console.WriteLine("t4: hour, minute and second specified");
        Console.WriteLine(" {0}", t4.ToUniversalString()); // 12:25:42
        Console.WriteLine(" {0}\n", t4.ToString()); // 12:25:42 PM

        Console.WriteLine("t5: Time2 object t4 specified");
        Console.WriteLine(" {0}", t5.ToUniversalString()); // 12:25:42
        Console.WriteLine(" {0}", t5.ToString()); // 12:25:42 PM

        try {
            t6 = new Time(27, 74, 99);
        }
        catch(ArgumentOutOfRangeException ex) {
            Console.WriteLine("\nException while initializing t6:");
            Console.WriteLine(ex.Message);
        }

    }
}