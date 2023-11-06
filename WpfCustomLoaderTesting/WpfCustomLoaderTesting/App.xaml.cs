using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using WPF.CustomControls.LoadEase;

namespace WpfCustomLoaderTesting
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static ServiceProvider serviceProvider = null;
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            // Create a service collection
            var services = new ServiceCollection();
           
            // Register your services
            services.AddSingleton<ICustomLoaderService, CustomLoaderService>();
            services.AddTransient<MainWindowViewModel>();
            serviceProvider = services.BuildServiceProvider();
        }
    }
}
