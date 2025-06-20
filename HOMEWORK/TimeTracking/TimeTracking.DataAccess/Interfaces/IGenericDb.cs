namespace TimeTracking.DataAccess.Interfaces
{
    public interface IGenericDb<T>
    {
        List<T> GetAll();
        T GetById(int id);
        List<T> FilterBy(Func<T, bool> filter);
        void Add(T item);
        bool Update(T item);
        void RemoveById(int id);
    }
}
