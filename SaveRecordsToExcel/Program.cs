using Ganss.Excel;
using SaveRecordsToExcel;

var products = new List<Product>
{
    new Product { Name = "Nudossi", NumberInStock = 60, Price = 1.99m },
    new Product { Name = "Halloren", NumberInStock = 33, Price = 2.99m },
    new Product { Name = "Filinchen", NumberInStock = 100, Price = 0.99m },
};

new ExcelMapper().Save("products.xlsx", products, "Products");

Console.WriteLine("Excel generated");