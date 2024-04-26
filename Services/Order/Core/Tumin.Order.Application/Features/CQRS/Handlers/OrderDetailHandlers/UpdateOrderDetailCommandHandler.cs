using Tumin.Order.Application.Features.CQRS.Commands.OrderDetailCommands;
using Tumin.Order.Application.Interfaces;
using Tumin.Order.Domain.Entities;

namespace Tumin.Order.Application.Features.CQRS.Handlers.OrderDetailHandlers;

public class UpdateOrderDetailCommandHandler
{
    private readonly IRepository<OrderDetail?> _orderDetailRepository;

    public UpdateOrderDetailCommandHandler(IRepository<OrderDetail?> orderDetailRepository)
    {
        _orderDetailRepository = orderDetailRepository;
    }
    
    public async Task Handle(UpdateOrderDetailCommand command)
    {
        var orderDetail = await _orderDetailRepository.GetByIdAsync(command.OrderDetailId);
        orderDetail.ProductId = Guid.Parse(command.ProductId);
        orderDetail.ProductName = command.ProductName;
        orderDetail.ProductPrice = command.ProductPrice;
        orderDetail.ProductAmount = command.ProductAmount;
        orderDetail.ProductTotalPrice = command.ProductTotalPrice;
        orderDetail.OrderingId = Guid.Parse(command.OrderingId);
        await _orderDetailRepository.UpdateAsync(orderDetail);
    }
}