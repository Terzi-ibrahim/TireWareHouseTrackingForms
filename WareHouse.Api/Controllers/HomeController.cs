using Microsoft.AspNetCore.Mvc;
using WareHouse.Application.Services;

namespace WareHouse.Api.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult GetTires()
        {
            
            var service = new TireSizeService(); 
            var result = service.GetTireSizesDataTable();

            return Ok(result); 
        }
    }
}
