using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace DesignPartern
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public App()
        {
            //Register Syncfusion license
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("MzE4NjExQDMxMzgyZTMyMmUzMEhTNStyU2psUG90cmVRSUliNzFOaWJXVFBrcldhQWpGM0xpK2x0SkJBamc9");
        }

    }
}
