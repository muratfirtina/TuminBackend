using MediatR;
using Tumin.Order.Application.Features.Mediator.Results.OrderingResults;

namespace Tumin.Order.Application.Features.Mediator.Queries.OrderingQueries;

public class GetOrderingQuery:IRequest<List<GetOrderingQueryResult>>
{
    
}