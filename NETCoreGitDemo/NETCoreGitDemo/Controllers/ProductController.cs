using System;
using Microsoft.AspNetCore.Mvc;

namespace NETCoreGitDemo.Controllers
{
    [Route("api/product")]
    public class ProductController : Controller
    {

        [HttpGet()]
        public IActionResult GetProducts()
        {

            return Content("hello APi !");
        }

        [HttpGet("{id}")]
        public IActionResult GetProduct(int id)
        {

            return Content($"hello APi id为{id} !");
        }

    }
}
