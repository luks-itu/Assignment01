using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace App
{
    public class Program
    {
        
        static void Main(string[] args)
        {
            var lines = new List<string> { "these are wordsBut", "thi@s is not1 but this is 920" };
            Console.WriteLine("Kører");
            var output = SplitLine(lines);
            foreach(var entry in output){
                Console.WriteLine(entry);
            }
            
               
        }

        public static IEnumerable<string> SplitLine(IEnumerable<string> lines)
        {
            //create regex for special character
            string pattern = @"[^a-zA-Z0-9_]";
            string whitespace = @"\s";
            Regex reg = new Regex(pattern);
            bool illegalWord;

            // go over each line of text
            foreach(var line in lines)
            {
                //split the lines down to words by whitespace 
                var words = Regex.Split(line,whitespace);

                //go over each word and use regex to only return words without special characters.
                foreach(var entry in words)
                {
                    //isValidWord = reg.IsMatch(entry);
                    illegalWord = reg.IsMatch(entry);


                    if(!illegalWord)
                    {
                        yield return entry;
                    }

                }
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
