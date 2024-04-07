using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using productoApi.Models;
namespace productoApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class productController : ControllerBase
    {
        public readonly StoreContext storeContext;
        public productController(StoreContext context)
        {
            storeContext = context;
        }

        [HttpGet]
        [Route("lista")]
        public IActionResult Lista()
        {
            List<Product> lista = new List<Product>();

            try
            {
                lista = storeContext.Products.ToList();

                return StatusCode(StatusCodes.Status200OK, new { mensaje = "ok", response = lista });
            }
            catch(Exception ex)
            {
                return StatusCode(StatusCodes.Status200OK, new { mensaje = ex.Message, response = lista });
            }
        }
    }
}
