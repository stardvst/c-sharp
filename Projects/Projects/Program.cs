public class Account {

    private decimal balance;

    public Account(decimal initialBalance) {
        Balance = initialBalance;    
    }

    public void Credit(decimal amount) {
        Balance += amount;
    }

    public decimal Balance {
        get {
            return balance;
        }
        set {
            if (value >= 0) {
                balance = value;
            }
        }
    }

}