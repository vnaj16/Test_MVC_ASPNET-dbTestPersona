﻿using System.Web;
using System.Web.Mvc;

namespace Test_MVC_ASPNET
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
