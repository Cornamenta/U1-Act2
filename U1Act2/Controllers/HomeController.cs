using Microsoft.AspNetCore.Mvc;
using U1Act2.Models;

namespace U1Act2.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index(float Calif1, float Calif2, float Calif3)
        {
            PromedioViewModel vm = new PromedioViewModel();
            vm.Calif1 = Calif1;
            vm.Calif2 = Calif2;
            vm.Calif3 = Calif3;
            return View(vm);
        }
    }
}
