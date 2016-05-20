public class Employee {

    public string FirstName { get; private set; }
    public string LastName { get; private set; }
    public Date BirthDate { get; private set; }
    public Date HireDate { get; private set; }

    public Employee(string first, string last, Date birth, Date hire) {
        FirstName = first;
        LastName = last;
        BirthDate = birth;
        HireDate = hire;
    }

    public override string ToString() {
        return string.Format("{0}, {1} Hired: {2} Birthday: {3}",
            FirstName, LastName, HireDate, BirthDate);
    }

}