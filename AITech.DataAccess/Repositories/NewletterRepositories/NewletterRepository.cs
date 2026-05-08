using AITech.DataAccess.Context;
using AITech.DataAccess.Repositories.GenericRepositories;
using AITech.Entity.Entities;

namespace AITech.DataAccess.Repositories.NewletterRepositories
{
    public class NewletterRepository : GenericRepository<Newsletter>, INewletterRepository
    {
        public NewletterRepository(AppDbContext context) : base(context)
        {
        }
    }
}
