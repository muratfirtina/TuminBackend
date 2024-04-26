using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Tumin.Catalog.Entities;

public class ProductImage
{
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string ProductImageId { get; set; }
    public string ProductId { get; set; }
    public string ImageUrl { get; set; }
    public string ImageAlt { get; set; }
    [BsonIgnore]
    public Product Product { get; set; }
}