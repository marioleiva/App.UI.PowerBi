﻿using System.Web;
using System.Web.Mvc;

namespace App.UI.PowerBI
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
