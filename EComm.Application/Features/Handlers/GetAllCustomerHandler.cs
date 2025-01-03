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
    public class GetAllCustomerHandler (ICustomerRepo customerRepo) : IRequestHandler<GetAllCustomersQueryCommand, IEnumerable<CustomerEntity>>
    {
        public async Task<IEnumerable<CustomerEntity>> Handle(GetAllCustomersQueryCommand request, CancellationToken cancellationToken)
        {
            return await customerRepo.GetAllCustomerAsync();
            

        }
    }
}
