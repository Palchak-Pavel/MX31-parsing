namespace MX31;

public class Document
{
    public string Address { get; set; }
    public DateTime Date { get; set; }
    public List<Product> ProductsList { get; set; }

    public override string ToString()
    {
        string document = $"DocumentAddress: {Address}; DocumentDate: {Date.ToShortDateString()};";
        foreach (var product in ProductsList)
        {
            document += $"ProductCode: {product.Code}; ";
        }
        return document;
    }
}