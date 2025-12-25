using Microsoft.AspNetCore.Mvc;
using WareHouse.Application.Services;

[ApiController]
[Route("api/[controller]")]
public class TireSizeController : ControllerBase
{
    private readonly TireSizeService _tireSizeService;

 
    public TireSizeController(TireSizeService tireSizeService)
    {
        _tireSizeService = tireSizeService;
    }
  
}