using System;
using System.Collections.Generic;
using System.Linq;

namespace App
{
    public class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Kører");
               
        }

        

        public static bool Even(int i)
        {
            return i % 2 == 0;
        }

        public static IEnumerable<T> Filter<T>(IEnumerable<T> items, Predicate<T> predicate)
        {
            foreach(var item in items)
            {
                if (predicate(item)) {
                    yield return item;
                }
            }
        }


        public static IEnumerable<T> Flatten<T>(IEnumerable<IEnumerable<T>> items)
        {
            
            foreach ( IEnumerable<T> item in items)
            {
                foreach (var entry in item)
                {
                    yield return entry;
                }
            }
        }
    }
}
