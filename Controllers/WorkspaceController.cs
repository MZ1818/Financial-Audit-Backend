using AutoMapper;
using backend.Core.Context;
using backend.Core.Dtos.Workspace;

using backend.Core.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WorkspaceController : Controller
    {

        private ApplicationDbContext _context { get; }
        private IMapper _mapper { get; }

        public WorkspaceController(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }



        // Create
        [HttpPost]
        [Route("Create")]
        public async Task<IActionResult> CreateWorkspace([FromBody] WorkspaceCreateDto dto)
        {
            Workspace newWorkspace = _mapper.Map<Workspace>(dto);
            await _context.Workspaces.AddAsync(newWorkspace);
            await _context.SaveChangesAsync();

            return Ok("Workspace Created Successfully");
        }

        // Read
        [HttpGet]
        [Route("Get")]
        public async Task<ActionResult<IEnumerable<WorkspaceGetDto>>> GetWorkspaces()
        {
            var workspaces = await _context.Workspaces.ToListAsync();
            var convertedWorkspaces = _mapper.Map<IEnumerable<WorkspaceGetDto>>(workspaces);

            return Ok(convertedWorkspaces);
        }

        [HttpGet]
        [Route("GetNumberOfTasks")]
        public long getNumberOfNotes(long WorkspaceId)
        {
            var count = _context.Tasks.Where(x => x.WorkspaceId == WorkspaceId).Count();
            return count;
        }


    }
}
