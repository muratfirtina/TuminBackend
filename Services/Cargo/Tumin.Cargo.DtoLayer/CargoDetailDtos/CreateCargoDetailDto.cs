using Tumin.Cargo.EntityLayer.Concrete;

namespace Tumin.Cargo.DtoLayer.CargoDetailDtos;

public class CreateCargoDetailDto
{
    public string SenderCustomer { get; set; }
    public string ReceiverCustomer { get; set; }
    public int CargoCompanyId { get; set; }
    public string CargoTrackingNumber { get; set; }
}