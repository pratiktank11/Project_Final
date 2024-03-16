 using Microsoft.AspNetCore.Mvc;
using Project_Final.DAL;
using System.Data;
using System.Data.SqlClient;

namespace Project_Final.Areas.Admin.Controllers
{
	[Area("Admin")]
	[Route("Admin/[controller]/[action]")]
	public class AdminSideController : Controller 
	{
        public IConfiguration Configuration;

        public AdminSideController(IConfiguration configuration)
        {
            Configuration = configuration;
        }

		#region Dashboard
		public IActionResult Dashboard()
		{
			return View();
		}
		#endregion

		#region FeaturedCars_Forms
		public IActionResult FeaturedCars_Forms()
        {
            AdminDalBase adminDalBase = new AdminDalBase();
            DataTable Brand = adminDalBase.Brand_SelectAll();
            DataTable EngineType = adminDalBase.EngineType_SelectAll();
            DataTable FuelType = adminDalBase.FuelType_SelectAll();
            DataTable Transmission = adminDalBase.Transmission_SelectAll();
            DataTable ModelYear = adminDalBase.ModelYear_SelectAll();

            List<FeaturedCarsFormsModel> brand = new List<FeaturedCarsFormsModel>();

            foreach (DataRow dr in Brand.Rows)
            {
                FeaturedCarsFormsModel featuredCarsFormsModel = new FeaturedCarsFormsModel();
                featuredCarsFormsModel.BrandID = int.Parse(dr["BrandID"].ToString());
                featuredCarsFormsModel.BrandName = dr["BrandName"].ToString();
                brand.Add(featuredCarsFormsModel);
            }
            ViewBag.BrandList = brand;

            List<FeaturedCarsFormsModel> engineType = new List<FeaturedCarsFormsModel>();

            foreach (DataRow dr in EngineType.Rows)
            {
                FeaturedCarsFormsModel featuredCarsFormsModel = new FeaturedCarsFormsModel();
                featuredCarsFormsModel.EngineTypeID = int.Parse(dr["EngineTypeID"].ToString());
                featuredCarsFormsModel.EngineType = dr["EngineType"].ToString();
                engineType.Add(featuredCarsFormsModel);
            }
            ViewBag.EngineTypeList = engineType;

            List<FeaturedCarsFormsModel> fuelType = new List<FeaturedCarsFormsModel>();

            foreach (DataRow dr in FuelType.Rows)
            {
                FeaturedCarsFormsModel featuredCarsFormsModel = new FeaturedCarsFormsModel();
                featuredCarsFormsModel.FuelTypeID = int.Parse(dr["FuelTypeID"].ToString());
                featuredCarsFormsModel.FuelType = dr["FuelType"].ToString();
                fuelType.Add(featuredCarsFormsModel);
            }
            ViewBag.FuelTypeList = fuelType;

            List<FeaturedCarsFormsModel> transmission = new List<FeaturedCarsFormsModel>();

            foreach (DataRow dr in Transmission.Rows)
            {
                FeaturedCarsFormsModel featuredCarsFormsModel = new FeaturedCarsFormsModel();
                featuredCarsFormsModel.TransmissionID = int.Parse(dr["TransmissionID"].ToString());
                featuredCarsFormsModel.TransmissionType = dr["TransmissionType"].ToString();
                transmission.Add(featuredCarsFormsModel);
            }
            ViewBag.TransmissionTypeList = transmission;

            List<FeaturedCarsFormsModel> modelYear = new List<FeaturedCarsFormsModel>();

            foreach (DataRow dr in ModelYear.Rows)
            {
                FeaturedCarsFormsModel featuredCarsFormsModel = new FeaturedCarsFormsModel();
                featuredCarsFormsModel.ModelYearID = int.Parse(dr["ModelYearID"].ToString());
                featuredCarsFormsModel.ModelYear = int.Parse(dr["ModelYear"].ToString());
                modelYear.Add(featuredCarsFormsModel);
            }
            ViewBag.ModelYearList = modelYear;

            return View("FeaturedCars_Forms");
        }
		#endregion

		#region NewCars_Forms
		public IActionResult NewCars_Forms()
        {
            AdminDalBase adminDalBase = new AdminDalBase();
            DataTable Brand = adminDalBase.Brand_SelectAll();
            DataTable EngineType = adminDalBase.EngineType_SelectAll();
            DataTable FuelType = adminDalBase.FuelType_SelectAll();
            DataTable Transmission = adminDalBase.Transmission_SelectAll();

            List<NewCarsFormsModel> brand = new List<NewCarsFormsModel>();

            foreach (DataRow dr in Brand.Rows)
            {
                NewCarsFormsModel newCarsFormsModel = new NewCarsFormsModel();
                newCarsFormsModel.BrandID = int.Parse(dr["BrandID"].ToString());
                newCarsFormsModel.BrandName = dr["BrandName"].ToString();
                brand.Add(newCarsFormsModel);
            }
            ViewBag.BrandList = brand;

            List<NewCarsFormsModel> engineType = new List<NewCarsFormsModel>();

            foreach (DataRow dr in EngineType.Rows)
            {
                NewCarsFormsModel newCarsFormsModel = new NewCarsFormsModel();
                newCarsFormsModel.EngineTypeID = int.Parse(dr["EngineTypeID"].ToString());
                newCarsFormsModel.EngineType = dr["EngineType"].ToString();
                engineType.Add(newCarsFormsModel);
            }
            ViewBag.EngineTypeList = engineType;

            List<NewCarsFormsModel> fuelType = new List<NewCarsFormsModel>();

            foreach (DataRow dr in FuelType.Rows)
            {
                NewCarsFormsModel newCarsFormsModel = new NewCarsFormsModel();
                newCarsFormsModel.FuelTypeID = int.Parse(dr["FuelTypeID"].ToString());
                newCarsFormsModel.FuelType = dr["FuelType"].ToString();
                fuelType.Add(newCarsFormsModel);
            }
            ViewBag.FuelTypeList = fuelType;

            List<NewCarsFormsModel> transmission = new List<NewCarsFormsModel>();

            foreach (DataRow dr in Transmission.Rows)
            {
                NewCarsFormsModel newCarsFormsModel = new NewCarsFormsModel();
                newCarsFormsModel.TransmissionID = int.Parse(dr["TransmissionID"].ToString());
                newCarsFormsModel.TransmissionType = dr["TransmissionType"].ToString();
                transmission.Add(newCarsFormsModel);
            }
            ViewBag.TransmissionTypeList = transmission;

            return View();
        }
		#endregion

		#region Brands_Forms
		public IActionResult Brands_Forms()
        {
            return View();
        }
		#endregion

		#region FeaturedCars_Table
		public IActionResult FeaturedCars_Table()
        {
            AdminDalBase adminDalBase = new AdminDalBase();
            DataTable dataTable = adminDalBase.FeaturedCarsSellectAll();
            return View(dataTable);
        }
        #endregion

        #region NewCars_Table
        public IActionResult NewCars_Table()
        {
            AdminDalBase adminDalBase = new AdminDalBase();
            DataTable dataTable = adminDalBase.NewCarsSellectAll_Table();
            return View(dataTable);
        }
		#endregion

		#region FeaturedCars_Table_DeleteByID
        
        public IActionResult FeaturedCars_Table_DeleteByID(int CarID)
        {
            AdminDalBase adminDalBase = new AdminDalBase();
            bool IsSuccess = adminDalBase.PR_FeaturedCars_Table_DeleteByID(CarID);
            if(IsSuccess)
            {
				return RedirectToAction("FeaturedCars_Table");
			}
            else
            {
				return RedirectToAction("FeaturedCars_Table");
			}
           
        }

		#endregion

		#region NewCars_Table_DeleteByID

		public IActionResult NewCars_Table_DeleteByID(int CarID)
		{
			AdminDalBase adminDalBase = new AdminDalBase();
			bool IsSuccess = adminDalBase.PR_NewCars_Table_DeleteByID(CarID);
			if (IsSuccess)
			{
				return RedirectToAction("NewCars_Table");
			}
			else
			{
				return RedirectToAction("NewCars_Table");
			}

		}

		#endregion


	}
}
