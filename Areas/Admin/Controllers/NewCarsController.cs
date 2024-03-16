using Microsoft.AspNetCore.Mvc;
using Project_Final.DAL;

namespace Project_Final.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/[controller]/[action]")]
    public class NewCarsController : Controller
    {
		#region NewCarsSubmit
		[HttpPost]
        public IActionResult NewCarsSubmit(NewCarsFormsModel newCarsFormsModel)
        {
            AdminDalBase adminDal = new AdminDalBase();
            bool IsSuccess = adminDal.PR_Admin_NewCars_Insert(newCarsFormsModel);

            if (IsSuccess)
            {
                return RedirectToAction("Dashboard", "AdminSide");
            }
            else
            {
                return RedirectToAction("NewCars_Forms", "AdminSide");
            }

        }
		#endregion


	}
}
