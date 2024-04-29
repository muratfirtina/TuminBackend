namespace Tumin.Basket.Dtos;

public class BasketItemDto
{
    public string ProductId { get; set; }
    public string ProductName { get; set; }
    public decimal Price { get; set; }
    public int Quantity { get; set; }
}