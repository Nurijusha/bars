using System.Threading.Tasks;
using Sportsman.Services;
using Microsoft.AspNetCore.Mvc;
using Sportsman.Data.Dto;

namespace Sportsman.Controllers
{
    [Route("Team")]
    [ApiController]
    public class TeamController : ControllerBase
    {
        private readonly ITeamService _teamService;

        public TeamController(ITeamService teamService)
        {
            _teamService = teamService;
        }

        /// <summary>
        /// Получение спортсмена по идентификатору.
        /// </summary>
        /// <param name="id">Идентификатор спортсмена.</param>
        /// <returns>Модель спортсмена.</returns>
        [HttpGet]
        [Route(nameof(Get))]
        public async Task<IActionResult> Get(int id)
        {
            var TeamDto = await _teamService.Get(id);
            return Ok(new { Success = true, Team = TeamDto });
        }

        /// <summary>
        /// Добавление спортсмена.
        /// </summary>
        /// <param name="TeamDto">Модель для добавления.</param>
        /// <returns>Идентификатор добавленного спортсмена.</returns>
        [HttpPost]
        [Route(nameof(Create))]
        [Produces("application/json")]
        public async Task<IActionResult> Create(TeamDto TeamDto)
        {
            return Ok(new { Success = true, TeamId = await _teamService.Create(TeamDto) });
        }

        /// <summary>
        /// Обновление спортсмена.
        /// </summary>
        /// <param name="TeamDto">Модель для обновления.</param>
        /// <returns>Идентификатор обновленной спортсмена.</returns>
        [HttpPost]
        [Route(nameof(Update))]
        [Produces("application/json")]
        public async Task<IActionResult> Update(TeamDto TeamDto)
        {
            return Ok(new { Success = true, TeamId = await _teamService.Update(TeamDto) });
        }

        /// <summary>
        /// Удаление спортсмена.
        /// </summary>
        /// <param name="id">Модель для удаления.</param>
        /// <returns>Идентификатор обновленной спортсмена.</returns>
        [HttpPost]
        [Route(nameof(Delete))]
        [Produces("application/json")]
        public async Task<IActionResult> Delete(int id)
        {
            await _teamService.Delete(id);

            return Ok(new { Success = true });
        }
    }
}
