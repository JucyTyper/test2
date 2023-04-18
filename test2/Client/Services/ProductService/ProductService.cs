using System.Net.Http.Json;
using test2.Shared;

namespace test2.Client.Services.ProductService
{
    public class ProductService : IProductService
    {
        private readonly HttpClient http;

        public ProductService(HttpClient http)
        {
            this.http = http;
        }
        public List<Product> Products { get; set ; } = new List<Product>(); 

        public Task CreateProduct(Product product)
        {
            throw new NotImplementedException();
        }

        public Task DeleteProduct(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Product> GetProductById(int id)
        {
            throw new NotImplementedException();
        }

        public async Task GetProducts()
        {
            var result = await http.GetFromJsonAsync<List<Product>>("api/Product");
            Products= result!.ToList();
            
        }

        public Task UpdateProduct(int id, Product product)
        {
            throw new NotImplementedException();
        }
    }
}
