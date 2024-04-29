namespace Tumin.Cargo.EntityLayer.Concrete;

public class CargoOperation
{
    public int CargoOperationId { get; set; }
    public string CargoTrackingNumber { get; set; }
    public string CargoOperationDescription { get; set; }
    public DateTime CargoOperationDate { get; set; }
}