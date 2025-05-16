using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

[Route("api/[controller]")]
[ApiController]
public class ProductController : ControllerBase
{
    private static readonly List<string> Products = new List<string> { "Laptop", "Phone", "Tablet" };

    [HttpGet]
    public IActionResult GetProducts()
    {
        return Ok(Products);
    }

    [HttpPost]
    public IActionResult AddProduct([FromBody] string product)
    {
        Products.Add(product);
        return Ok();
    }
}