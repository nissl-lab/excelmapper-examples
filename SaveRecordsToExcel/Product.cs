using Ganss.Excel;

namespace SaveRecordsToExcel
{
    public class Product
    {
        public string Name { get; set; }
        [Column("Number")]
        public int NumberInStock { get; set; }
        public decimal Price { get; set; }
    }
}
