using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using EComm.Application.Features.Queries;
using EComm.Domain.DTO;
using EComm.Domain.Entities;
using EComm.Domain.Interface;
using MediatR;

namespace EComm.Application.Features.Handlers
{
    public class GetCustomerByOrderIdHandler (ICustomerRepo customerRepo) : IRequestHandler<GetCustomerByOrderIdQueryCommand, CustomerEntity>
    {
        public async Task<CustomerEntity> Handle(GetCustomerByOrderIdQueryCommand request, CancellationToken cancellationToken)
        {
            return await customerRepo.GetCustomerByOrderIdAsync(request.orderId);
           
        }
    }
}
