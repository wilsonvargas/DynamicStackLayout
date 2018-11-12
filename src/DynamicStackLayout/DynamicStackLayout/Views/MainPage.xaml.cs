using DynamicStackLayout.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace DynamicStackLayout.Views
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            BindingContext = vm = new MainPageViewModel();
            InitializeComponent();
        }

        private MainPageViewModel vm;
    }
}
