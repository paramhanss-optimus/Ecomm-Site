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
   public class GetCustomerByIdHandler (ICustomerRepo customerRepo ) : IRequestHandler<GetCustomerByIdQueryCommand, CustomerEntity>
    {
        public async Task<CustomerEntity> Handle(GetCustomerByIdQueryCommand request, CancellationToken cancellationToken)
        {
          return await customerRepo.GetCustomerByIdAsync(request.id);
        }
    }
}
