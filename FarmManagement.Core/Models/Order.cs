using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmManagement.Core.Models
{
    /// <summary>
    /// Hóa đơn
    /// Tách ra để thể hiện quan hệ n - n giữa khách hàng với mùa vụ
    /// Một lứa thì sẽ được mua bỏi nhiều người. 
    /// Nhiều người thì có thể cùng mua 1 lứa sản phẩm
    /// </summary>
   public class Order
    {
        public int FarmingSeasonId { get; set; }
        public int CustomerId { get; set; }

        public int Quantity { get; set; }
        public int Price { get; set; }

        public int Amout { get; set; }
    }
}
