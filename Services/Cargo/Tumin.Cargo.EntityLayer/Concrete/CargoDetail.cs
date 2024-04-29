namespace Tumin.Cargo.EntityLayer.Concrete;

public class CargoDetail
{
    public Guid CargoDetailId { get; set; }
    public string SenderCustomer { get; set; }
    public string ReceiverCustomer { get; set; }
    public CargoCustomer CargoCustomer { get; set; }
    public int CargoCompanyId { get; set; }
    public CargoCompany CargoCompany { get; set; }
    public string CargoTrackingNumber { get; set; }
    
    
    
    
}