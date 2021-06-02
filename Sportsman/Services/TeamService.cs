using Microsoft.EntityFrameworkCore;
using Sportsman.Data;
using Sportsman.Data.Dto;
using Sportsman.Data.Models;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Sportsman.Services
{
    public class TeamService : ITeamService
    {
        private readonly SportsmansDbContext _sportsmansDbContext;

        public TeamService(SportsmansDbContext sportsmansDbContext)
        {
            _sportsmansDbContext = sportsmansDbContext ?? throw new ArgumentNullException(nameof(sportsmansDbContext));
        }

        public async Task<TeamDto> Get(int id)
        {
            return await _sportsmansDbContext.Teams
                .Where(x => x.Id == id)
                .Select(x => new TeamDto
                {
                    Id = x.Id,
                    Name = x.Name,
                    Sport = x.Sport
                })
                .FirstOrDefaultAsync();
        }

        public async Task<int> Create(TeamDto sportsmanDto)
        {
            Team sportsman = new Team();

            AplyDtoToEntity(sportsman, sportsmanDto);

            _sportsmansDbContext.Teams.Add(sportsman);
            await _sportsmansDbContext.SaveChangesAsync();

            return sportsman.Id;
        }

        public async Task<int> Update(TeamDto sportsmanDto)
        {
            Team sportsman = _sportsmansDbContext.Teams.Find(sportsmanDto.Id);

            AplyDtoToEntity(sportsman, sportsmanDto);

            await _sportsmansDbContext.SaveChangesAsync();

            return sportsman.Id;
        }

        public async Task Delete(int id)
        {
            Team team = _sportsmansDbContext.Teams.Find(id);

            _sportsmansDbContext.Teams.Remove(team);
            await _sportsmansDbContext.SaveChangesAsync();
        }

        private void AplyDtoToEntity(Team team, TeamDto teamDto)
        {
            team.Name = teamDto.Name;
            team.Sport = teamDto.Sport;
        }
    }
}
