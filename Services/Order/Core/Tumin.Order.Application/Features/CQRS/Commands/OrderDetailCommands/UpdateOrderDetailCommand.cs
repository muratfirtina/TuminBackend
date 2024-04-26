namespace Tumin.Order.Application.Features.CQRS.Commands.OrderDetailCommands;

public class UpdateOrderDetailCommand
{
    public UpdateOrderDetailCommand(string orderDetailId, string productId, string productName, decimal productPrice, int productAmount, decimal productTotalPrice, string orderingId)
    {
        OrderDetailId = orderDetailId;
        ProductId = productId;
        ProductName = productName;
        ProductPrice = productPrice;
        ProductAmount = productAmount;
        ProductTotalPrice = productTotalPrice;
        OrderingId = orderingId;
    }

    public string OrderDetailId { get; set; }
    public string ProductId { get; set; }
    public string ProductName { get; set; }
    public decimal ProductPrice { get; set; }
    public int ProductAmount { get; set; }
    public decimal ProductTotalPrice { get; set; }
    public string OrderingId { get; set; }
}