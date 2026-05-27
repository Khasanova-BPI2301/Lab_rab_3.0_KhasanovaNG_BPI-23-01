using Microsoft.AspNetCore.Mvc;

namespace Lab_rab_3._0_KhasanovaNG_BPI_23_01.Controllers
{
    public class VegetablesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
