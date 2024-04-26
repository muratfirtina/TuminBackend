using MediatR;

namespace Tumin.Order.Application.Features.Mediator.Commands.OrderingCommands;

public class CreateOrderingCommandRequest : IRequest
{
    public string UserId { get; set; }
    public decimal TotalPrice { get; set; }
    public DateTime OrderDate { get; set; }
}