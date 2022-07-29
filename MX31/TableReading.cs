using OfficeOpenXml;

namespace MX31;
public class TableReading
{
    public static void WriteExcel(string FileName)
    {
        var fi = new FileInfo(FileName);
        
        using (var package = new ExcelPackage(fi))
        {
            using (ExcelWorksheet worksheet  = package.Workbook.Worksheets.First())
            {
                var document = new Document();
                document.Address = ReadAddress(worksheet);
                document.Date = ReadDate(worksheet);
                document.ProductsList = ReadProducts(worksheet);
                Console.WriteLine(document.ToString());
            }
            Console.ReadLine();
        }
    }

    private static DateTime ReadDate(ExcelWorksheet worksheet)
    {
        DateTime date;
        if (DateTime.TryParse(worksheet.Cells["H13"].Text, out date)) {}
        return date;
    }

    private static string ReadAddress(ExcelWorksheet worksheet)
    {
        return worksheet.Cells["B8"].Text;
    }

    private static List<Product> ReadProducts(ExcelWorksheet worksheet)
    {
        var productsList = new List<Product>();
        int startRow = 24;
        int startColumn = 2;
                
        for (int i = startRow; i < worksheet.Dimension.End.Row; i++)
        {
            string text = worksheet.Cells[i, startColumn].Text;
            if(string.IsNullOrEmpty(text)) break;
                    
            var product = new Product();
            product.ProductName = worksheet.Cells[i, startColumn].Text;
            product.Code = worksheet.Cells[i, startColumn + 1].Text;
            product.Characteristic = worksheet.Cells[i, startColumn + 2].Text;
            product.Quantities = worksheet.Cells[i, startColumn + 3].Text;
            double okeiCode;
            if(Double.TryParse(worksheet.Cells[i, startColumn + 4].Text, out okeiCode))
                product.CodeOKEI = okeiCode;
            double quantity;
            if(Double.TryParse(worksheet.Cells[i, startColumn + 5].Text, out quantity))
                product.Quantity = quantity;
            decimal price;
            if(Decimal.TryParse(worksheet.Cells[i, startColumn + 6].Text, out price))
                product.Price = price;
            decimal cost;
            if(Decimal.TryParse(worksheet.Cells[i, startColumn + 7].Text, out cost))
                product.Cost = cost;
            product.Note = worksheet.Cells[i, startColumn + 8].Text;
            productsList.Add(product);
        }
        return productsList;
    }
}