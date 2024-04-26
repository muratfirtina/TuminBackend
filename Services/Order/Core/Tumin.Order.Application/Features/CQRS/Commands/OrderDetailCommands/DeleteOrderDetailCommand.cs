namespace Tumin.Order.Application.Features.CQRS.Commands.OrderDetailCommands;

public class DeleteOrderDetailCommand
{
    public DeleteOrderDetailCommand(string id)
    {
        Id = id;
    }

    public string Id { get; set; }
}