using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Delegate.DelegateClasses
{
    internal class PhotoProcessor
    {
        // Normal way apply filter
        /* public void ProcessPhoto(string photoPath)
        {
            Photo NewPhoto = new Photo(photoPath);
            PhotoFilters pf = new PhotoFilters();

            pf.ApplyBrightness(NewPhoto);
            pf.ApplyConstrast(NewPhoto);
            pf.Resize(NewPhoto);

            NewPhoto.SavePhoto();
        } */

        // Delegate Way to do Filter
        /* public delegate void PhotoFilterDelegateHandler(Photo photo); */
        // In C# we have 2 build-in Delegate System.Action<T> and System.Func<T>,
        // Now Let's take System.Action<T> as example

        public void PhotoProcess(string photoPath, Action<Photo> filters)
        {
            Photo NewPhoto = Photo.Load(photoPath);
            filters(NewPhoto);

            NewPhoto.SavePhoto();
        }



    }
}
