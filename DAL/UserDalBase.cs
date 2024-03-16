using System.Data.Common;
using System.Data;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;
using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.AspNetCore.Mvc;
using System.Reflection;

namespace Project_Final.DAL
{
    public class UserDalBase : DALHelper
    {
        #region Method: PR_USER_LOGIN
        public DataTable PR_USER_LOGIN(string UserName, string Password)
        {
            try
            {
                SqlDatabase sqlDB = new SqlDatabase(ConnectionString);
                DbCommand dbCMD = sqlDB.GetStoredProcCommand("PR_USER_LOGIN");
                sqlDB.AddInParameter(dbCMD, "UserName", SqlDbType.VarChar, UserName);
                sqlDB.AddInParameter(dbCMD, "Password", SqlDbType.VarChar, Password);

                DataTable dt = new DataTable();
                using (IDataReader dr = sqlDB.ExecuteReader(dbCMD))
                {
                    dt.Load(dr);
                }

                return dt;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        #endregion

        #region Method : PR_User_Create_Account

        public bool PR_User_Create_Account(User_UserModel model)
        {
            try
            {
                SqlDatabase sqlDatabase = new SqlDatabase(ConnectionString);
                DbCommand dbCommand = sqlDatabase.GetStoredProcCommand("PR_SEC_User_SelectUserName");
                sqlDatabase.AddInParameter(dbCommand, "UserName", SqlDbType.VarChar, model.UserName);
                DataTable dt = new DataTable();
                using (IDataReader dr = sqlDatabase.ExecuteReader(dbCommand))
                {
                    dt.Load(dr);
                }
                if (dt.Rows.Count > 0) { return false; }
                else
                {
                    DbCommand dbCommand1 = sqlDatabase.GetStoredProcCommand("PR_SEC_User_Insert");
                    sqlDatabase.AddInParameter(dbCommand1, "@UserName", SqlDbType.NVarChar, model.UserName);
                    sqlDatabase.AddInParameter(dbCommand1, "@Password", SqlDbType.NVarChar, model.Password);
                    sqlDatabase.AddInParameter(dbCommand1, "@isAdmin", SqlDbType.Bit, model.isAdmin);
                    if (Convert.ToBoolean(sqlDatabase.ExecuteNonQuery(dbCommand1)))
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            catch (Exception ex) { return false; }

        }

		#endregion

	}
}
