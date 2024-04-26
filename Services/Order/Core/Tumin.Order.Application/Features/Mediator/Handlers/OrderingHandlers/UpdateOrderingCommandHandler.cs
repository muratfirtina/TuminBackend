using MediatR;
using Tumin.Order.Application.Features.Mediator.Commands.OrderingCommands;
using Tumin.Order.Application.Interfaces;
using Tumin.Order.Domain.Entities;

namespace Tumin.Order.Application.Features.Mediator.Handlers.OrderingHandlers;

public class UpdateOrderingCommandHandler:IRequestHandler<UpdateOrderingCommandRequest>
{
    private readonly IRepository<Ordering?> _orderingRepository;

    public UpdateOrderingCommandHandler(IRepository<Ordering?> orderingRepository)
    {
        _orderingRepository = orderingRepository;
    }

    public async Task Handle(UpdateOrderingCommandRequest request, CancellationToken cancellationToken)
    {
        var ordering = await _orderingRepository.GetByIdAsync(request.OrderingId);
        ordering.OrderDate = request.OrderDate;
        ordering.TotalPrice = request.TotalPrice;
        ordering.UserId = Guid.Parse(request.UserId);
        await _orderingRepository.UpdateAsync(ordering);
    }
}