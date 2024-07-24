using Microsoft.AspNetCore.Mvc;
using Diji.Data; // Import the namespace where ApplicationDbContext is located
using Diji.Models; // Import the namespace for accessing the State model
using Microsoft.EntityFrameworkCore; // For using Include and other EF methods
using System.Collections.Generic; // For using List
using System.Threading.Tasks; // For using Task

namespace Diji.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StatesController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public StatesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/States
        [HttpGet]
        public async Task<ActionResult<IEnumerable<State>>> GetStates()
        {
            return await _context.States.ToListAsync();
        }
    }
}