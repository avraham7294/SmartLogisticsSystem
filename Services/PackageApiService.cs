namespace SmartLogisticsSystem.Services
{
    using System.Net.Http;
    using System.Net.Http.Json;
    using System.Threading.Tasks;
    using SmartLogisticsSystem.Models;

    public class PackageApiService
    {
        private readonly HttpClient _httpClient;

        public PackageApiService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<PackageDetailsResponse?> GetPackageDetailsAsync(string trackingNumber)
        {
            var response = await _httpClient.GetFromJsonAsync<PackageDetailsResponse>(
                $"https://localhost:7049/api/PackageApi/details/{trackingNumber}"
            );

            return response;
        }

        public async Task<List<ShippingStatistics>?> GetShippingStatisticsAsync(string origin, string destination)
        {
            var response = await _httpClient.GetFromJsonAsync<List<ShippingStatistics>>(
                $"https://localhost:7049/api/PackageApi/Statistics?origin={origin}&destination={destination}"
            );

            return response;
        }
    }
}