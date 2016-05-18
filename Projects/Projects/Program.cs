public class Invoice {

    private int quantity;
    private decimal price;

    public Invoice(string number, string description, int q, decimal p) {
        PartNumber = number;
        PartDescription = description;
        Quantity = q;
        Price = p;
    }

    public string PartNumber { get; set; }
    public string PartDescription { get; set; }
    public int Quantity {
        get {
            return quantity;
        }
        set {
            if (value > 0) {
                quantity = value;
            } else {
                quantity = 0;
            }
        }
    }
    public decimal Price {
        get {
            return price;
        }
        set {
            if (value > 0.0M) {
                price = value;
            } else {
                price = 0.0M;
            }
        }
    }

    public decimal GetInvoiceAmount() {
        return quantity * price;
    }

    public override string ToString() {
        return string.Format("{0, 10} {1, 20} {2, 10} {3, 10:C}", 
            PartNumber, PartDescription, Quantity, Price);
    }

}
