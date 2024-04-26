using MediatR;
using Tumin.Order.Application.Features.Mediator.Queries.OrderingQueries;
using Tumin.Order.Application.Features.Mediator.Results.OrderingResults;
using Tumin.Order.Application.Interfaces;
using Tumin.Order.Domain.Entities;

namespace Tumin.Order.Application.Features.Mediator.Handlers.OrderingHandlers;

public class GetOrderingQueryHandler:IRequestHandler<GetOrderingQuery,List<GetOrderingQueryResult>>
{
    private readonly IRepository<Ordering> _orderingRepository;

    public GetOrderingQueryHandler(IRepository<Ordering> orderingRepository)
    {
        _orderingRepository = orderingRepository;
    }

    public async Task<List<GetOrderingQueryResult>> Handle(GetOrderingQuery request, CancellationToken cancellationToken)
    {
        var orderings = await _orderingRepository.GetAllAsync();
        return orderings.Select(x => new GetOrderingQueryResult
        {
            OrderingId = x.OrderingId.ToString(),
            OrderDate = x.OrderDate,
            TotalPrice = x.TotalPrice,
            UserId = x.UserId.ToString()
        }).ToList();
    }
}