using Microsoft.Practices.EnterpriseLibrary.Data.Sql;
using System.Data.Common;
using System.Data;
using System.Reflection;
using System.Data.SqlClient;

namespace Project_Final.DAL
{
    public class AdminDalBase : DALHelper
    {
        #region Method : Admin_FeaturedCars_Insert

        public bool PR_Admin_FeaturedCars_Insert(FeaturedCarsFormsModel model)
        {
            try
            {
                SqlDatabase sqlDatabase = new SqlDatabase(ConnectionString);

                DbCommand dbCommand1 = sqlDatabase.GetStoredProcCommand("PR_Admin_FeaturedCars_Insert");
                sqlDatabase.AddInParameter(dbCommand1, "@ImgURL", SqlDbType.VarChar, model.ImgURL);
                sqlDatabase.AddInParameter(dbCommand1, "@ModelYearID", SqlDbType.Int, model.ModelYearID);
                sqlDatabase.AddInParameter(dbCommand1, "@Price", SqlDbType.Decimal, model.Price);
                sqlDatabase.AddInParameter(dbCommand1, "@Description", SqlDbType.VarChar, model.Description);
                sqlDatabase.AddInParameter(dbCommand1, "@CarName", SqlDbType.VarChar, model.CarName);
                sqlDatabase.AddInParameter(dbCommand1, "@BrandID", SqlDbType.Int, model.BrandID);
                sqlDatabase.AddInParameter(dbCommand1, "@TransmissionID", SqlDbType.Int, model.TransmissionID);
                sqlDatabase.AddInParameter(dbCommand1, "@FuelTypeID", SqlDbType.Int, model.FuelTypeID);
                sqlDatabase.AddInParameter(dbCommand1, "@EngineTypeID", SqlDbType.Int, model.EngineTypeID);
                sqlDatabase.AddInParameter(dbCommand1, "@SeatingCapacity", SqlDbType.Int, model.SeatingCapacity);
                sqlDatabase.AddInParameter(dbCommand1, "@Mileage", SqlDbType.Int, model.Mileage);
                if (Convert.ToBoolean(sqlDatabase.ExecuteNonQuery(dbCommand1)))
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
            catch (Exception ex)
            {
                return false;
            }

        }   

        #endregion

        #region Method : PR_Admin_FeaturedCars_UpdateByID]

        public bool PR_Admin_FeaturedCars_UpdateByID(FeaturedCarsFormsModel featuredCarsFormsModel)
        {
            try
            {
                SqlDatabase sqlDatabase = new SqlDatabase(ConnectionString);
                DbCommand dbCommand1 = sqlDatabase.GetStoredProcCommand("PR_Admin_FeaturedCars_UpdateByID");
                sqlDatabase.AddInParameter(dbCommand1, "@CarID", SqlDbType.Int, featuredCarsFormsModel.CarID);
                sqlDatabase.AddInParameter(dbCommand1, "@ImgURL", SqlDbType.VarChar, featuredCarsFormsModel.ImgURL);
                sqlDatabase.AddInParameter(dbCommand1, "@ModelYearID", SqlDbType.Int, featuredCarsFormsModel.ModelYearID);
                sqlDatabase.AddInParameter(dbCommand1, "@Price", SqlDbType.Decimal, featuredCarsFormsModel.Price);
                sqlDatabase.AddInParameter(dbCommand1, "@Description", SqlDbType.VarChar, featuredCarsFormsModel.Description);
                sqlDatabase.AddInParameter(dbCommand1, "@CarName", SqlDbType.VarChar, featuredCarsFormsModel.CarName);
                sqlDatabase.AddInParameter(dbCommand1, "@BrandID", SqlDbType.Int, featuredCarsFormsModel.BrandID);
                sqlDatabase.AddInParameter(dbCommand1, "@TransmissionID", SqlDbType.Int, featuredCarsFormsModel.TransmissionID);
                sqlDatabase.AddInParameter(dbCommand1, "@FuelTypeID", SqlDbType.Int, featuredCarsFormsModel.FuelTypeID);
                sqlDatabase.AddInParameter(dbCommand1, "@EngineTypeID", SqlDbType.Int, featuredCarsFormsModel.EngineTypeID);
                sqlDatabase.AddInParameter(dbCommand1, "@SeatingCapacity", SqlDbType.Int, featuredCarsFormsModel.SeatingCapacity);
                sqlDatabase.AddInParameter(dbCommand1, "@Mileage", SqlDbType.Int, featuredCarsFormsModel.Mileage);
                if (Convert.ToBoolean(sqlDatabase.ExecuteNonQuery(dbCommand1)))
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
            catch (Exception ex)
            {
                return false;
            }
        }

        #endregion

        #region Method : Featured Cars SelectAll (Active)
        public DataTable FeaturedCarsSellectAll()
        {
            try
            {
                SqlDatabase sqlDatabase = new SqlDatabase(ConnectionString);
                DbCommand dbCommand = sqlDatabase.GetStoredProcCommand("PR_FeaturedCars_SellectAll");
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

        #region Method : Admin New Cars SelectAll Table
        public DataTable NewCarsSellectAll_Table()
        {
            try
            {
                SqlDatabase sqlDatabase = new SqlDatabase(ConnectionString);
                DbCommand dbCommand = sqlDatabase.GetStoredProcCommand("PR_NewCars_SellectAll_Table");
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

        #region Method : Admin_NewCars_Insert

        public bool PR_Admin_NewCars_Insert(NewCarsFormsModel model)
        {
            try
            {
                SqlDatabase sqlDatabase = new SqlDatabase(ConnectionString);
                DbCommand dbCommand = sqlDatabase.GetStoredProcCommand("PR_Admin_NewCars_Insert");

                DbCommand dbCommand1 = sqlDatabase.GetStoredProcCommand("PR_Admin_NewCars_Insert");
                sqlDatabase.AddInParameter(dbCommand1, "@CarName", SqlDbType.VarChar, model.CarName);
                sqlDatabase.AddInParameter(dbCommand1, "@ImgURL", SqlDbType.VarChar, model.ImgURL);
                sqlDatabase.AddInParameter(dbCommand1, "@BrandID", SqlDbType.Int, model.BrandID);
                sqlDatabase.AddInParameter(dbCommand1, "@TransmissionID", SqlDbType.Int, model.TransmissionID);
                sqlDatabase.AddInParameter(dbCommand1, "@FuelTypeID", SqlDbType.Int, model.FuelTypeID);
                sqlDatabase.AddInParameter(dbCommand1, "@EngineTypeID", SqlDbType.Int, model.EngineTypeID);
                sqlDatabase.AddInParameter(dbCommand1, "@SeatingCapacity", SqlDbType.Int, model.SeatingCapacity);
                sqlDatabase.AddInParameter(dbCommand1, "@Mileage", SqlDbType.Int, model.Mileage);
                sqlDatabase.AddInParameter(dbCommand1, "@Price", SqlDbType.Decimal, model.Price);
                sqlDatabase.AddInParameter(dbCommand1, "@Description", SqlDbType.VarChar, model.Description);
                sqlDatabase.AddInParameter(dbCommand1, "@Rating", SqlDbType.Int, model.Rating);
                if (Convert.ToBoolean(sqlDatabase.ExecuteNonQuery(dbCommand1)))
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
            catch (Exception ex) { return false; }

        }

        #endregion

        #region Method : PR_Admin_NewCars_SellectAll
        public DataTable NewCarsSellectAll()
        {
            try
            {
                SqlDatabase sqlDatabase = new SqlDatabase(ConnectionString);
                DbCommand dbCommand = sqlDatabase.GetStoredProcCommand("PR_Admin_NewCars_SellectAll");
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

        #region Method : Brand_SelectAll
        public DataTable Brand_SelectAll()
        {
            try
            {
                SqlDatabase sqlDatabase = new SqlDatabase(ConnectionString);
                DbCommand dbCommand = sqlDatabase.GetStoredProcCommand("PR_Brand_SelectAll");
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

        #region Method : EngineType_SelectAll
        public DataTable EngineType_SelectAll()
        {
            try
            {
                SqlDatabase sqlDatabase = new SqlDatabase(ConnectionString);
                DbCommand dbCommand = sqlDatabase.GetStoredProcCommand("PR_EngineType_SelectAll");
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

        #region Method : FuelType_SelectAll
        public DataTable FuelType_SelectAll()
        {
            try
            {
                SqlDatabase sqlDatabase = new SqlDatabase(ConnectionString);
                DbCommand dbCommand = sqlDatabase.GetStoredProcCommand("PR_FuelType_SelectAll");
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

        #region Method : Transmission_SelectAll
        public DataTable Transmission_SelectAll()
        {
            try
            {
                SqlDatabase sqlDatabase = new SqlDatabase(ConnectionString);
                DbCommand dbCommand = sqlDatabase.GetStoredProcCommand("PR_Transmission_SelectAll");
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

        #region Method : ModelYear_SelectAll
        public DataTable ModelYear_SelectAll()
        {
            try
            {
                SqlDatabase sqlDatabase = new SqlDatabase(ConnectionString);
                DbCommand dbCommand = sqlDatabase.GetStoredProcCommand("PR_ModelYear_SelectAll");
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

        #region Method : FeaturedCars_Table_DeleteByID

        public bool PR_FeaturedCars_Table_DeleteByID(int CarID)
        {
            try
            {
                SqlDatabase sqlDatabase = new SqlDatabase(ConnectionString);
                DbCommand dbCommand = sqlDatabase.GetStoredProcCommand("PR_FeaturedCars_Table_DeleteByID");
                sqlDatabase.AddInParameter(dbCommand, "@CarID", DbType.Int32, CarID);
                if (Convert.ToBoolean(sqlDatabase.ExecuteNonQuery(dbCommand)))
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
            catch (Exception ex)
            {
                return false;
            }
        }
		#endregion

		#region Method : NewCars_Table_DeleteByID

		public bool PR_NewCars_Table_DeleteByID(int CarID)
		{
			try
			{
				SqlDatabase sqlDatabase = new SqlDatabase(ConnectionString);
				DbCommand dbCommand = sqlDatabase.GetStoredProcCommand("PR_NewCars_Table_DeleteByID");
				sqlDatabase.AddInParameter(dbCommand, "@CarID", DbType.Int32, CarID);
				if (Convert.ToBoolean(sqlDatabase.ExecuteNonQuery(dbCommand)))
				{
					return true;
				}
				else
				{
					return false;
				}

			}
			catch (Exception ex)
			{
				return false;
			}
		}
		#endregion

	}
}
