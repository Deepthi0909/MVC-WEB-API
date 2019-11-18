using MVCWithWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;

namespace MVCWithWebApi.Controllers
{
    public class ProductCategoryController : ApiController
    {
        private NorthwindEntities1 db = new NorthwindEntities1();
        // GET: api/ProductCategory
        public IQueryable<Category> GetCategories()
        {
            return db.Categories;
        }


        [ResponseType(typeof(Category))]
        public IHttpActionResult GetProductsByCategory(int id)
        {
            if (id < 0 || id > 8)
                return BadRequest("Something went wrong");
            NorthwindEntities entities = new NorthwindEntities();
            var query = from c in entities.Products
                        where c.CategoryID == id
                        select c;
            return Ok(query);
        }


        
    }
}
