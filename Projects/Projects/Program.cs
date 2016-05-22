using System;

public abstract class Employee: Object {

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

    public abstract decimal Earnings();

}