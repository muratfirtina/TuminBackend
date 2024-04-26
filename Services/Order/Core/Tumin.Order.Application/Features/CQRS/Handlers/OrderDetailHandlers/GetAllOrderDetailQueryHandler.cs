using Tumin.Order.Application.Features.CQRS.Results.OrderDetailResults;
using Tumin.Order.Application.Interfaces;
using Tumin.Order.Domain.Entities;

namespace Tumin.Order.Application.Features.CQRS.Handlers.OrderDetailHandlers;

public class GetAllOrderDetailQueryHandler
{
    private readonly IRepository<OrderDetail> _orderDetailRepository;

    public GetAllOrderDetailQueryHandler(IRepository<OrderDetail> orderDetailRepository)
    {
        _orderDetailRepository = orderDetailRepository;
    }
    
    public async Task<List<GetOrderDetailsQueryResult>> Handle()
    {
        var orderDetails = await _orderDetailRepository.GetAllAsync();
        return orderDetails.Select(orderDetail => new GetOrderDetailsQueryResult
        {
            OrderDetailId = orderDetail.OrderDetailId.ToString(),
            ProductId = orderDetail.ProductId.ToString(),
            ProductName = orderDetail.ProductName,
            ProductPrice = orderDetail.ProductPrice,
            ProductAmount = orderDetail.ProductAmount,
            ProductTotalPrice = orderDetail.ProductTotalPrice,
            OrderingId = orderDetail.OrderingId.ToString()
        }).ToList();
        
    }
}