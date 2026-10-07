namespace TechStoreInventory.Models
{
    public class Product
    {
        public Guid Id { get; set; }
        public required string Product { get; set; }
        public string? Description { get; set; }
        public string? Type { get; set; }
        public decimal? Price { get; set; }
    }
}
