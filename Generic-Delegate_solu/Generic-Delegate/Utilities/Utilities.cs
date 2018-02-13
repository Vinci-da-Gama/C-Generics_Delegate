using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Delegate.Utilities
{
    /* This utilities is about Type <T> constrains --> There are 5 types constrains:
    where T: IComparable (IinterfaceB
    where T: Product (class)
    where T: struct (value)
    where T: class (anonymous class)
    where T: new() (this could be any, very flexibile) */
    public class Utilities<T> where T: IComparable, new()
    {
        public int Max (int a, int b)
        {
            return a>b? a : b;
        }

        public void DoSth(T value)
        {
            var obj = new T();
        }

        public T Max (T a, T b)
        {
            return a.CompareTo(b) > 0? a : b;
        }
    }
}
