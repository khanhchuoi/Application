using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FarmManagement.Common;

namespace FarmManagement.Core.Models
{
    /// <summary>
    /// Các loại cây trồng vật nuôi.
    /// Sản phẩm của nông trại
    /// </summary>
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }

        public FarmProduceType FarmProduceType { get; set; }
        public Decimal TemporatePrice { get; set; }

        public Unit UnitImport { get; set; }
        public Unit UnitExport {get; set;}

        public int TempHarvestTime { get; set; }

        public ProductType ProductType { get; set; }
        public int ProductTypeId { get; set; }


    }
}
