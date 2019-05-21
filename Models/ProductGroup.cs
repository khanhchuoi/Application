using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmManagement.Core.Models
{
    /// <summary>
    /// Nhóm sản phẩm
    /// </summary>
   public class ProductGroup
    {
        public int ProductGroupId { get; set; }

        public string ProductGroupName { get; set; }
        public string Note { get; set; }

        public ICollection<ProductType> ProductTypes { get; set; }
    }
}
