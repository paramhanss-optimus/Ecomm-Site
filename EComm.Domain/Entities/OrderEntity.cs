using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;

namespace EComm.Domain.Entities
{
    public  class OrderEntity
    {

        public int OrderId { get; set; }

        public int? CustId {  get; set; }

        public virtual CustomerEntity Customer { get; set; }
        
        public virtual  ICollection<ProductEntity> Products { get; set; }
    }
}
