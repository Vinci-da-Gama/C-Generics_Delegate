using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Delegate.DelegateClasses
{
    internal class Photo
    {
        private string _path { get; set; }
        public Photo(string thePath)
        {
            this._path = thePath; 
        }

        public static Photo Load(string Path)
        {
            return new Photo(Path); 
        }

        public void SavePhoto()
        {
            
        }

    }
}
