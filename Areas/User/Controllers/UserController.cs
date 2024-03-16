using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Project_Final.DAL;
using System.Data;

namespace Project_Final.Areas.User.Controllers
{
    [Area("User")]
    [Route("User/[controller]/[action]")]
    public class UserController: Controller

    {
            #region Configuration
        private IConfiguration Configuration;

        #endregion

            #region UserController Constructor
        public UserController(IConfiguration _configuration)
    {
        Configuration = _configuration;

    }
        #endregion

            #region LoginForm
            public IActionResult LoginForm()
            {
                return View();
            }

        #endregion

            #region SEC_UserRegister
        public IActionResult SEC_UserRegister()
        {
            return View();
        }

        #endregion

            #region Login

            [HttpPost]
            public IActionResult Login(User_UserModel _UserModel)
            {
                string connStr = this.Configuration.GetConnectionString("ConnectionString");
                string error = null;

                if(_UserModel.UserName == null)
                {
                    error += "UserName is required..!";
                }

                if(_UserModel.Password == null)
                {
                    error += "Password is required..!";
                }

                if(error != null)
                {
                    TempData["Error"] = error;
                    return RedirectToAction("LoginForm","User");
                }
                else
                {
                        UserDalBase LoginDal = new UserDalBase();
                        DataTable dt = LoginDal.PR_USER_LOGIN(_UserModel.UserName, _UserModel.Password);
                        if (dt.Rows.Count > 0)
                        {
                            foreach (DataRow dr in dt.Rows)
                            {
                                HttpContext.Session.SetString("UserId", dr["UserId"].ToString());
                                HttpContext.Session.SetString("UserName", dr["UserName"].ToString()); 
                                HttpContext.Session.SetString("Password", dr["Password"].ToString());
                                HttpContext.Session.SetString("isAdmin", dr["isAdmin"].ToString());
                                break;

                            }
                        }

                        else
                        {
                            TempData["Error"] = "User Name or Password is invalid!";
                            return RedirectToAction("LoginForm","User");
                        }

                        if(HttpContext.Session.GetString("UserName")!=null && HttpContext.Session.GetString("Password") != null)
                        {
                            if(HttpContext.Session.GetString("isAdmin") == "1")
                            {
	        					return RedirectToAction("Dashboard","AdminSide",new {area = "Admin"});
	        				}

                            else if(HttpContext.Session.GetString("isAdmin") == "0")
                            {
                                return RedirectToAction("Home", "UserSide" ,new {area = "UserSide"});
                            }
                           
                        }

                }
                    return RedirectToAction("Index");
            }

                #endregion

            #region Logout
        public IActionResult Logout()
    {
        HttpContext.Session.Clear();
        return RedirectToAction("LoginForm");
    }

        #endregion

            #region SEC_UserSignUp
        public IActionResult SEC_UserSignUp(User_UserModel user_UserModel)
        {
            UserDalBase dal = new UserDalBase();
            bool IsSuccess = dal.PR_User_Create_Account(user_UserModel);

            if (IsSuccess)
            {
                return RedirectToAction("LoginForm");
            }

            else
            {

                return RedirectToAction("SEC_UserRegister");
            }


        }

        #endregion

    }
}

