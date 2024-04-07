using productoXamarin.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using productoXamarin.Models;

namespace productoXamarin.ViewModel
{
    public class ProductViewModel : INotifyPropertyChanged
    {
        public ProductViewModel()
        {
            LoadData();
        }

        private async void LoadData()
        {
            await GetProductsAsync();
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private List<Product> _products;
        public List<Product> Products
        {
            get { return _products; }
            set
            {
                _products = value;
                OnPropertyChanged();
            }
        }

        private ApiService _apiService = new ApiService();

        public async Task GetProductsAsync()
        {
            Products = await _apiService.GetProductsAsync();
        }

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
