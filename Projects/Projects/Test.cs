using System;
using System.Linq;

 public class Program {
    public static void Main(string[] args) {

        int[] values = { 2, 9, 5, 0, 3, 7, 1, 4, 8, 5 };

        Console.Write("Original array:");
        foreach (var element in values) {
            Console.Write(" {0}", element);
        }

        // filtering
        var filtered =
            from value in values
            where value > 4
            select value;

        Console.Write("\nArray values greater than 4:");
        foreach (var element in filtered) {
            Console.Write(" {0}", element);
        }

        // sorting
        var sorted =
            from value in values
            orderby value
            select value;

        Console.Write("\nOriginal array, sorted:");
        foreach (var element in sorted) {
            Console.Write(" {0}", element);
        }

        // sort the filtered results into descending order
        var sortFilteredResults =
            from value in filtered
            orderby value descending
            select value;

        Console.Write(
            "\nValues greater than 4, descending order (separately):");
        foreach (var element in sortFilteredResults) {
            Console.Write(" {0}", element);
        }
                                                                      
        // filter original array and sort results in descending order
        var sortedAndFiltered =
            from value in values
            where value > 4
            orderby value descending
            select value;

        Console.Write(
            "\nValues greater than 4, descending order (one query):");
        foreach (var element in sortedAndFiltered) {
            Console.WriteLine(" {0}", element);
        }
                
    }
}