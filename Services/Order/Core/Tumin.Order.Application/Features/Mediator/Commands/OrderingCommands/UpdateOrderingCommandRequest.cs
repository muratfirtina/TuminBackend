using MediatR;

namespace Tumin.Order.Application.Features.Mediator.Commands.OrderingCommands;

public class UpdateOrderingCommandRequest:IRequest
{
    public string OrderingId { get; set; }
    public string UserId { get; set; }
    public decimal TotalPrice { get; set; }
    public DateTime OrderDate { get; set; }
}