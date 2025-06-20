using TimeTracking.DataAccess.Interfaces;
using TimeTracking.Domain.Models;

namespace TimeTracking.DataAccess.Abstractions
{
    public class GenericDb<T> : IGenericDb<T> where T : BaseEntity
    {
        private readonly List<T> _items = new List<T>();
        private int _idCounter = 1;

        public List<T> GetAll()
        {
            return _items.ToList();
        }

        public T GetById(int id)
        {
            return _items.FirstOrDefault(x => x.Id == id);
        }

        public List<T> FilterBy(Func<T, bool> filter)
        {
            return _items.Where(filter).ToList();
        }

        public void Add(T item)
        {
            item.Id = _idCounter++;
            _items.Add(item);
        }

        public bool Update(T item)
        {
            var index = _items.FindIndex(x => x.Id == item.Id);
            if (index == -1) return false;
            _items[index] = item;
            return true;
        }

        public void RemoveById(int id)
        {
            var item = GetById(id);
            if (item != null) _items.Remove(item);
        }
    }
}
