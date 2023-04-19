using test2.Client.Models;
using test2.Shared;
namespace test2.Client.Services.ProductService
{
    public interface IProductService
    {
        List<Product> Products { get; set; }
        List<ShipmentStatusModel> Statuses { get; set; }
        Task GetProducts();
        Task GetShipmentStatus(Guid shipmentId);
        Task<Product> GetProductById(int id);   
        Task CreateProduct(AddProduct product);   
        Task DeleteProduct(int id);
        Task UpdateProduct(int id, Product product);
    }
}
