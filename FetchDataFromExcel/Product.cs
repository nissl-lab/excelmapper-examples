using Ganss.Excel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FetchDataFromExcel
{
    public class Product
    {
        [Column("Product ID")]
        public string ProductID { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        [Column("Price", MappingDirections.ExcelToObject)]
        public string PriceString { get; set; }
    }
}
