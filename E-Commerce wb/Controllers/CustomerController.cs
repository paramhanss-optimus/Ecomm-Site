using AutoMapper;
using EComm.Application.Features.Commands;
using EComm.Application.Features.Queries;
using EComm.Domain.DTO;
using EComm.Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace E_Commerce_wb.Controllers
{

    [Route("api/[controller]")]
    [ApiController]


    public class CustomerController : ControllerBase
    {
        private readonly ISender _sender;
        private readonly IMapper _mapper;

        public CustomerController(ISender sender, IMapper mapper)
        {
            _sender = sender;
            _mapper = mapper;
        }

        [HttpPost("customer/create")]
        public async Task<IActionResult> CreateCustomer([FromBody] CustomerDTO customerDto, CancellationToken ct)
        {
            var customerEntity = _mapper.Map<CustomerEntity>(customerDto);
            var result = await _sender.Send(new CreateCustomerCommand(customerEntity), ct);
            var responseDto = _mapper.Map<CustomerDTO>(result);
            return Ok(responseDto);
        }

        [HttpGet("customer")]
        public async Task<IActionResult> GetAllCustomers(CancellationToken ct)
        {
            var result = await _sender.Send(new GetAllCustomersQueryCommand(), ct);
            var responseDto = _mapper.Map<IEnumerable<CustomerDTO>>(result);
            return Ok(responseDto);
        }

        [HttpGet("customer/{id}")]
        public async Task<IActionResult> GetCustomerById(int id, CancellationToken ct)
        {
            var result = await _sender.Send(new GetCustomerByIdQueryCommand(id), ct);
            var responseDto = _mapper.Map<CustomerDTO>(result);
            return Ok(responseDto);
        }

        [HttpGet("customer/order/{orderId}")]
        public async Task<IActionResult> GetCustomerByOrderId(int orderId, CancellationToken ct)
        {
            var result = await _sender.Send(new GetCustomerByOrderIdQueryCommand(orderId), ct);
            var responseDto = _mapper.Map<CustomerDTO>(result);
            return Ok(responseDto);
        }
    }
}
