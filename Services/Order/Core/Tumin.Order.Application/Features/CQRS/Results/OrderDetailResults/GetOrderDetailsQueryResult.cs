namespace Tumin.Order.Application.Features.CQRS.Results.OrderDetailResults;

public class GetOrderDetailsQueryResult
{
    public string OrderDetailId { get; set; }
    public string ProductId { get; set; }
    public string ProductName { get; set; }
    public decimal ProductPrice { get; set; }
    public int ProductAmount { get; set; }
    public decimal ProductTotalPrice { get; set; }
    public string OrderingId { get; set; }
}