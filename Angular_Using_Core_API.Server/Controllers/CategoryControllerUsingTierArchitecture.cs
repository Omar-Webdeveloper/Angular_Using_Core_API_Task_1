using Angular_Using_Core_API.Server.DTOs;
using Angular_Using_Core_API.Server.IDataService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;

namespace Angular_Using_Core_API.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryControllerUsingTierArchitecture : ControllerBase
    {
        private readonly IDataServicee _data;

        public CategoryControllerUsingTierArchitecture(IDataServicee data)
        {
            _data = data;
        }
        //[HttpGet("Get_Method-All-Categories")]
        [HttpGet]

        [Route("All-Categories")]
        public IActionResult Get_Category()
        {
            var categories = _data.getCategories();
            return Ok(categories);
        }



        [HttpGet("FirstCategories")]
        public IActionResult Get_First_Category()
        {
            var FirstCategories = _data.Get_First_Category(); 
            return Ok(FirstCategories);
        }

        [HttpGet("OneCategoryBasedOnID/{id}")]
        public IActionResult Get_Category_BasedOnID(int id)
        {
            var category = _data.Get_Category_BasedOnID( id);
            if (category == null)
            {
                return NotFound();
            }
            return Ok(category);
        }

        [HttpGet("OneCategoryBasedOnName/{name}")]
        public IActionResult Get_Category_BasedOnName(string name)
        {
            var category = _data.Get_Category_BasedOnName( name);
            if (category == null)
            {
                return NotFound();
            }
            return Ok(category);
        }

        [HttpDelete("DeleteOneCategoryBasedOnID/{id}")]
        public IActionResult DeleteCategory(int id)
        {

            var teacher = _data.DeleteCategory(id); // var ==> int , bool , string 
            if (teacher == true)
            {

                return NoContent();
            }

            return NotFound();

        }

        [HttpPost("AddNewCategory")]
        public IActionResult AddCategory([FromBody] CategoryDTOs categoryData) 
        { 

            bool IsAdded = _data.AddCategory(categoryData);
            if (IsAdded == false)
                return BadRequest();
            else
                return StatusCode(201, categoryData);

        }

        [HttpPut("EditCategory/{id}")]
        public IActionResult EditCategory(int id, [FromBody] CategoryDTOs categoryData) 
        {
            bool IsEdited = _data.EditCategory(id,categoryData);
            if (IsEdited == false)
                return BadRequest();
            else
                return StatusCode(201, categoryData);
        }

    }
}
