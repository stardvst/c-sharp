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
        return baseSalary + (CommissionRate * GrossSales);
    }

    public override string ToString() {
        return string.Format("base-salaried {0}\nbase salary: {1:C}",
            base.ToString(), BaseSalary);
    }

}