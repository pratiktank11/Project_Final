using Microsoft.AspNetCore.Mvc;

namespace Project_Final.Areas.UserSide.Controllers
{
    [Area("UserSide")]
    [Route("UserSide/[controller]/[action]")]
    public class UserSideController : Controller
    {
       public IActionResult Service()
        {
			return View();
		}

		public IActionResult NewCars()
        {
            return View();
        }

		public IActionResult Home()
		{
			return View();
		}

		public IActionResult Brands()
		{
			return View();
		}

		public IActionResult Contact()
		{
			return View();
		}

		public IActionResult FeaturedCars()
		{
			return View();
		}
	}
}
