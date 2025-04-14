using Angular_Using_Core_API.Server.DTOs;
using Angular_Using_Core_API.Server.Models;
using Microsoft.AspNetCore.Mvc;
namespace Angular_Using_Core_API.Server.IDataService
{
    public interface IDataServicee
    {
        public List<Category> getCategories();
        public Category Get_First_Category();
        public Category? Get_Category_BasedOnID(int id);
        public Category? Get_Category_BasedOnName(string Name);
        public bool DeleteCategory(int id);
        public bool AddCategory(CategoryDTOs CategoryData);
        public bool EditCategory(int id, [FromBody] CategoryDTOs categoryData);


        public List<Product> Get_Product();
        public Product Get_First_Product();
        public Product? Get_Product_BasedOnID(int id);
        public Product? Get_Product_BasedOnName(string name);
        public bool DeleteProduct(int id);
        public bool AddProduct(ProductDTOs ProductData);
        public bool EditProduct(int id, [FromBody] ProductDTOs productData);


    }
}

