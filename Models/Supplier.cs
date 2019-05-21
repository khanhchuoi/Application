using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmManagement.Core.Models
{
    /// <summary>
    /// Nhà Cung cấp
    /// </summary>
  public  class Supplier
    {
        public int SupplierId { get; set; }
        public string SupplierName { get; set; }
        public string  Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }


        public ICollection<ProductBatch> Products { get; set; }
        public ICollection<MedicineBatch> Medicines { get; set; }

        public ICollection<FoodBatch> Foods { get; set; }


    }
}
