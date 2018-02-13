using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Delegate.GenericClasses
{
    public class Nullable<T> where T: struct
    {
        private object _val;
        public Nullable() {
        }
        public Nullable(T val)
        {
            _val = val;
        }
        /* private string _myVar;
        public string MyProperty
        {
            get { return _myVar;}
            set { _myVar = value;}
        } */

        public bool HasValue {
            get {
                return this._val != null;
            }
        }

        public T GetValueOrDefaultValue()
        {
            if (HasValue)
            {
                return (T)this._val;
            }
            else
            {
                return default(T);
            }
        }

    }
}
