using FetchDataFromExcel;
using Ganss.Excel;

var products = new ExcelMapper("products.xlsx").Fetch<Product>();
foreach (var product in products)
{
    Console.WriteLine($"Product ID:'{product.ProductID}', Name:'{product.Name}', Price:{product.Price}, PriceString: '{product.PriceString}'");
}
Console.WriteLine();
Console.WriteLine($"{products.Count()} records readed");