using System;
using System.Linq;

public class Program {
    public static void Main(string[] args) {

        Invoice[] invoices = {
                new Invoice( "83", "Electric sander", 7, 57.98M ),
                new Invoice( "24", "Power saw", 18, 99.99M ),
                new Invoice( "77", "Sledge hammerr", 11, 21.50M ),
                new Invoice( "7", "Hammer", 76, 11.99M ),
                new Invoice( "39", "Lawn mower", 3, 79.50M ),
                new Invoice( "68", "Screwdriver", 106, 6.99M ),
                new Invoice( "56", "Jig saw", 21, 11.00M ),
                new Invoice( "3", "Wrench", 34, 7.50M )
        };

        Console.WriteLine("Original array:");
        Console.WriteLine("{0} {1, 20} {2, 10} {3, 10}",
            "PartNumber", "PartDescription", "Quantity", "Price");
        foreach (var element in invoices) {
            Console.WriteLine(element.ToString());
        }

        // using LINQ to sort the Invoice objects by PartDescription
        var sortedByByDescription =
            from invoice in invoices
            orderby invoice.PartDescription
            select invoice;

        Console.WriteLine("\nInvoices sorted by PartDescription:");
        foreach (var element in sortedByByDescription) {
            Console.WriteLine(element);
        }

        // order by price
        var sortedByPrice =
            from invoice in invoices
            orderby invoice.Price
            select invoice;

        Console.WriteLine("\nInvoices sorted by Price:");
        foreach (var element in sortedByPrice) {
            Console.WriteLine(element);
        }


        // description and quantity, sorted by quantity
        var sortedByQuantity =
            from invoice in invoices
            orderby invoice.Quantity
            select new { Description = invoice.PartDescription, invoice.Quantity };

        Console.WriteLine("\nDescription and quantity, sorted by quantity:");
        foreach (var element in sortedByQuantity) {
            Console.WriteLine(element);
        }

        // select values 
        var values =
            from invoice in invoices
            let total = invoice.Quantity * invoice.Price
            select new { Description = invoice.PartDescription, InvoiceTotal = total };

        Console.WriteLine("\nDescription and values:");
        foreach (var element in values) {
            Console.WriteLine(element);
        }

        // values between 200 and 500
        var between200and500 =
            from value in values
            where value.InvoiceTotal >= 200 && value.InvoiceTotal <= 500
            select value.InvoiceTotal;

        Console.WriteLine("\nValues between $200 and $500:");
        foreach (var element in between200and500) {
            Console.WriteLine(element);
        }

    }
}