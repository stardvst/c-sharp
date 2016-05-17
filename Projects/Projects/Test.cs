using System;
using System.Collections.Generic;

public class Program {
    public static void Main(string[] args) {

        List<string> items = new List<string>();

        items.Add("red");
        items.Insert(0, "yellow");

        // for loop
        Console.Write("Display list contents with counter-controlled loop:");
        for (int i = 0; i < items.Count; i++) {
            Console.Write(" {0}", items[i]);
        }

        // foreach loop
        Console.Write("\nDisplay list contents with foreach statement:");
        foreach (var item in items) {
            Console.Write(" {0}", item);
        }

        items.Add("green");
        items.Add("yellow");

        Console.Write("\nList with two new elements:");
        foreach (var item in items) {
            Console.Write(" {0}", item);
        }

        // remove item
        items.Remove("yellow");
        Console.Write("\nRemove first instance of yellow:");
        foreach (var item in items) {
            Console.Write(" {0}", item);
        }

        // remove at index 1
        items.RemoveAt(1);
        Console.Write("\nRemove second list element (green):");
        foreach (var item in items) {
            Console.Write(" {0}", item);
        }

        Console.WriteLine("\n\"red\" is {0}in the list",
            items.Contains("red") ? string.Empty : "not ");

        Console.WriteLine("Count: {0}", items.Count);
        Console.WriteLine("Capacity: {0}", items.Capacity);

    }
}