using test2.Shared;
namespace test2.Client.Services.ProductService
{
    public interface IProductService
    {
        List<Product> Products { get; set; }
        Task GetProducts();
        Task<Product> GetProductById(int id);   
        Task CreateProduct(Product product);   
        Task DeleteProduct(int id);
        Task UpdateProduct(int id, Product product);
    }
}
