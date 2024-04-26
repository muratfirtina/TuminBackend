namespace Tumin.Order.Application.Features.CQRS.Commands.AddressCommands;

public class CreateAddressCommand
{
    public CreateAddressCommand(string userId, string street, string city, string country, string? zipCode, string detail)
    {
        UserId = userId;
        Street = street;
        City = city;
        Country = country;
        ZipCode = zipCode;
        Detail = detail;
    }

    public string UserId { get; set; }
    public string Street { get; set; }
    public string City { get; set; }
    public string Country { get; set; }
    public string? ZipCode { get; set; }
    public string Detail { get; set; }
}