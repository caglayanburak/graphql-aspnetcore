using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using aspnetcoregraphql.Models;
using GraphQL;
using GraphQL.Types;
using GraphqlSample.Models;
using Microsoft.AspNetCore.Mvc;

namespace aspnetcoregraphql.Controllers
{
    [Route("products")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private ApplicationDbContext _context;

        public ProductsController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Test()
        {
            var v1 = _context.V1s.ToList();
            return Ok(v1);
        }

        [HttpPost]
        public async Task<IActionResult> Post()
        {
            var v1 = _context.V1s.FirstOrDefault();
            var v2 = new V2()
            {
                Name = "test"
            };
            _context.V2s.Add(v2);
            v1.CategoryId = v2.Id;
            var result = _context.SaveChanges();
            return Ok(result);
        }

        // [HttpPost]
        // public async Task<IActionResult> Post()
        // {
        //     var v1 = _context.Products.FirstOrDefault();
        //     var v2 = new Category()
        //     {
        //         Name = "test"
        //     };
        //     _context.Categories.Add(v2);
        //     // v1.Category = v2;
        //     v1.CategoryId = v2.Id;
        //     var result = _context.SaveChanges();
        //     return Ok(result);
        // }
    }
}
