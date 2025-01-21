public class ShippingStatistics
{
    public int Id { get; set; }
    public string Origin { get; set; }
    public string Destination { get; set; }
    public string Carrier { get; set; }
    public int AverageShippingTime { get; set; }
    public int ShipmentCount { get; set; }
    public DateTime LastUpdateDate { get; set; }
}
