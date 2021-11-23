using System.Collections.Generic;

namespace JewelleryStore.AppSettings
{
    public interface IGenericRepository<T> where T : class
    {
        IEnumerable<T> getAll();
        T getById(int Id);
        int insert();
        int update(int Id);
        int delete(int Id);
    }
}
