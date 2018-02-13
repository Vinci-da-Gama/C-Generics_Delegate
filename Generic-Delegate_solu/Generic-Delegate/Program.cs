using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Generic_Delegate.GenericClasses;
using Generic_Delegate.DelegateClasses;

namespace Generic_Delegate
{
    class Program
    {
        static void Main(string[] args)
        {
            Book csBook = new Book { Isbn = "1212", Title = "C#_Advanced"};

            var numbers = new GenericList<int>();
            numbers.Add(10);
            var books = new GenericList<Book>();
            books.Add(new Book());

            var dict = new GenericDictionary<string, Book>();
            dict.Add("1234", new Book());
            
            var NewNumber = new GenericClasses.Nullable<int>();
            Console.WriteLine("Has Value? "+NewNumber.HasValue);
            Console.WriteLine("The value is: "+NewNumber.GetValueOrDefaultValue());


            string ppath = string.Format("C:\\Users\\Mia\\Desktop\\AspNet_Practice\\Pjs\\C#NextLevel\\c#Generics_Delegate\\Generic-Delegate_solu\\Generic-Delegate\\imgs\\sun.png");
            // Normal way apply filter
            /* PhotoProcessor pp = new PhotoProcessor();
            pp.ProcessPhoto(ppath); */

            // Delegate Way to do Filter
            PhotoFilters pf = new PhotoFilters();
            PhotoProcessor pp = new PhotoProcessor();

            // Apply build-in Delegate System.Action<T>
            Action<Photo> FilterHandler = pf.ApplyBrightness;
            FilterHandler += pf.Resize;
            FilterHandler += ApplyNewFilter;

            pp.PhotoProcess(ppath, FilterHandler);


            Console.WriteLine("Press Enter to Quite...");
            while (Console.ReadKey().Key != ConsoleKey.Enter){}

        }

        private static void ApplyNewFilter(Photo photo) {
            Console.WriteLine("Apply New Filter by Using Delegate...");
        }
        
    }
}
