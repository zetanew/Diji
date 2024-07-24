using Microsoft.AspNetCore.Mvc;
using Diji.Data;
using Diji.Models; 
using Microsoft.EntityFrameworkCore; 
using System.Collections.Generic; 

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