using System.Net;
using System.Net.Http.Json;
using test2.Client.Models;
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
        public List<ShipmentStatusModel> Statuses { get; set; } = new List<ShipmentStatusModel>();

        public async Task CreateProduct(AddProduct product)
        {
            await http.PostAsJsonAsync("api/Product", product);
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

        public async Task GetShipmentStatus(Guid shipmentId)
        {
            //var result = await http.GetFromJsonAsync<List<ShipmentStatusModel>>($"http://192.180.2.128:4000/api/shipment/getShipmentStatus/{shipmentId}");
            //statuses = result!.ToList();

            var result = await http.GetAsync($"https://localhost:7168/api/shipment/getShipmentStatus?shipmentId={shipmentId}");
            if (result.StatusCode == HttpStatusCode.OK)
            {
                var res =await result.Content.ReadFromJsonAsync<ResponseModel2>();
                Statuses = res!.data!;
            }
        }

        public Task UpdateProduct(int id, Product product)
        {
            throw new NotImplementedException();
        }
    }
}
