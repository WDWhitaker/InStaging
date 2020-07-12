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
            
            activenav = activenav.Trim().ToLower();
            checknav = checknav.Trim().ToLower();

            return activenav == checknav ? "active" : "";
        }


    }
}
