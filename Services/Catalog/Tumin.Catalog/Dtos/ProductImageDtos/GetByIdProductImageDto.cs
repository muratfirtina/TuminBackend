namespace Tumin.Catalog.Dtos.ProductImageDtos;

public class GetByIdProductImageDto
{
    public string ProductImageId { get; set; }
    public string ProductId { get; set; }
    public string ImageUrl { get; set; }
    public string ImageAlt { get; set; }
}