using Microsoft.AspNetCore.Mvc;
using Diji.Data;
using Diji.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq; // Add this for LINQ queries

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

        // GET: api/Jobs?stateId=1
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Job>>> GetJobs(int? stateId)
        {
            IQueryable<Job> query = _context.Jobs;

            if (stateId.HasValue)
            {
                query = query.Where(j => j.StateId == stateId);
            }

            return await query.ToListAsync();
        }
    }
}