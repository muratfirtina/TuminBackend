using Tumin.Order.Application.Features.CQRS.Commands.AddressCommands;
using Tumin.Order.Application.Interfaces;
using Tumin.Order.Domain.Entities;

namespace Tumin.Order.Application.Features.CQRS.Handlers.AddressHandlers;

public class CreateAddressCommandHandler
{
    private readonly IRepository<Address> _addressRepository;

    public CreateAddressCommandHandler(IRepository<Address> addressRepository)
    {
        _addressRepository = addressRepository;
    }
    public async Task Handle(CreateAddressCommand request)
    {
      await _addressRepository.CreateAsync(new Address
      {
          UserId = Guid.Parse(request.UserId),
          Street = request.Street,
          City = request.City,
          Country = request.Country,
          ZipCode = request.ZipCode,
          Detail = request.Detail
      });
      
    }
}