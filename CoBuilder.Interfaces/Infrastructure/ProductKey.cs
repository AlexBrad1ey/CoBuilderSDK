namespace CoBuilder.Service.Interfaces.App
{
    public class ProductKey
    {
        public int WorkplaceId { get; set; }
        public int ProductId { get; set; }

        public ProductKey(int workplaceId, int productId)
        {
            WorkplaceId = workplaceId;
            ProductId = productId;
        }
    }
}