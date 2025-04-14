using Angular_Using_Core_API.Server.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Angular_Using_Core_API.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly MyDbContext _context;
        public CategoryController(MyDbContext context)
        {
            _context = context;
        }
        [HttpGet("AllCategories")]
        public IActionResult Get_Category()
        {
            var categories = _context.Categories.ToList();
            return Ok(categories);
        }

        [HttpGet("FirstCategories")]
        public IActionResult Get_First_Category()
        {
            var FirstCategories = _context.Categories.First();
            return Ok(FirstCategories);
        }

        [HttpGet("OneCategoryBasedOnID")]
        public IActionResult Get_Category_BasedOnID(int id)
        {
            var category = _context.Categories.FirstOrDefault(x => x.CategoryId == id);
            if (category == null)
            {
                return NotFound();
            }
            return Ok(category);
        }

        [HttpGet("OneCategoryBasedOnName")]
        public IActionResult Get_Category_BasedOnName(String Name)
        {
            var category = _context.Categories.FirstOrDefault(x => x.CategoryName == Name);
            if (category == null)
            {
                return NotFound();
            }
            return Ok(category);
        }
       

    }
}
