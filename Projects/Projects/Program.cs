using System;

public class CommissionEmployee: Object {

    private string firstName;
    private string lastName;
    private string socialSecurityNumber;
    private decimal grossSales; // gross weekly sales
    private decimal commissionRate; // commission percentage

    public CommissionEmployee(string first, string last, string ssn,
        decimal sales, decimal rate) {
        // implicit call to object constructor occurs here
        firstName = first;
        lastName = last;
        socialSecurityNumber = ssn;
        GrossSales = sales; // validate gross sales via property
        CommissionRate = rate; // validate commission rate via property
    }

    public string FirstName {
        get {
            return firstName;
        }
    }

    public string LastName {
        get {
            return lastName;
        }
    }

    public string SocialSecurityNumber {
        get {
            return socialSecurityNumber;
        }
    }

    public decimal GrossSales {
        get {
            return grossSales;
        }
        set {
            if (value >= 0) {
                grossSales = value;
            } else {
                throw new ArgumentOutOfRangeException(
                    "GrossSales", value, "GrossSales must be >= 0");
            }
        }
    }

    public decimal CommissionRate {
        get {
            return commissionRate;
        } 
        set {
            if (value > 0 && value < 1)
                commissionRate = value;
            else {
                throw new ArgumentOutOfRangeException("CommissionRate",
                    value, "CommissionRate must be > 0 and < 1");
            }
        } 
    }

    public decimal Earnings() {
        return commissionRate * grossSales;
    }

    public override string ToString() {
        return string.Format(
        "{0}: {1} {2}\n{3}: {4}\n{5}: {6:C}\n{7}: {8:F2}",
        "commission employee", FirstName, LastName,
        "social security number", SocialSecurityNumber,
        "gross sales", GrossSales, "commission rate", CommissionRate);
    }

}