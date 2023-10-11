using API.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TasksController : ControllerBase
    {
        private readonly KanbanDbContext _context;
        public TasksController(KanbanDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<API.Entities.Task>>> GetTasks() // Use the fully qualified name
        {
            return await _context.Tasks.ToListAsync();
        }
    }
}
