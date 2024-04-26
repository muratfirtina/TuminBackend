using Tumin.Order.Application.Features.CQRS.Commands.OrderDetailCommands;
using Tumin.Order.Application.Interfaces;
using Tumin.Order.Domain.Entities;

namespace Tumin.Order.Application.Features.CQRS.Handlers.OrderDetailHandlers;

public class DeleteOrderDetailCommandHandler
{
    private readonly IRepository<OrderDetail?> _orderDetailRepository;

    public DeleteOrderDetailCommandHandler(IRepository<OrderDetail?> orderDetailRepository)
    {
        _orderDetailRepository = orderDetailRepository;
    }
    
    public async Task Handle(DeleteOrderDetailCommand request)
    {
        var orderDetail = await _orderDetailRepository.GetByIdAsync(request.Id);
        await _orderDetailRepository.DeleteAsync(orderDetail);
    }
}