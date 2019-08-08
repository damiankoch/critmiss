using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ArmyViewer.Web.Utilities
{
    public class Account
    {
        public static string GetUserId()
        {
            return HttpContext.Current.User.Identity.GetUserId();
        }
        public static string GetUserName()
        {
            return HttpContext.Current?.User.Identity.Name;
        }

    }
}