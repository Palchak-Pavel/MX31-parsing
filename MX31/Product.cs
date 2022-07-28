namespace MX31;

public class Product
{
   

    /*public Product(string productName, string code, string characteristic, string quantities, double codeOKEI, double quantity, decimal price, decimal cost, string note)
    {
        ProductName = productName;
        Code = code;
        Characteristic = characteristic;
        Quantities = quantities;
        CodeOKEI = codeOKEI;
        Quantity = quantity;
        Price = price;
        Cost = cost;
        Note = note;
    }*/
    
    public string ProductName { get; set; }
    public string Code { get; set; }
    public string Characteristic { get; set; }
    public string Quantities { get; set; }
    public double CodeOKEI { get; set; }
    public double Quantity { get; set; }
    public decimal Price { get; set; }
    public decimal Cost { get; set; }
    public string Note { get; set; }
    public string Address { get; set; }
    public DateTime Date { get; set; }
}