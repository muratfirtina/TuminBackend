using MediatR;
using Tumin.Order.Application.Features.Mediator.Commands.OrderingCommands;
using Tumin.Order.Application.Interfaces;
using Tumin.Order.Domain.Entities;

namespace Tumin.Order.Application.Features.Mediator.Handlers.OrderingHandlers;

public class CreateOrderingCommandHandler:IRequestHandler<CreateOrderingCommandRequest>
{
    private readonly IRepository<Ordering> _orderingRepository;

    public CreateOrderingCommandHandler(IRepository<Ordering> orderingRepository)
    {
        _orderingRepository = orderingRepository;
    }

    public async Task Handle(CreateOrderingCommandRequest request, CancellationToken cancellationToken)
    {
        var ordering = new Ordering
        {
            OrderDate = request.OrderDate,
            TotalPrice = request.TotalPrice,
            UserId = Guid.Parse(request.UserId)
        };
        await _orderingRepository.CreateAsync(ordering);
    }
}