using Tumin.Order.Application.Features.CQRS.Queries.AddressQueries;
using Tumin.Order.Application.Features.CQRS.Results.AddressResults;
using Tumin.Order.Application.Interfaces;
using Tumin.Order.Domain.Entities;

namespace Tumin.Order.Application.Features.CQRS.Handlers.AddressHandlers;

public class GetAddressByIdQueryHandler
{
    private readonly IRepository<Address> _addressRepository;

    public GetAddressByIdQueryHandler(IRepository<Address> addressRepository)
    {
        _addressRepository = addressRepository;
    }
    public async Task<GetAddressByIdQueryResult> Handle(GetAddressByIdQuery request)
    {
        var address = await _addressRepository.GetByIdAsync(request.Id);
        return new GetAddressByIdQueryResult
        {
            AddressId = address.AddressId.ToString(),
            UserId = address.UserId.ToString(),
            Street = address.Street,
            City = address.City,
            Country = address.Country,
            ZipCode = address.ZipCode,
            Detail = address.Detail
        };
    }
}