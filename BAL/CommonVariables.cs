namespace Project_Final.BAL
{
    public static class CommonVariables
    {


        private static IHttpContextAccessor _httpContextAccessor;
        static CommonVariables()
        {
            _httpContextAccessor = new HttpContextAccessor();
        }
        public static int? UserId()
        {


            return Convert.ToInt32(_httpContextAccessor.HttpContext.Session.GetString("UserId").ToString());

        }
        public static string? UserName()
        {
            return _httpContextAccessor.HttpContext.Session.GetString("UserName");
        }



    }
}
