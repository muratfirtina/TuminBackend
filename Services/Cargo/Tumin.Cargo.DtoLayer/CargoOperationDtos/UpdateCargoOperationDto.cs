namespace Tumin.Cargo.DtoLayer.CargoOperationDtos;

public class UpdateCargoOperationDto
{
    public int CargoOperationId { get; set; }
    public string CargoTrackingNumber { get; set; }
    public string CargoOperationDescription { get; set; }
    public DateTime CargoOperationDate { get; set; }
}