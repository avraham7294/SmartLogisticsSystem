using Microsoft.AspNetCore.Mvc;
using SmartLogisticsSystem.Services;

[ApiController]
[Route("api/[controller]")]
public class PackageController : ControllerBase
{
    private readonly PackageApiService _packageApiService;

    public PackageController(PackageApiService packageApiService)
    {
        _packageApiService = packageApiService;
    }

    [HttpGet("track/{trackingNumber}")]
    public async Task<IActionResult> TrackPackage(string trackingNumber)
    {
        var packageDetails = await _packageApiService.GetPackageDetailsAsync(trackingNumber);

        if (packageDetails == null)
        {
            return NotFound("Package not found.");
        }

        return Ok(packageDetails);
    }

    [HttpGet("statistics")]
    public async Task<IActionResult> GetStatistics([FromQuery] string origin, [FromQuery] string destination)
    {
        var statistics = await _packageApiService.GetShippingStatisticsAsync(origin, destination);

        if (statistics == null || statistics.Count == 0)
        {
            return NotFound("No statistics found for the specified route.");
        }

        return Ok(statistics);
    }
}
