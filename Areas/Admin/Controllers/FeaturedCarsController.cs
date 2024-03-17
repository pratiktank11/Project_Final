using Microsoft.AspNetCore.Mvc;
using Project_Final.DAL;
using System.Data.SqlClient;
using System.Data;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;
using Microsoft.Practices.EnterpriseLibrary.Data;
using System.Data.Common;
using System.Reflection;


namespace Project_Final.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/[controller]/[action]")]
    public class FeaturedCarsController : Controller
    {
        public IConfiguration Configuration;

        public FeaturedCarsController(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        
        public IActionResult FeaturedCarsSubmit(FeaturedCarsFormsModel featuredCarsFormsModel)
        {

            if(ModelState.IsValid)
            {
                AdminDalBase adminDal = new AdminDalBase();
               
                if (adminDal.PR_Admin_FeaturedCars_Insert(featuredCarsFormsModel))
                {
                    return RedirectToAction("FeaturedCars_Table", "AdminSide");
                }
                else
                {
                    return RedirectToAction("FeaturedCars_Forms", "AdminSide");
                }
            }
           

        }

	}
}
