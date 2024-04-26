using Tumin.Order.Application.Features.CQRS.Commands.AddressCommands;
using Tumin.Order.Application.Interfaces;
using Tumin.Order.Domain.Entities;

namespace Tumin.Order.Application.Features.CQRS.Handlers.AddressHandlers;

public class UpdateAddressCommandHandler
{
    private readonly IRepository<Address> _addressRepository;

    public UpdateAddressCommandHandler(IRepository<Address> addressRepository)
    {
        _addressRepository = addressRepository;
    }
    
    public async Task Handle(UpdateAddressCommand request)
    {
        var address = await _addressRepository.GetByIdAsync(request.AddressId);
        if (address != null)
        {
            address.UserId = Guid.Parse(request.UserId);
            address.Street = request.Street;
            address.City = request.City;
            address.Country = request.Country;
            address.ZipCode = request.ZipCode;
            address.Detail = request.Detail;
            await _addressRepository.UpdateAsync(address);
        }
    }
}