using Tumin.Order.Application.Features.CQRS.Commands.AddressCommands;
using Tumin.Order.Application.Interfaces;
using Tumin.Order.Domain.Entities;

namespace Tumin.Order.Application.Features.CQRS.Handlers.AddressHandlers;

public class DeleteAddressCommandHandler
{
    private readonly IRepository<Address?> _addressRepository;

    public DeleteAddressCommandHandler(IRepository<Address?> addressRepository)
    {
        _addressRepository = addressRepository;
    }
    
    public async Task Handle(DeleteAddressCommand request)
    {
        var address = await _addressRepository.GetByIdAsync(request.Id);
        await _addressRepository.DeleteAsync(address);
        
    }
}