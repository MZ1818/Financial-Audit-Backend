using AutoMapper;
using backend.Core.Context;
using backend.Core.Dtos.Notes;
using backend.Core.Dtos.Task;
using backend.Core.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace backend.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class NotesController : Controller
    {

        private ApplicationDbContext _context { get; }
        private IMapper _mapper { get; }

        public NotesController(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        // CRUD 

        // Create
        [HttpPost]
        [Route("Create")]
        public async Task<IActionResult> CreateNotes([FromBody] NotesCreateDto dto)
        {
            var newNotes = _mapper.Map<Notes>(dto);
            await _context.Notess.AddAsync(newNotes);
            await _context.SaveChangesAsync();

            return Ok("Notes Created Successfully");
        }

        // Read
        [HttpGet]
        [Route("Get")]
        public async Task<ActionResult<IEnumerable<NotesGetDto>>> GetNotess()
        {
            var notess = await _context.Notess.ToListAsync();
            var convertdNotess = _mapper.Map<IEnumerable<NotesGetDto>>(notess);

            return Ok(convertdNotess);
        }
    }
}