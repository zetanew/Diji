using Microsoft.AspNetCore.Mvc;
using Diji.Data; // Import the namespace where ApplicationDbContext is located
using Diji.Models; // Import the namespace for accessing the Job model
using Microsoft.EntityFrameworkCore; // For using Include and other EF methods
using System.Collections.Generic; // For using List

namespace Diji.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class JobsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public JobsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Jobs
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Job>>> GetJobs()
        {
            return await _context.Jobs.ToListAsync();
        }
    }
}