using System;

public interface IPayment
{
    void ProcessPayment(decimal amount);
}


public class CreditCardPayment : IPayment
{
    public string CardNo { get; set; }
    public string CardHolder { get; set; }

    public CreditCardPayment(string cardNo, string cardHolder)
    {
        CardNo = cardNo;
        CardHolder = cardHolder;
    }

    public void ProcessPayment(decimal amount)
    {
        Console.WriteLine($"Processing Credit Card Payment of ₹{amount}...");
        Console.WriteLine($"Card Holder: {CardHolder}");
        Console.WriteLine($"Card Number: **** **** **** {CardNo.Substring(CardNo.Length - 4)}");
        Console.WriteLine("✅ Credit Card Payment Successful!\n");
    }
}


public class UPIPayment : IPayment
{
    public string UpiId { get; set; }
    public string BankName { get; set; }

    public UPIPayment(string upiId, string bankName)
    {
        UpiId = upiId;
        BankName = bankName;
    }

    public void ProcessPayment(decimal amount)
    {
        Console.WriteLine($"Processing UPI Payment of ₹{amount}...");
        Console.WriteLine($"UPI ID: {UpiId}");
        Console.WriteLine($"Bank: {BankName}");
        Console.WriteLine("✅ UPI Payment Successful!\n");
    }
}


public class Table
{
    public string Name { get; set; }
    public decimal Amount { get; set; }

    public Table(string name, decimal amount)
    {
        Name = name;
        Amount = amount;
    }

    public void MakePayment(IPayment paymentMethod)
    {
        Console.WriteLine($"Initiating payment for {Name} (Amount: ₹{Amount})");
        paymentMethod.ProcessPayment(Amount);
    }
}

public class Program
{
    public static void Main()
    {
       
        Table table1 = new Table("Table 5 - Dinner Order", 1500m);

        
        IPayment creditPayment = new CreditCardPayment("1234567812345678", "Alice Johnson");
        table1.MakePayment(creditPayment);

        
        IPayment upiPayment = new UPIPayment("alice@upi", "HDFC Bank");
        table1.MakePayment(upiPayment);
    }
}
