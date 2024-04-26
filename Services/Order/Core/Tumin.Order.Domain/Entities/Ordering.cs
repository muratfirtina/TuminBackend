namespace Tumin.Order.Domain.Entities;

public class Ordering
{
    public Guid OrderingId { get; set; }
    public Guid UserId { get; set; }
    public decimal TotalPrice { get; set; }
    public DateTime OrderDate { get; set; }
    public List<OrderDetail> OrderDetails { get; set; }
}