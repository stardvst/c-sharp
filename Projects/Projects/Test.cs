using System;

public class Program {
    public static void Main(string[] args) {

        Account account = new Account(50.00M);

        Console.Write("Enter debit amount: ");
        decimal debit = Convert.ToDecimal(Console.ReadLine());
        account.Debit(debit);

    }
}