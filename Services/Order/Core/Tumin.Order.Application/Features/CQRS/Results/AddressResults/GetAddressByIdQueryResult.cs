namespace Tumin.Order.Application.Features.CQRS.Results.AddressResults;

public class GetAddressByIdQueryResult
{
    public string AddressId { get; set; }
    public string UserId { get; set; }
    public string Street { get; set; }
    public string City { get; set; }
    public string Country { get; set; }
    public string? ZipCode { get; set; }
    public string Detail { get; set; }
}