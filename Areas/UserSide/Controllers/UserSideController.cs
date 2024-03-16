using Microsoft.AspNetCore.Mvc;
using Project_Final.DAL;
using System.Data;
using System.Drawing.Drawing2D;

namespace Project_Final.Areas.UserSide.Controllers
{
    [Area("UserSide")]
    [Route("UserSide/[controller]/[action]")]
    public class UserSideController : Controller
    {
		UserSideDalBase userSideDalBase= new UserSideDalBase();

		#region Service
		public IActionResult Service()
        {
			return View();
		}
		#endregion

		#region NewCars
		public IActionResult NewCars()
        {
			AdminDalBase adminDalBase = new AdminDalBase();
			DataTable dataTable = adminDalBase.NewCarsSellectAll();
			return View(dataTable);
		}
		#endregion

		#region Home
		public IActionResult Home()
		{
			AdminDalBase adminDalBase = new AdminDalBase();
			DataTable dataTable = adminDalBase.NewCarsSellectAll();
			return View(dataTable);
		}
		#endregion

		#region Brands
		public IActionResult Brands()
		{
			return View();
		}
		#endregion

		#region Contact
		public IActionResult Contact()
		{
			return View();
		}
		#endregion

		#region FeaturedCars
		public IActionResult FeaturedCars()
		{
			AdminDalBase adminDalBase = new AdminDalBase();
			DataTable Brand = adminDalBase.Brand_SelectAll();
			DataTable FuelType = adminDalBase.FuelType_SelectAll();
			DataTable Transmission = adminDalBase.Transmission_SelectAll();
			DataTable FeaturedCarsAll = adminDalBase.FeaturedCarsSellectAll();

			List<FeaturedCarsFormsModel> featuredCarsAll = new List<FeaturedCarsFormsModel>();
			foreach(DataRow dr in FeaturedCarsAll.Rows)
			{
				FeaturedCarsFormsModel featuredCarsFormsModel = new FeaturedCarsFormsModel();
				featuredCarsFormsModel.ImgURL = dr["ImgURL"].ToString();
				featuredCarsFormsModel.TransmissionType = dr["TransmissionType"].ToString();
				featuredCarsFormsModel.FuelType = dr["FuelType"].ToString();
				featuredCarsFormsModel.BrandName = dr["BrandName"].ToString();
				featuredCarsFormsModel.CarName = dr["CarName"].ToString();
				featuredCarsFormsModel.Price = float.Parse(dr["Price"].ToString());
				featuredCarsFormsModel.Description = dr["Description"].ToString();
				featuredCarsAll.Add(featuredCarsFormsModel);
			}
			ViewBag.FeaturedCarsAllList = featuredCarsAll;

			List<FeaturedCarsFormsModel> brand = new List<FeaturedCarsFormsModel>();

			foreach (DataRow dr in Brand.Rows)
			{
				FeaturedCarsFormsModel featuredCarsFormsModel = new FeaturedCarsFormsModel();
				featuredCarsFormsModel.BrandID = int.Parse(dr["BrandID"].ToString());
				featuredCarsFormsModel.BrandName = dr["BrandName"].ToString();
				brand.Add(featuredCarsFormsModel);
			}
			ViewBag.BrandList = brand;

			List<FeaturedCarsFormsModel> transmission = new List<FeaturedCarsFormsModel>();

			foreach (DataRow dr in Transmission.Rows)
			{
				FeaturedCarsFormsModel featuredCarsFormsModel = new FeaturedCarsFormsModel();
				featuredCarsFormsModel.TransmissionID = int.Parse(dr["TransmissionID"].ToString());
				featuredCarsFormsModel.TransmissionType = dr["TransmissionType"].ToString();
				transmission.Add(featuredCarsFormsModel);
			}
			ViewBag.TransmissionTypeList = transmission;

			List<FeaturedCarsFormsModel> fuelType = new List<FeaturedCarsFormsModel>();

			foreach (DataRow dr in FuelType.Rows)
			{
				FeaturedCarsFormsModel featuredCarsFormsModel = new FeaturedCarsFormsModel();
				featuredCarsFormsModel.FuelTypeID = int.Parse(dr["FuelTypeID"].ToString());
				featuredCarsFormsModel.FuelType = dr["FuelType"].ToString();
				fuelType.Add(featuredCarsFormsModel);
			}
			ViewBag.FuelTypeList = fuelType;


			
			return View();
		}
		#endregion

		#region NewCars_ViewDetail
		public IActionResult NewCars_ViewDetail(int CarID)
		{
			DataTable datatable= userSideDalBase.PR_Admin_NewCars_ViewDetail_SelectByCarID(CarID);
            List<NewCarsFormsModel> NewCarsViewDetailList = new List<NewCarsFormsModel>();

            foreach (DataRow dr in datatable.Rows)
            {
                NewCarsFormsModel newCarsFormsModel = new NewCarsFormsModel();
                newCarsFormsModel.ImgURL = dr["ImgURL"].ToString();
                newCarsFormsModel.TransmissionType = dr["TransmissionType"].ToString();
                newCarsFormsModel.FuelType = dr["FuelType"].ToString();
                newCarsFormsModel.EngineType = dr["EngineType"].ToString();
                newCarsFormsModel.BrandName = dr["BrandName"].ToString();
				newCarsFormsModel.SeatingCapacity = int.Parse(dr["SeatingCapacity"].ToString()); ;
                newCarsFormsModel.Mileage = int.Parse(dr["Mileage"].ToString()); ;
                newCarsFormsModel.CarName = dr["CarName"].ToString();
                newCarsFormsModel.Price = int.Parse(dr["Price"].ToString());
                newCarsFormsModel.Description = dr["Description"].ToString();
				newCarsFormsModel.Rating = int.Parse(dr["Rating"].ToString());
                NewCarsViewDetailList.Add(newCarsFormsModel);
            }
            ViewBag.NewCarsViewDetailList = NewCarsViewDetailList;
            return View();
		}
		#endregion

		#region FeaturedCars_FilterCars
		public IActionResult FeaturedCars_FilterCars(int? BrandID = null, int? TransmissionID = null, int? FuelTypeID = null)
		{
			BrandID = BrandID ?? 0;
			TransmissionID = TransmissionID ?? 0;
			FuelTypeID = FuelTypeID ?? 0;
			DataTable FeaturedCarsFilter = userSideDalBase.PR_FeaturedCars_FilterCars(BrandID.Value, TransmissionID.Value, FuelTypeID.Value);

			List<FeaturedCarsFormsModel> FeaturedCars_Filter = new List<FeaturedCarsFormsModel>();

			foreach (DataRow dr in FeaturedCarsFilter.Rows)
			{
				FeaturedCarsFormsModel featuredCarsFormsModel = new FeaturedCarsFormsModel();
				featuredCarsFormsModel.ImgURL = dr["ImgURL"].ToString();
				featuredCarsFormsModel.TransmissionType = dr["TransmissionType"].ToString();
				featuredCarsFormsModel.FuelType = dr["FuelType"].ToString();
				featuredCarsFormsModel.BrandName = dr["BrandName"].ToString();
				featuredCarsFormsModel.CarName = dr["CarName"].ToString();
				featuredCarsFormsModel.Price = float.Parse(dr["Price"].ToString());
				featuredCarsFormsModel.Description = dr["Description"].ToString();
				FeaturedCars_Filter.Add(featuredCarsFormsModel);
			}
			ViewBag.FeaturedCarsFiltersList = FeaturedCars_Filter;

			return View("FeaturedCars");
		}
		#endregion
	}
}
