using productoXamarin.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace productoXamarin
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            var viewModel = new ProductViewModel();
            BindingContext = viewModel;

            LoadDataAsync(viewModel);
        }
        private async void LoadDataAsync(ProductViewModel viewModel)
        {
            await viewModel.GetProductsAsync();
        }
    }
}
