using AutoMapper;
using CafeApi.WebApi.Context;
using CafeApi.WebApi.DTOs.MessageDTOs;
using CafeApi.WebApi.Entities;
using Microsoft.AspNetCore.Mvc;

namespace CafeApi.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MessagesController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly ApiContext _context;

        public MessagesController(IMapper mapper, ApiContext context)
        {
            _mapper = mapper;
            _context = context;
        }
        [HttpGet]
        public IActionResult MessageList()
        {
            var values = _context.Messages.ToList();
            return Ok(_mapper.Map<List<ResultMessageDTO>>(values));
        }
        [HttpPost]
        public IActionResult CreateMessage(CreateMessageDTO createMessageDTO)
        {
            var value = _mapper.Map<Message>(createMessageDTO);
            _context.Messages.Add(value);
            _context.SaveChanges();
            return Ok("Eklendi");
        }
        [HttpDelete]
        public IActionResult DeleteMessage(int id)
        {
            var value = _context.Messages.Find(id);
            _context.Messages.Remove(value);
            _context.SaveChanges();
            return Ok("Silindi");
        }
        [HttpGet("GetByIdMessage")]
        public IActionResult GetByIdMessage(int id)
        {
            var value = _context.Messages.Find(id);
            return Ok(_mapper.Map<GetByIdMessageDTO>(value));
        }
        [HttpPut]
        public IActionResult UpdateMessage(UpdateMessageDTO updateMessageDTO)
        {
            var value = _mapper.Map<Message>(updateMessageDTO);
            _context.Messages.Update(value);
            _context.SaveChanges();
            return Ok("Güncellendi");
        }
    }

}
