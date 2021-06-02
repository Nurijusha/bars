using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Sportsman.Data.Dto;
using Sportsman.Services;

namespace Sportsman.Controllers
{
    [ApiController]
    [Authorize(AuthenticationSchemes = "Bearer")]
    [Route("[controller]")]
    public class SportsmanController : ControllerBase
    {
        private readonly ISportsmanService _sportsmanService;

        public SportsmanController(ISportsmanService sportsmanService)
        {
            _sportsmanService = sportsmanService;
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
            var sportsmanDto = await _sportsmanService.Get(id);
            return Ok(new {Success = true, Sportsman = sportsmanDto});
        }

        /// <summary>
        /// Получение списка спортсменов
        /// </summary>
        /// <returns>Список спортсменов</returns>
        [HttpGet]
        [Route(nameof(List))]
        public async Task<IActionResult> List()
        {
            return Ok(await _sportsmanService.List());
        }

        /// <summary> 
        /// Добавление спортсмена.
        /// </summary>
        /// <param name="sportsmanDto">Модель для добавления.</param>
        /// <returns>Идентификатор добавленного спортсмена</returns>
        [HttpPost]
        [Route(nameof(Create))]
        [Produces("application/json")]
        public async Task<IActionResult> Create(SportsmanDto sportsmanDto)
        {
            return Ok(new {Success = true, SportsmanId = await _sportsmanService.Create(sportsmanDto)});
        }

        /// <summary> 
        /// Добавление спортсмена.
        /// </summary>
        /// <param name="sportsmanDto">Модель для обновления.</param>
        /// <returns>Идентификатор обновления спортсмена.</returns>
        [HttpPost]
        [Route(nameof(Update))]
        [Produces("application/json")]
        public async Task<IActionResult> Update(SportsmanDto sportsmanDto)
        {
            return Ok(new {Success = true, SportsmanId = await _sportsmanService.Update(sportsmanDto)});
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
            await _sportsmanService.Delete(id);

            return Ok(new {Success = true});
        }
    }
}