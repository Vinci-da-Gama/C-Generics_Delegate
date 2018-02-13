using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Delegate.DelegateClasses
{
    internal class PhotoFilters
    {
        public void ApplyBrightness(Photo photo)
        {
            Console.WriteLine("\nApply-Brightness");
        }
        public void ApplyConstrast(Photo photo)
        {
            Console.WriteLine("Apply-Constrast");
        }
        public void Resize(Photo photo)
        {
            Console.WriteLine("Resize");
        }
    }
}
