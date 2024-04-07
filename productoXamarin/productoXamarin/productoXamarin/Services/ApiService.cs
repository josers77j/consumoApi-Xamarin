using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using productoXamarin.Models;
using Newtonsoft.Json;

namespace productoXamarin.Services
{
    public class ApiService
    {
        HttpClient client = new HttpClient();

        public async Task<List<Product>> GetProductsAsync()
        {
            var response = await client.GetStringAsync("http://10.0.2.2:5049/api/product/lista");
            var apiResponse = JsonConvert.DeserializeObject<ApiResponse>(response);
            var products = apiResponse.Response;
            Console.WriteLine(products);
            return products;
        }

    }
}
