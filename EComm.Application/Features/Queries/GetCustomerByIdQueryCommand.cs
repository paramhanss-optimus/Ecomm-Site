using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EComm.Domain.DTO;
using EComm.Domain.Entities;
using MediatR;

namespace EComm.Application.Features.Queries
{

    public record GetCustomerByIdQueryCommand(int id) : IRequest<CustomerEntity>;

}
