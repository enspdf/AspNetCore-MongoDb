using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using miapp2.Models;

namespace miapp2.Controllers
{
    [Route("api/[controller]")]
    public class ProductosController : Controller
    {
        [HttpGet]
        public IEnumerable<Producto> GetAll()
        {
            ProductoDAL dal = new ProductoDAL();
            var productos = dal.Todos();

            return productos;
        }
    }
}