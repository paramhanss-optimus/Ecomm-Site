using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EComm.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace EComm.Persistance.Configurations
{
    public class OrderConfig : IEntityTypeConfiguration<OrderEntity>
    {
        public void Configure(EntityTypeBuilder<OrderEntity> builder)
        {
            builder.HasKey(o => o.OrderId);

           builder.HasOne(o=>o.Customer)
                .WithMany(c=> c.Orders)
                .HasForeignKey(o=>o.CustId)
                .OnDelete(DeleteBehavior.Cascade);
            
        }
    
    }
}
