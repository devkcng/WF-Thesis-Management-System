using System.Linq;

namespace WFThesisManagementSystem.Repositories
{   
    //this is the interface for the repository classes
    public interface IRepository<T>
    {
        IQueryable<T> GetAll();
        T GetById(int id);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}