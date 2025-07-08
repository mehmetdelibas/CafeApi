using CafeApi.WebApi.Context;
using CafeApi.WebApi.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CafeApi.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CatogoriesController : ControllerBase
    {
        private readonly ApiContext _context;

        public CatogoriesController(ApiContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult CatagoryList()
        {
            var values = _context.Catagories.ToList();
            return Ok(values);
        }

        [HttpPost]
        public IActionResult CreateCatagory(Catagory catagory)
        {
            _context.Catagories.Add(catagory);
            _context.SaveChanges();
            return Ok("Katagori eklendi");
        }

        [HttpDelete]
        public IActionResult DeleteCatagory(int id)
        {
            var values = _context.Catagories.Find(id);
            _context.Catagories.Remove(values);
            _context.SaveChanges();
            return Ok("Silindi");
        }

        [HttpGet("GetByIdCatagory")]
        public IActionResult GetByIdCatagory(int id)
        {
            var values = _context.Catagories.Find(id);
            return Ok(values);
        }

        [HttpPut]
        public IActionResult UpdateCatagory(Catagory catagory)
        {
            _context.Catagories.Update(catagory);
            _context.SaveChanges();
            return Ok("Katagori güncellendi");
        }
    }
}
