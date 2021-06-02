using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Sportsman.Data;
using Sportsman.Data.Dto;

namespace Sportsman.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SportController : ControllerBase
    {
        private readonly SportsmansDbContext _sportsmanDbContext;

        public SportController(SportsmansDbContext sportsmanDbContext)
        {
            _sportsmanDbContext = sportsmanDbContext;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> ById(int id)
        {
            return Ok(await _sportsmanDbContext.Sports.FirstOrDefaultAsync(x => x.Id == id));
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await _sportsmanDbContext.Sports.Select(x => new SportDto(x.Id, x.Name)).ToListAsync());
        }
    }
}