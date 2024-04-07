using productoXamarin.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace productoXamarin
{
    public class ApiResponse
    {
        public string Mensaje { get; set; }
        public List<Product> Response { get; set; }
    }
}
