namespace Tumin.Order.Application.Features.CQRS.Commands.AddressCommands;

public class UpdateAddressCommand
{
    public UpdateAddressCommand(string addressId, string userId, string street, string city, string country, string zipCode, string detail)
    {
        AddressId = addressId;
        UserId = userId;
        Street = street;
        City = city;
        Country = country;
        ZipCode = zipCode;
        Detail = detail;
    }

    public string AddressId { get; set; }
    public string UserId { get; set; }
    public string Street { get; set; }
    public string City { get; set; }
    public string Country { get; set; }
    public string ZipCode { get; set; }
    public string Detail { get; set; }
}