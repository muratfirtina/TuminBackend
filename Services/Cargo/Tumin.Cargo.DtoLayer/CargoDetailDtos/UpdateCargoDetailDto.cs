namespace Tumin.Cargo.DtoLayer.CargoDetailDtos;

public class UpdateCargoDetailDto
{
    public int CargoDetailId { get; set; }
    public string SenderCustomer { get; set; }
    public string ReceiverCustomer { get; set; }
    public string CargoTrackingNumber { get; set; }
    public int CargoCompanyId { get; set; }
}