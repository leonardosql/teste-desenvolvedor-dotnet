﻿using System.Web;
using System.Web.Mvc;

namespace teste_desenvolvedor_dotnet
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
