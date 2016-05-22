using System;

public abstract class Employee : IPayable {

    public string FirstName { get; private set; }
    public string LastName { get; private set; }
    public string SocialSecurityNumber { get; private set; }
    private decimal grossSales; // gross weekly sales
    private decimal commissionRate; // commission percentage

    public Employee(string first, string last, string ssn) {
        FirstName = first;
        LastName = last;
        SocialSecurityNumber = ssn;
    }

    public override string ToString() {
        return string.Format("{0} {1}\nsocial security number: {2}",
            FirstName, LastName, SocialSecurityNumber);
    }

    // Note: We do not implement IPayable method GetPaymentAmount here, so
    // this class must be declared abstract to avoid a compilation error.
    public abstract decimal GetPaymentAmount();

}


public class SalariedEmployee : Employee {

    private decimal weeklySalary;

    public SalariedEmployee(string first, string last,
        string ssn, decimal salary)
        : base(first, last, ssn) {
        WeeklySalary = salary;
    }

    public decimal WeeklySalary {
        get {
            return weeklySalary;
        }
        set {
            if (value >= 0)
                weeklySalary = value;
            else
                throw new ArgumentOutOfRangeException("WeeklySalary",
                value, "WeeklySalary must be >= 0");
        }
    }

    public override string ToString() {
        return string.Format("salaried employee: {0}\n{1}: {2:C}",
        base.ToString(), "weekly salary", WeeklySalary);
    }

    public override decimal GetPaymentAmount() {
        return WeeklySalary;
    }

}