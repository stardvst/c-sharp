using System;

public class Program {
    public static void Main(string[] args) {

        IPayable[] payableObjects = new IPayable[4];

        payableObjects[0] = new Invoice("01234", "seat", 2, 375.00M);
        payableObjects[1] = new Invoice("56789", "tire", 4, 79.95M);
        payableObjects[2] = new SalariedEmployee("John", "Smith", "111-11-1111", 800.00M);
        payableObjects[3] = new SalariedEmployee("Lisa", "Barnes", "888-88-8888", 1200.00M);

        Console.WriteLine("Invoices and Employees processed polymorphically:\n");

        foreach (var current in payableObjects) {
            Console.WriteLine("{0}\npayment due: {1:C}\n",
                current, current.GetPaymentAmount());
        }

    }
}