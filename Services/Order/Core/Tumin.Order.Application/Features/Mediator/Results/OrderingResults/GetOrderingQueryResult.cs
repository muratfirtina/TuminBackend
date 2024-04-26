namespace Tumin.Order.Application.Features.Mediator.Results.OrderingResults;

public class GetOrderingQueryResult
{
    public string OrderingId { get; set; }
    public string UserId { get; set; }
    public decimal TotalPrice { get; set; }
    public DateTime OrderDate { get; set; }
}