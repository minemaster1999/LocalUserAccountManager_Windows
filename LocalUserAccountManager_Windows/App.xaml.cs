using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Security.Principal;
using System.Security.Claims;

namespace LocalUserAccountManager_Windows
{
    /// <summary>
    /// Logika interakcji dla klasy App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static bool _withAdminRights;

        protected override void OnStartup(StartupEventArgs e)
        {
            ClaimsPrincipal wi = WindowsPrincipal.Current;

            _withAdminRights = wi.IsInRole("Administrator");
        }
    }
}
