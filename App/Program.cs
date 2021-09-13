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
            var stream1 = new List<int>() {1, 2, 3};
            Predicate<int> even = Even;
            var output = Filter(stream1, Even);
            //Console.WriteLine(Filter(stream1, Even));


            //var stream2 = new List<int>() {5, 6};
            //var input = new List<List<int>>() {stream1, stream2};
            //var output = Flatten(input);
            foreach(var entry in output)
            {
                Console.Write(entry + " ");
            }            
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
