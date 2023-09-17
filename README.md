# CustomLoader
The goal of this project is to design and implement a custom loader that can efficiently load and prepare a particular type of data or resource for use by a target application or system. 



****Process to use WaitIwndow in WPF***

1.Install nuget package

"WPF.CustomControls.LoadEase"
 OR Add as a reference of the DLL which is avaolable in project "FontAwesome.WPF.dll", "WPF.CustomControls.LoadEase.dll"
 
2.To Show Loader use the following method
====>LoaderHandler.ShowLoader();

3.To Hide Loader use the following method
====> LoaderHandler.HideLoader();

4.Reference in WPF window form
====> xmlns:WaitWindow="clr-namespace:WPF.CustomControls.LoadEase;assembly=WPF.CustomControls.LoadEase"

5.Example of Load waitwindow on page

<Window x:Class="WpfApp1.MainWindow"
        xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
        xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
        xmlns:d="http://schemas.microsoft.com/expression/blend/2008"
        xmlns:mc="http://schemas.openxmlformats.org/markup-compatibility/2006"
        xmlns:local="clr-namespace:WpfApp1"
        xmlns:WaitWindow="clr-namespace:WPF.CustomControls.LoadEase;assembly=WPF.CustomControls.LoadEase"
        mc:Ignorable="d"
        Title="MainWindow" Height="450" Width="800">
    <WaitWindow:AdornedControl Name="LoadingAdorner">
        <!--Overlay for WaitLoader-->
        <WaitWindow:AdornedControl.AdornerContent>
            <WaitWindow:DynamicPulseLoader ExpectedLoaderHeight="180" ExpectedLoaderWidth="180" LoaderText="Loading.."  LoaderTextColor="OrangeRed"   />
        </WaitWindow:AdornedControl.AdornerContent>
        <Grid>
            <!--Main Content of the application-->
            <TextBlock Text="Demo"/>
        </Grid>
    </WaitWindow:AdornedControl>
</Window>
**************************************************************************************************************

========================CompanyLogoSpinner Example=====================================================
<Window x:Class="TestLoader.MainWindow"
        xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
        xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
        xmlns:d="http://schemas.microsoft.com/expression/blend/2008"
        xmlns:mc="http://schemas.openxmlformats.org/markup-compatibility/2006"
        xmlns:WaitWindow="clr-namespace:WPF.CustomControls.LoadEase;assembly=WPF.CustomControls.LoadEase"
        mc:Ignorable="d"
        Title="MainWindow" Height="450" Width="800">
    <WaitWindow:AdornedControl Name="LoadingAdorner">
        <!--Overlay for WaitLoader-->
        <WaitWindow:AdornedControl.AdornerContent>
            <WaitWindow:CompanyLogoSpinner LoaderBaseColor="Black" LoaderForegroundColor="OrangeRed" LoaderStrokeThickness="12" ImageNameWithAssemblyPath="pack://application:,,,/TestLoader;component/Images/Logo.png" LoaderFontSize="30"  ExpectedLoaderHeight="380" ExpectedLoaderWidth="380" LoaderText="Loading..."  LoaderTextColor="White"   />
        </WaitWindow:AdornedControl.AdornerContent>
        <Grid>
        <!--Main Content of the application-->
            <TextBlock Text="Demo"/>
        </Grid>
    </WaitWindow:AdornedControl>
</Window>


++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++




