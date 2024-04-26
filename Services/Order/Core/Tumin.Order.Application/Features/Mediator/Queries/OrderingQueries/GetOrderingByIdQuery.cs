using MediatR;
using Tumin.Order.Application.Features.Mediator.Results.OrderingResults;

namespace Tumin.Order.Application.Features.Mediator.Queries.OrderingQueries;

public class GetOrderingByIdQuery:IRequest<GetOrderingQueryByIdQueryResult>
{
    public GetOrderingByIdQuery(string ıd)
    {
        Id = ıd;
    }

    public string Id { get; set; }
}