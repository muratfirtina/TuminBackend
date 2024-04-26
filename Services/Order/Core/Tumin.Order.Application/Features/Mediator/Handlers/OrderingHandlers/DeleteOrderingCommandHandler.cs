using MediatR;
using Tumin.Order.Application.Features.Mediator.Commands.OrderingCommands;
using Tumin.Order.Application.Interfaces;
using Tumin.Order.Domain.Entities;

namespace Tumin.Order.Application.Features.Mediator.Handlers.OrderingHandlers;

public class DeleteOrderingCommandHandler:IRequestHandler<DeleteOrderingCommandRequest>
{
    private readonly IRepository<Ordering?> _orderingRepository;

    public DeleteOrderingCommandHandler(IRepository<Ordering?> orderingRepository)
    {
        _orderingRepository = orderingRepository;
    }

    public async Task Handle(DeleteOrderingCommandRequest request, CancellationToken cancellationToken)
    {
        var ordering = await _orderingRepository.GetByIdAsync(request.Id);
        await _orderingRepository.DeleteAsync(ordering);
    }
}