namespace test2.Client.Models
{
    public class ResponseModel
    {
        public int statusCode { get; set; } = 200;
        public string message { get; set; } = "Success";
        public object? data { get; set; } = null;
        public bool isSuccess { get; set; } = true;
    }
}
