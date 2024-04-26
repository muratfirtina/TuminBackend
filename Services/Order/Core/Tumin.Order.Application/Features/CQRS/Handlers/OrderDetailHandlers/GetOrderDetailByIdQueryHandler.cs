using Tumin.Order.Application.Features.CQRS.Queries.OrderDetailQueries;
using Tumin.Order.Application.Features.CQRS.Results.OrderDetailResults;
using Tumin.Order.Application.Interfaces;
using Tumin.Order.Domain.Entities;

namespace Tumin.Order.Application.Features.CQRS.Handlers.OrderDetailHandlers;

public class GetOrderDetailByIdQueryHandler
{
    private readonly IRepository<OrderDetail> _orderDetailRepository;

    public GetOrderDetailByIdQueryHandler(IRepository<OrderDetail> orderDetailRepository)
    {
        _orderDetailRepository = orderDetailRepository;
    }


    public async Task<GetOrderDetailByIdQueryResult> Handle(GetOrderDetailByIdQuery request)
    {
        var orderDetail = await _orderDetailRepository.GetByIdAsync(request.Id);
        return new GetOrderDetailByIdQueryResult
        {
            OrderDetailId = orderDetail.OrderDetailId,
            ProductId = orderDetail.ProductId,
            ProductName = orderDetail.ProductName,
            ProductPrice = orderDetail.ProductPrice,
            ProductAmount = orderDetail.ProductAmount,
            ProductTotalPrice = orderDetail.ProductTotalPrice,
            OrderingId = orderDetail.OrderingId
        };
    }
}