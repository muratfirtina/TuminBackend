namespace Tumin.Order.Application.Features.CQRS.Results.OrderDetailResults;

public class GetOrderDetailByIdQueryResult
{
    public Guid OrderDetailId { get; set; }
    public Guid ProductId { get; set; }
    public string ProductName { get; set; }
    public decimal ProductPrice { get; set; }
    public int ProductAmount { get; set; }
    public decimal ProductTotalPrice { get; set; }
    public Guid OrderingId { get; set; }
}