using Angular_Using_Core_API.Server.DTOs;
using Angular_Using_Core_API.Server.IDataService;
using Angular_Using_Core_API.Server.Models;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace Angular_Using_Core_API.Server.DataService
{
    public class DataServicee : IDataServicee
    {
        private readonly MyDbContext _context;
        public DataServicee(MyDbContext context)
        {
            _context = context;
        }
        public List<Category> getCategories()
        {
            var Categories = _context.Categories.ToList();
            return Categories;
        }
        public Category Get_First_Category()
        {
            var FirstCategories = _context.Categories.First();
            return FirstCategories;
        }

        public Category? Get_Category_BasedOnID(int id)
        {
            var category = _context.Categories.FirstOrDefault(x => x.CategoryId == id);
            if (category == null)
            {
                return null;
            }
            return category;
        }

        public Category? Get_Category_BasedOnName(String Name)
        {
            var category = _context.Categories.FirstOrDefault(x => x.CategoryName == Name);
            if (category == null)
            {
                return null;
            }
            return category;
        }
        public bool DeleteCategory(int id)
        {

            var category = _context.Categories.FirstOrDefault(x => x.CategoryId == id);
            if (category != null)
            {
                _context.Categories.Remove(category);
                _context.SaveChanges();
                return true;


            }

            return false;
        }

        public bool AddCategory(CategoryDTOs CategoryData) 
        {
            var NewCategory = new Category
            {
                CategoryDesc = CategoryData.CategoryDesc,
                CategoryName = CategoryData.CategoryName
            };
            _context.Categories.Add(NewCategory);
            _context.SaveChanges();
            return true;
        }

        public bool EditCategory(int id, [FromBody] CategoryDTOs categoryData) 
        { 
         var UpdateCategory = _context.Categories.FirstOrDefault(x => x.CategoryId == id);
            if (UpdateCategory != null)
            {
                UpdateCategory.CategoryName = categoryData.CategoryName;
                UpdateCategory.CategoryDesc = categoryData.CategoryDesc;
                _context.SaveChanges();
                return true;
            }
            return false;
        }


























        public List<Product> Get_Product()
        {
            var products = _context.Products.ToList();
            return products;
        }
        public Product Get_First_Product()
        {
            var FirstProduct = _context.Products.First();
            return FirstProduct;
        }

        public Product? Get_Product_BasedOnID(int id)
        {
            var product = _context.Products.FirstOrDefault(x => x.ProductId == id);
            if (product == null)
            {
                return null;
            }
            return product;
        }

        public Product? Get_Product_BasedOnName(string Name)
        {
            var product = _context.Products.FirstOrDefault(x => x.ProductName == Name);
            if (product == null)
            {
                return null;
            }
            return product;
        }
        public bool DeleteProduct(int id)
        {

            var product = _context.Products.FirstOrDefault(x => x.ProductId == id);
            if (product != null)
            {
                _context.Products.Remove(product);
                _context.SaveChanges();
                return true;


            }

            return false;
        }

        public bool AddProduct(ProductDTOs ProductData)
        {
            var NewProduct = new Product
            {
                ProductName = ProductData.ProductName,
                ProductDesc = ProductData.ProductDesc
            };
            _context.Products.Add(NewProduct);
            _context.SaveChanges();
            return true;
        }

        public bool EditProduct(int id, [FromBody] ProductDTOs ProductData)
        {
            var UpdateProduct = _context.Products.FirstOrDefault(x => x.ProductId == id);
            if (UpdateProduct != null)
            {
                UpdateProduct.ProductName = ProductData.ProductName;
                UpdateProduct.ProductDesc = ProductData.ProductDesc;
                _context.SaveChanges();
                return true;
            }
            return false;
        }







    }
}
