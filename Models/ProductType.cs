using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmManagement.Core.Models
{
    /// <summary>
    /// Loại sản phẩm
    /// </summary>
  public  class ProductType
    {

        public int ProductTypeId { get; set; }

        public string ProductTypeName { get; set; }

        public int ProductGroupId { get; set; }
        public ProductGroup ProductGroup { get; set; }
        public string Note { get; set; }

        public ICollection<Product> Products { get; set; }
        public ICollection<Medicine> Medicines { get; set; }

        public ICollection<Food>  Foods { get; set; }

        public ICollection<Location> Locations { get; set; }

        
    }
}
