namespace test2.Client.Models
{
    public class ResponseModel2
    {
            public int statusCode { get; set; } = 200;
            public string message { get; set; } = "Success";
            public List<ShipmentStatusModel>? data { get; set; } 
            public bool isSuccess { get; set; } = true;
    }
}
