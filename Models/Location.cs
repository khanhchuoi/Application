using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmManagement.Core.Models
{
    /// <summary>
    /// Khu vực 
    /// Chuồng, Luống
    /// </summary>
    public class Location
    {
        public int LocationId { get; set; }
        public string LocationName { get; set; }
        public ProductType ProductTypeId { get; set; }

        public string Note { get; set; }
    }
}
