namespace Tumin.Order.Application.Features.CQRS.Queries.AddressQueries;

public class GetAddressByIdQuery
{
    public GetAddressByIdQuery(string id)
    {
        Id = id;
    }

    public string Id { get; set; }
}