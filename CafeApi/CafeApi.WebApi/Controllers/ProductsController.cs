using AutoMapper;
using CafeApi.WebApi.Context;
using CafeApi.WebApi.Entities;
using FluentValidation;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CafeApi.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly ApiContext _context;
        private readonly IValidator<Product> _validator;

        public ProductsController(ApiContext context, IValidator<Product> validator)
        {
            _context = context;
            _validator = validator;
        }
        [HttpGet]
        public IActionResult ProductList()
        {
            var values = _context.Products.ToList();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult CreateProduct(Product product)
        {
            var validationResult = _validator.Validate(product);
            if (!validationResult.IsValid)
            {
                return BadRequest(validationResult.Errors.Select(x=>x.ErrorMessage));
            }
            else
            {
                _context.Products.Add(product);
                _context.SaveChanges();
                return Ok("Ürün eklendi");
            }
        }
    }
}
