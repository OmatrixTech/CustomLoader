using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Threading;
using WPF.CustomControls.LoadEase;
using WPF.CustomControls.LoadEase.Utility;

namespace WpfCustomLoaderTesting
{
    public class MainWindowViewModel
    {
        ICustomLoaderService customLoaderService=null;
        DispatcherTimer timer = null;
        public MainWindowViewModel(ICustomLoaderService customLoaderService)
        {
            this.customLoaderService = customLoaderService;
            timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(20); // Adjust the interval as needed
            timer.Tick += Timer_Tick;
            timer.Start();
            //customLoaderService.ShowLoader();
            LoaderHandler.ShowLoader();
        }
        
        private void Timer_Tick(object sender, EventArgs e)
        {
            //customLoaderService.HideLoader();
            LoaderHandler.HideLoader();
        }
    }
}
