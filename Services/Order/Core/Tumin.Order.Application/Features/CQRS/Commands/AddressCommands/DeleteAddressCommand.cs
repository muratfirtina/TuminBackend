namespace Tumin.Order.Application.Features.CQRS.Commands.AddressCommands;

public class DeleteAddressCommand
{
    public DeleteAddressCommand(string id)
    {
        Id = id;
    }

    public string Id { get; set; }
}