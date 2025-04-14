using Angular_Using_Core_API.Server.DTOs;
using Angular_Using_Core_API.Server.IDataService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Angular_Using_Core_API.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductControllerUsingTierArchitecture : ControllerBase
    {
        private readonly IDataServicee _data;

        public ProductControllerUsingTierArchitecture(IDataServicee data)
        {
            _data = data;
        }
        [HttpGet("AllProducts")]
        public IActionResult Get_Product()
        {
            var AllProducts = _data.Get_Product();
            return Ok(AllProducts);
        }



        [HttpGet("FirstProduct")]
        public IActionResult Get_First_Product()
        {
            var FirstProduct = _data.Get_First_Product();
            return Ok(FirstProduct);
        }

        [HttpGet("OneProductBasedOnID/{id}")]
        public IActionResult Get_Product_BasedOnID(int id)
        {
            var Product = _data.Get_Product_BasedOnID(id);
            if (Product == null)
            {
                return NotFound();
            }
            return Ok(Product);
        }

        [HttpGet("OneProductBasedOnName/{name}")]
        public IActionResult Get_Product_BasedOnName(string name)
        {
            var Product = _data.Get_Product_BasedOnName(name);
            if (Product == null)
            {
                return NotFound();
            }
            return Ok(Product);
        }

        [HttpDelete("DeleteOneProductBasedOnID/{id}")]
        public IActionResult DeleteProduct(int id)
        {

            var Product = _data.DeleteProduct(id); // var ==> int , bool , string 
            if (Product == true)
            {

                return NoContent();
            }

            return NotFound();

        }

        [HttpPost("AddNewProduct")]
        public IActionResult AddProduct([FromBody] ProductDTOs productData)
        {

            bool IsAdded = _data.AddProduct(productData);
            if (IsAdded == false)
                return BadRequest();
            else
                return StatusCode(201, productData);

        }

        [HttpPut("EditProduct/{id}")]
        public IActionResult EditProduct(int id, [FromBody] ProductDTOs productData)
        {
            bool IsEdited = _data.EditProduct(id, productData);
            if (IsEdited == false)
                return BadRequest();
            else
                return StatusCode(201, productData);
        }
    }
}
