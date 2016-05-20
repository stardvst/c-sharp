using System;
using System.Linq;

public class Program {
    public static void Main(string[] args) {

        Console.Write("Enter a senctence: ");
        string input = Console.ReadLine();

        var orderedWords =
            from word in input.Split()
            orderby word.ToLower()
            select word.ToLower();
        
        foreach (var word in orderedWords.Distinct()) {
            Console.Write("{0} ", word);
        }   

    }
}