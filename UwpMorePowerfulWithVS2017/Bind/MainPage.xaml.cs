using System;
using UwpMorePowerfulWithVS2017.ViewModels;
using Windows.UI.Xaml.Controls;

namespace UwpMorePowerfulWithVS2017.Bind
{
    public sealed partial class MainPage : Page
    {
        private MainViewModel ViewModel { get; set; }

        public MainPage()
        {
            this.InitializeComponent();
            this.ViewModel = this.Resources["viewmodel"] as MainViewModel;
        }
    }
}