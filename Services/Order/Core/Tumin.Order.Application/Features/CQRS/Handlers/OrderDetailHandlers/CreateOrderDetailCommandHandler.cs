using Tumin.Order.Application.Features.CQRS.Commands.OrderDetailCommands;
using Tumin.Order.Application.Interfaces;
using Tumin.Order.Domain.Entities;

namespace Tumin.Order.Application.Features.CQRS.Handlers.OrderDetailHandlers;

public class CreateOrderDetailCommandHandler
{
    private readonly IRepository<OrderDetail> _orderDetailRepository;

    public CreateOrderDetailCommandHandler(IRepository<OrderDetail> orderDetailRepository)
    {
        _orderDetailRepository = orderDetailRepository;
    }
    
    public async Task Handle(CreateOrderDetailCommand command)
    {
        await _orderDetailRepository.CreateAsync(new OrderDetail
        {
            ProductId = Guid.Parse(command.ProductId),
            ProductName = command.ProductName,
            ProductPrice = command.ProductPrice,
            ProductAmount = command.ProductAmount,
            ProductTotalPrice = command.ProductTotalPrice,
            OrderingId = Guid.Parse(command.OrderingId)
        });
    }
}