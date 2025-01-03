
using EComm.Domain.Entities;
using EComm.Domain.Interface;
using Microsoft.EntityFrameworkCore;

namespace EComm.Persistance.Repositories.Non_Genric_Repo
{
    public class CustomerRepo : ICustomerRepo
    {

        private readonly EcommerceDBContext _context;

        public CustomerRepo(EcommerceDBContext context)
        {
            _context = context;
        }

        public async Task<CustomerEntity> CreateCustomerAsync(CustomerEntity customer)
        {
            _context.Customers.Add(customer);
            await _context.SaveChangesAsync();
            return customer;
        }
        public async Task<IEnumerable<CustomerEntity>> GetAllCustomerAsync()
        {
            return await _context.Customers.ToListAsync();
        }
        public async Task<CustomerEntity> GetCustomerByIdAsync(int id)
        {
            return await _context.Customers.FindAsync(id);
        }

        public async Task<CustomerEntity> GetCustomerByOrderIdAsync(int orderId)
        {
            return await _context.Orders
                .Where(o => o.OrderId == orderId)
                .Select(o => o.Customer)
                .FirstOrDefaultAsync();
        }
    }
}
