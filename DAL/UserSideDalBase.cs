using Microsoft.AspNetCore.Mvc;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;
using System.Data;
using System.Data.Common;

namespace Project_Final.DAL
{
	public class UserSideDalBase : DALHelper
	{
		#region PR_Admin_NewCars_ViewDetail_SelectByCarID
		public DataTable PR_Admin_NewCars_ViewDetail_SelectByCarID(int CarID)
		{
			try
			{
				SqlDatabase sqlDatabase = new SqlDatabase(ConnectionString);
				DbCommand dbCommand = sqlDatabase.GetStoredProcCommand("PR_Admin_NewCars_ViewDetail_SelectByCarID");
				sqlDatabase.AddInParameter(dbCommand, "@CarID", DbType.Int32, CarID);
				DataTable dataTable = new DataTable();
				using (IDataReader dataReader = sqlDatabase.ExecuteReader(dbCommand))
				{
					dataTable.Load(dataReader);
				}
				return dataTable;
			}
			catch (Exception ex)
			{
				return null;
			}
		}
		#endregion

		#region PR_FeaturedCars_FilterCars
		public DataTable PR_FeaturedCars_FilterCars(int BrandID,int TransmissionID,int FuelTypeID)
		{
			try
			{
				SqlDatabase sqlDatabase = new SqlDatabase(ConnectionString);
				DbCommand dbCommand = sqlDatabase.GetStoredProcCommand("PR_FeaturedCars_FilterCars");
				sqlDatabase.AddInParameter(dbCommand, "@BrandID", DbType.Int32, BrandID);
				sqlDatabase.AddInParameter(dbCommand, "@TransmissionID", DbType.Int32, TransmissionID);
				sqlDatabase.AddInParameter(dbCommand, "@FuelTypeID", DbType.Int32, FuelTypeID);
				DataTable dataTable = new DataTable();
				using (IDataReader dataReader = sqlDatabase.ExecuteReader(dbCommand))
				{
					dataTable.Load(dataReader);
				}
				return dataTable;
			}
			catch (Exception ex)
			{
				return null;
			}
		}
		#endregion
	}
}
