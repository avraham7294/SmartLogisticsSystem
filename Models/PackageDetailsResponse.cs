public class PackageDetailsResponse
{
    public Package Package { get; set; }
    public string WeatherWarning { get; set; }
}

public class Package
{
    public string Id { get; set; }
    public string Carrier { get; set; }
    public string Status { get; set; }
    public DateTime ShippingDate { get; set; }
    public DateTime? DeliveryDate { get; set; }
    public string Origin { get; set; }
    public string Destination { get; set; }
}
