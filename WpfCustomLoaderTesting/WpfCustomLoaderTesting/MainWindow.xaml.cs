using Microsoft.Extensions.DependencyInjection;
using System;
using System.Windows;
using System.Windows.Threading;
using WPF.CustomControls.LoadEase.Utility;

namespace WpfCustomLoaderTesting
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 

    //Creating a custom Wait Loader control in Windows Presentation Foundation(WPF) can enhance the user experience by providing visual feedback during time-consuming operations, such as data loading or processing.A Wait Loader is essentially an animated progress indicator that indicates to the user that something is happening in the background. It is a very simple solution which can be used to resolve WaitWindow issue in wpf.
    public partial class MainWindow : Window
    {
        DispatcherTimer timer = null;
        public MainWindow()
        {
            InitializeComponent();
            var mainViewModel = App.serviceProvider.GetRequiredService<MainWindowViewModel>();
            this.DataContext = mainViewModel;
            timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(20); // Adjust the interval as needed
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            LoaderHandler.HideLoader();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            LoaderHandler.ShowLoader();
        }
    }
}
