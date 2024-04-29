namespace Tumin.Cargo.EntityLayer.Concrete;

public class CargoDetail
{
    public int CargoDetailId { get; set; }
    public string SenderCustomer { get; set; }
    public string ReceiverCustomer { get; set; }
    public string CargoTrackingNumber { get; set; }
    public int CargoCompanyId { get; set; }
    public CargoCompany CargoCompany { get; set; }
    
    
    
    
}