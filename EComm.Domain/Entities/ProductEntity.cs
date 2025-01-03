using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EComm.Domain.Entities
{
    public class ProductEntity
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }

        public decimal Price { get; set; }

        public string Description { get; set; }

        public virtual ICollection<OrderEntity> OrderPro { get; set; }
    }
}
