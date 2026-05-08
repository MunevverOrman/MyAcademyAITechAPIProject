using AITech.DataAccess.Context;
using AITech.DataAccess.Repositories.GenericRepositories;
using AITech.Entity.Entities;

namespace AITech.DataAccess.Repositories.TeamHeaderRepositories
{
    public class TeamHeaderRepository : GenericRepository<TeamHeader>, ITeamHeaderRepository
    {
        public TeamHeaderRepository(AppDbContext context) : base(context)
        {
        }
    }
}
