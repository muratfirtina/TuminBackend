using MediatR;

namespace Tumin.Order.Application.Features.Mediator.Commands.OrderingCommands;

public class DeleteOrderingCommandRequest:IRequest
{
    public string Id { get; set; }

    public DeleteOrderingCommandRequest(string id)
    {
        Id = id;
    }
}