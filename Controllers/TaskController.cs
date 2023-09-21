using AutoMapper;
using backend.Core.Context;
using backend.Core.Dtos.Task;
using backend.Core.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TaskController : Controller
    {
        private ApplicationDbContext _context { get; }
        private IMapper _mapper { get; }

        public TaskController(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }


        // CRUD 

        // Create
        [HttpPost]
        [Route("Create")]
        public async Task<IActionResult> CreateTask([FromBody] TaskCreateDto dto)
        {
            var newTask = _mapper.Map<Core.Entities.Task>(dto);
            await _context.Tasks.AddAsync(newTask);
            await _context.SaveChangesAsync();

            return Ok("Task Created Successfully");
        }

        // Read
        [HttpGet]
        [Route("Get")]
        public async Task<ActionResult<IEnumerable<TaskGetDto>>> GetTasks()
        {
            var tasks =await  _context.Tasks.ToListAsync();
            var convertdTasks = _mapper.Map<IEnumerable<TaskGetDto>>(tasks);

            return Ok(convertdTasks);
        }
    }
}
