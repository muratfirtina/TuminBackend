using MediatR;
using Tumin.Order.Application.Features.Mediator.Queries.OrderingQueries;
using Tumin.Order.Application.Features.Mediator.Results.OrderingResults;
using Tumin.Order.Application.Interfaces;
using Tumin.Order.Domain.Entities;

namespace Tumin.Order.Application.Features.Mediator.Handlers.OrderingHandlers;

public class GetOrderingByIdQueryHandler:IRequestHandler<GetOrderingByIdQuery, GetOrderingQueryByIdQueryResult>
{
    private readonly IRepository<Ordering> _orderingRepository;

    public GetOrderingByIdQueryHandler(IRepository<Ordering> orderingRepository)
    {
        _orderingRepository = orderingRepository;
    }

    public async Task<GetOrderingQueryByIdQueryResult> Handle(GetOrderingByIdQuery request, CancellationToken cancellationToken)
    {
        var ordering = await _orderingRepository.GetByIdAsync(request.Id);
        return new GetOrderingQueryByIdQueryResult
        {
            OrderingId = ordering.OrderingId.ToString(),
            OrderDate = ordering.OrderDate,
            TotalPrice = ordering.TotalPrice,
            UserId = ordering.UserId.ToString()
        };
    }
}
