using Sportsman.Data.Dto;
using System.Threading.Tasks;

namespace Sportsman.Services
{
    public interface ITeamService
    {
        Task<TeamDto> Get(int id);

        Task<int> Create(TeamDto teamDto);

        Task<int> Update(TeamDto teamDto);

        Task Delete(int id);
    }
}
