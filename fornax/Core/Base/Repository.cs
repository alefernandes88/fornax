using System.Collections.Generic;

namespace fornax.Core.Base
{
    public  abstract class Repository <T>
    {
        public abstract void create(T data);
        public abstract void update(int id, T data);
        public abstract T get(int id);
        public abstract void delete(int id);
        public abstract List<T> getAll();
    }
}
