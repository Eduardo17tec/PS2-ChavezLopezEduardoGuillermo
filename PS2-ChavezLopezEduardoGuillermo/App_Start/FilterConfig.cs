﻿using System.Web;
using System.Web.Mvc;

namespace PS2_ChavezLopezEduardoGuillermo
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
