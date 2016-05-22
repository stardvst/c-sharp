using System;

public class Invoice : IPayable {

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
                throw new ArgumentOutOfRangeException("Quantity",
                    value, "Quantity must be >= 0");
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
                throw new ArgumentOutOfRangeException("PricePerItem",
                    value, "PricePerItem must be >= 0");
            }
        }
    }

    public override string ToString() {
        return string.Format(
        "{0}: \n{1}: {2} ({3}) \n{4}: {5} \n{6}: {7:C}",
        "invoice", "part number", PartNumber, PartDescription,
        "quantity", Quantity, "price per item", Price);
    }

    public decimal GetPaymentAmount() {
        return Quantity * Price; // calculate total cost
    }

}



