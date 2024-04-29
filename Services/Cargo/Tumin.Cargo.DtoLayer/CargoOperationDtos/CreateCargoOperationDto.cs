namespace Tumin.Cargo.DtoLayer.CargoOperationDtos;

public class CreateCargoOperationDto
{
    public string CargoTrackingNumber { get; set; }
    public string CargoOperationDescription { get; set; }
    public DateTime CargoOperationDate { get; set; }
}