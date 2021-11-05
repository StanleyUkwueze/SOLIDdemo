using System;
namespace APPDataAccess
{
    public interface ICRUDRepository
    {
        bool Add<T>(T entity);
        string Update<T>(T entity);
        string Delete<T>(T entity);
        int RowCount();
    }
}
