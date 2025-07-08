using AutoMapper;
using CafeApi.WebApi.Context;
using CafeApi.WebApi.DTOs.ProductDTOs;
using CafeApi.WebApi.Entities;
using FluentValidation;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;

namespace CafeApi.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly ApiContext _context;
        private readonly IValidator<Product> _validator;
        private readonly IMapper _mapper;

        public ProductsController(ApiContext context, IValidator<Product> validator, IMapper mapper)
        {
            _context = context;
            _validator = validator;
            _mapper = mapper;
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
                return BadRequest(validationResult.Errors.Select(x => x.ErrorMessage));
            }
            else
            {
                _context.Products.Add(product);
                _context.SaveChanges();
                return Ok("Ürün eklendi");
            }

        }
        [HttpDelete]
        public IActionResult DeleteProduct(int id)
        {
            var value = _context.Products.Find(id);
            _context.Products.Remove(value);
            _context.SaveChanges();
            return Ok("Silindi");
        }
        [HttpGet("GetByIdProduct")]
        public IActionResult GetByIdProduct(int id)
        {
            var values = _context.Products.Find(id);
            return Ok(values);
        }
        [HttpPut]
        public IActionResult UpdateProduct(Product product)
        {
            var validationResult = _validator.Validate(product);
            if (!validationResult.IsValid)
            {
                return BadRequest(validationResult.Errors.Select(x => x.ErrorMessage));
            }
            else
            {
                _context.Products.Update(product);
                _context.SaveChanges();
                return Ok("Ürün güncellendi");
            }
        }
        [HttpPost("CreateProductWithCatagory")]
        public IActionResult CreateProductWithCatagory(CreateProductDTO createProductDTO)
        {
            var value = _mapper.Map<Product>(createProductDTO);
            _context.Products.Add(value);
            _context.SaveChanges();
            return Ok("Ekleme başarılı");
        }
        [HttpGet("ProductListWithCatagory")]
        public IActionResult ProductListWithCatagory()
        {
            var value = _context.Products.Include(x => x.Catagory).ToList();
            return Ok(_mapper.Map<List<ResultProductWithCatagoryDTO>>(value));
        }

    }
}
