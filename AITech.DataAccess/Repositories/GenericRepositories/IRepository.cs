using AITech.Entity.Entities.Common;

namespace AITech.DataAccess.Repositories.GenericRepositories
{
    public interface IRepository<TEntity> where TEntity : BaseEntity
    {
        Task<List<TEntity>> GetAllAsync();//Listeye göre 

        Task<TEntity> GetByIdAsync(int id);//Tek bir değer

        Task CreateAsync(TEntity entity);

        void Update(TEntity entity);

        void Delete(TEntity entity);

    }
}