using Tumin.Order.Application.Features.CQRS.Results.AddressResults;
using Tumin.Order.Application.Interfaces;
using Tumin.Order.Domain.Entities;

namespace Tumin.Order.Application.Features.CQRS.Handlers.AddressHandlers;

public class GetAllAddressQueryHandler
{
    private readonly IRepository<Address> _addressRepository;

    public GetAllAddressQueryHandler(IRepository<Address> addressRepository)
    {
        _addressRepository = addressRepository;
    }
    public async Task<List<GetAddressQueryResult>> Handle()
    {
        var addresses = await _addressRepository.GetAllAsync();
        return addresses.Select(address => new GetAddressQueryResult
        {
            AddressId = address.AddressId.ToString(),
            UserId = address.UserId.ToString(),
            Street = address.Street,
            City = address.City,
            Country = address.Country,
            ZipCode = address.ZipCode,
            Detail = address.Detail
        }).ToList();
    }
}