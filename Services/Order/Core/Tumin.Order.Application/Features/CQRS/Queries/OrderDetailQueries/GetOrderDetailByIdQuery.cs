namespace Tumin.Order.Application.Features.CQRS.Queries.OrderDetailQueries;

public class GetOrderDetailByIdQuery
{
    public GetOrderDetailByIdQuery(string id)
    {
        Id = id;
    }

    public string Id { get; set; }
}