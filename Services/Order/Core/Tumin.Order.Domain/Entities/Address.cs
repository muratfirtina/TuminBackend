namespace Tumin.Order.Domain.Entities;

public class Address
{
    public Guid AddressId { get; set; }
    public Guid UserId { get; set; }
    public string Street { get; set; }
    public string City { get; set; }
    public string Country { get; set; }
    public string? ZipCode { get; set; }
    public string Detail { get; set; }
    
}