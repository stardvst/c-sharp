using System;

public class BasePlusCommissionEmployee: CommissionEmployee {

    private decimal baseSalary;

    public BasePlusCommissionEmployee(string first, string last,
        string ssn, decimal sales, decimal rate, decimal salary)
        : base(first, last, ssn, sales, rate) {
        BaseSalary = salary;
    }

    public decimal BaseSalary {
        get {
            return baseSalary;
        } 
        set {
            if (value >= 0)
                baseSalary = value;
            else
                throw new ArgumentOutOfRangeException("BaseSalary",
                value, "BaseSalary must be >= 0");
        }
    }

    public override decimal Earnings() {
        return baseSalary + (commissionRate * grossSales);
    }

    public override string ToString() {
        return string.Format(
            "{0}: {1} {2}\n{3}: {4}\n{5}: {6:C}\n{7}: {8:F2}\n{9}: {10:C}",
            "base-salaried commission employee", firstName, lastName,
            "social security number", socialSecurityNumber,
            "gross sales", grossSales, "commission rate", commissionRate,
            "base salary", baseSalary);
    }

}