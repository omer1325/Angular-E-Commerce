using System.Collections.Generic;
using System.Threading.Tasks;
using API.Core.DbModels;
using API.Infastructure.DataContext;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AngularE_Commerce.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly StoreContext _context;
        public ProductsController(StoreContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<Product>>> GetPRoducts()
        {
            return await _context.Products.ToListAsync();              
        }
        [HttpGet("{id}")]
        public  ActionResult<Product> GetProduct(int id)
        {
            return _context.Products.Find(id);
        }
    }
}
