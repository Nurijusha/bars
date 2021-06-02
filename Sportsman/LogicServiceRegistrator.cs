using Microsoft.Extensions.DependencyInjection;
using Sportsman.Services;

namespace Sportsman
{
    public static class LogicServiceRegistrator
    {
        public static IServiceCollection RegisterLogicServices(this IServiceCollection serviceCollection)
        {
            serviceCollection
                .AddTransient<ISportsmanService, SportsmanService>()
                .AddTransient<ITeamService, TeamService>();

            return serviceCollection;
        }
    }
}
