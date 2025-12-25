using Microsoft.AspNetCore.Mvc;
using WareHouse.Application.Services;

[ApiController]
[Route("api/[controller]")]
public class TireSizeController : ControllerBase
{
    private readonly TireSizeService _tireSizeService;

    // Constructor ile servisi içeri alıyoruz
    public TireSizeController(TireSizeService tireSizeService)
    {
        _tireSizeService = tireSizeService;
    }

    [HttpGet]
    public IActionResult GetTires()
    {
        // Service içindeki DataTable'ı DTO listesine çeviren metodu çağırıyoruz
        var result = _tireSizeService.GetTireSizesDataTable();
        return Ok(result);
    }
}