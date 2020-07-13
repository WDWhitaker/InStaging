using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InStaging.MvcApp.Helper
{
    public static class RazorHelper
    {
        public static string GetActiveString(string activenav, string checknav)
        {
            try
            {
                activenav = activenav.Trim().ToLower();
                checknav = checknav.Trim().ToLower();
                return activenav == checknav ? "active" : "";
            }
            catch
            {

            }
            return "";
        }

        public static List<SelectListItem> GetEnumList<T>() where T : struct
        {
            var list = Enum.GetValues(typeof(T))
              .Cast<T>()
              .Select(v => new SelectListItem(v.ToString(), $"{v}" ))
              .ToList();

            return list;
        }
    }
}
