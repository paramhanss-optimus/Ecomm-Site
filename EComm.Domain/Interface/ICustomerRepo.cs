using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EComm.Domain.DTO;
using EComm.Domain.Entities;

namespace EComm.Domain.Interface
{
    public interface ICustomerRepo
    {
        Task<CustomerEntity> CreateCustomerAsync(CustomerEntity customer);
        Task<IEnumerable<CustomerEntity>> GetAllCustomerAsync();
        Task<CustomerEntity> GetCustomerByIdAsync(int id);
        Task<CustomerEntity> GetCustomerByOrderIdAsync(int OrderId);
    }
}
