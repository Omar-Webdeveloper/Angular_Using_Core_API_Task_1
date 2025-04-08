using Angular_Using_Core_API.Server.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Angular_Using_Core_API.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly MyDbContext _context;
        public ProductController(MyDbContext context)
        { 
         _context = context;
        }

        [HttpGet("AllProduct")]
        public IActionResult Get_Product()
        {
            var AllProduct = _context.Products.ToList();
            return Ok(AllProduct);
        }
        [HttpGet("FirstProduct")]
        public IActionResult Get_First_Product()
        {
            var FirstProduct = _context.Products.First();
            return Ok(FirstProduct);
        }
        [HttpGet("OneProductBasedOnID")]
        public IActionResult Get_Product_BasedOnID(int id)
        { 
         var ShowProductBasedOnID = _context.Products.FirstOrDefault(u => u.ProductId == id);
            if (ShowProductBasedOnID == null)
            {
                return NotFound();
            }
            return Ok(ShowProductBasedOnID);
        }

        [HttpGet("OneProductBasedOnName")]
        public IActionResult Get_Product_BasedOnName(string Name)
        {
            var ShowProductBasedOnName = _context.Products.FirstOrDefault(name => name.ProductName == Name);
            if (ShowProductBasedOnName == null)
            {
                return NotFound();
            }
            return Ok(ShowProductBasedOnName);
        } 
            
            


    }
}
