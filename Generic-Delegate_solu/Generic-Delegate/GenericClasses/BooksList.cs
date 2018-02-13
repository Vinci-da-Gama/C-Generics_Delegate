using System;

namespace Generic_Delegate.GenericClasses
{
    public class BooksList
    {
        public Book this[int index]
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public void Add (Book book)
        {
            throw new NotImplementedException();
        }
    }

    public class GenericDictionary<Tkey, Tvalue>
    {
        public void Add(Tkey key, Tvalue value)
        {
        }
    }

    public class GenericList<T>
    {
        public void Add(T value) {

        }
        public T this[int index] {
            get {
                throw new NotImplementedException();
            }
        }
    }
}
