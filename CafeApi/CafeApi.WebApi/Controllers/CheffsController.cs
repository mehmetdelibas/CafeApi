using CafeApi.WebApi.Context;
using CafeApi.WebApi.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CafeApi.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CheffsController : ControllerBase
    {
        private readonly ApiContext _context;

        public CheffsController(ApiContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult CheffList()
        {
            var values = _context.Cheffs.ToList();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult CreateCheff(Cheff cheff)
        {
            _context.Cheffs.Add(cheff);
            _context.SaveChanges();
            return Ok("Şef sisteme eklendi");
        }
        [HttpDelete]
        public IActionResult DeleteCheff(int id)
        {
            var values = _context.Cheffs.Find(id);
            _context.Cheffs.Remove(values);
            _context.SaveChanges();
            return Ok("Şef silindi");
        }
        [HttpGet("GetByIdCheff")]
        public IActionResult GetByIdCheff(int id)
        {
            var values = _context.Cheffs.Find(id);
            return Ok(values);
        }
        [HttpPut]
        public IActionResult UpdateCheff(Cheff cheff)
        {
            _context.Cheffs.Update(cheff);
            _context.SaveChanges();
            return Ok("Şef Güncellendi");
        }
    }
}
