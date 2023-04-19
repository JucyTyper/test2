using System.ComponentModel.DataAnnotations;

namespace test2.Client.Models
{
    public class ShipmentStatusModel
    {
        public Guid shipmentId { get; set; }
        public string shipmentStatus { get; set; } = string.Empty;
        public string currentLocation { get; set; } = string.Empty;
        public DateTime lastUpdated { get; set; } 
    }
}
