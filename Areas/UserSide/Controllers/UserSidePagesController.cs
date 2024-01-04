using Microsoft.AspNetCore.Mvc;

namespace Project_Final.Areas.UserSide.Controllers
{
    [Area("UserSide")]
    [Route("UserSide/[controller]/[action]")]
    public class UserSidePagesController : Controller
    {
       public IActionResult Service()
        {
            return View();
        }
    }
}
