using System;

public class AccountTest {
    public static void Main(string[] args) {

        Account account1 = new Account(50.00M);
        Account account2 = new Account(-7.53M);

        // C or c formats the string as currency
        Console.WriteLine("account1 balance: {0:C}", account1.Balance);
        Console.WriteLine("account2 balance: {0:C}", account2.Balance);

        decimal depositAmount;

        // adding amount to 1st account 
        Console.Write("Enter deposit amount for account1: ");
        depositAmount = Convert.ToDecimal(Console.ReadLine());
        Console.WriteLine("adding {0:C} to account1 balance\n", depositAmount);
        account1.Credit(depositAmount);

        Console.WriteLine("account1 balance: {0:C}", account1.Balance);
        Console.WriteLine("account2 balance: {0:C}", account2.Balance);

        // adding amount to 2nd account
        Console.Write("Enter deposit amount for account2: ");
        depositAmount = Convert.ToDecimal(Console.ReadLine());
        Console.WriteLine("adding {0:C} to account2 balance\n", depositAmount);
        account2.Credit(depositAmount);

        Console.WriteLine("account1 balance: {0:C}", account1.Balance);
        Console.WriteLine("account2 balance: {0:C}", account2.Balance);

    }
}