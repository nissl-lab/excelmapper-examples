using Ganss.Excel;

var products = new ExcelMapper("products.xlsx").Fetch();
Console.WriteLine(products.Count());
foreach (var product in products)
{
    Console.WriteLine($"Product ID:{product.ProductID}, Name:{product.Name}, Price:{product.Price}");
}
