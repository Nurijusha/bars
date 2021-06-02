using Sportsman.Data.Dto;
using System.Collections.Generic;
using System.Threading.Tasks;
namespace Sportsman.Services
{
    public interface ISportsmanService
    {
        Task<SportsmanDto[]> Get(int id);

        Task<IEnumerable<SportsmanDto>> List();
        
        Task<int> Create(SportsmanDto sportsmanDto);

        Task<int> Update(SportsmanDto sportsmanDto);

        Task Delete(int id);
    }
}
