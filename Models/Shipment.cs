using System;

namespace SmartLogisticsSystem.Models
{
    public class Shipment
    {
        public int Id { get; set; } // Primary Key
        public string TrackingNumber { get; set; }
        public string Origin { get; set; }
        public string Destination { get; set; }
        public DateTime ShippingDate { get; set; }
        public DateTime EstimatedDeliveryDate { get; set; }
    }
}