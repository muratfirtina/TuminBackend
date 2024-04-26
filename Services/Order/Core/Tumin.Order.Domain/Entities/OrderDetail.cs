namespace Tumin.Order.Domain.Entities;

public class OrderDetail
{
    public Guid OrderDetailId { get; set; }
    public Guid ProductId { get; set; }
    public string ProductName { get; set; }
    public decimal ProductPrice { get; set; }
    public int ProductAmount { get; set; }
    public decimal ProductTotalPrice { get; set; }
    public Guid OrderingId { get; set; }
    public Ordering Ordering { get; set; }
}