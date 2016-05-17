public class Employee {

    private decimal monthlySalaryValue;

    public string FirstName { get; set; }
    public string LastName { get; set; }
    public decimal MonthLySalary {
        get {
            return monthlySalaryValue;
        }
        set {
            if (value>=0M) {
                monthlySalaryValue = value;
            }
        }
    }

    public Employee(string first,string last,decimal salary) {
        FirstName = first;
        LastName = last;
        MonthLySalary = salary;
    }

    public override string ToString() {
        return string.Format("{0,-10} {1,-10} {2,10:C}",
            FirstName, LastName, MonthLySalary);
    }

}