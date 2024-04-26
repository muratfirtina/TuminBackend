namespace Tumin.Catalog.Settings;

public interface IDatabaseSettings
{
    public string ConnectionString { get; set; }
    public string DatabaseName { get; set; }
    public string ProductCollectionName { get; set; }
    public string CategoryCollectionName { get; set; }
    public string ProductDetailCollectionName { get; set; }
    public string ProductImageCollectionName { get; set; }
}