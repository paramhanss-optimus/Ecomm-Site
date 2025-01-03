using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using EComm.Application.Features.Commands;
using EComm.Application.Features.Handlers;
using EComm.Domain.DTO;
using EComm.Domain.Entities;
using EComm.Domain.Interface;
using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace EComm.Application.Features.Handlers
{
    public class CreateCustomerHandler(ICustomerRepo customerRepo): IRequestHandler<CreateCustomerCommand, CustomerEntity>
    {
        public async Task<CustomerEntity> Handle(CreateCustomerCommand request, CancellationToken cancellationToken)
        {
            return await customerRepo.CreateCustomerAsync(request.Emp);
             

        }
    }
}





