using Microsoft.Extensions.Configuration;

namespace MX31;

class Program
{
    static void Main(string[] args)
    {
    
                //....
		
                IConfiguration config = new ConfigurationBuilder()
                    .AddJsonFile("appSettings.json")
                    .Build();
        
		
                //.....
                
        
         TableReading.WriteExcel(@"C:\файлы\MX31 693971107.xlsx");
    }
}
