using Microsoft.AspNetCore.Mvc;

namespace DMAWS_T2204M_LeTuanAnh.Controllers
{
    public class EmployeesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
