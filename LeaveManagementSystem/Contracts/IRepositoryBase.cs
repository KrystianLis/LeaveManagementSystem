using System.Collections.Generic;

namespace LeaveManagementSystem.Contracts
{
    public interface IRepositoryBase<T> where T : class
    {
        ICollection<T> FindAll();

        T FindById(int id);

        bool Create(T entity);

        bool IsExists(int id);

        bool Update(T entity);

        bool Delete(T entity);

        bool Save();
    }
}
