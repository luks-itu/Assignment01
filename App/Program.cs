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
            var lines = new List<string> {"1920x1080","1024x768, 800x600, 640x480","ax300","1ax2b" };
            Console.WriteLine("Kører");
            //var output = Resolutions(lines);
            Console.WriteLine(output.GetType().FullName);
            foreach(var entry in output){
                Console.WriteLine(entry);
            }
            
               
        }

        public static IEnumerable<(int width, int height)> Resolutions(IEnumerable<string> resolutions)
        {
            string pattern = @"(?<entireRes>(?<width>[0-9]+)x(?<height>[0-9]+))";        
            Regex reg = new Regex(pattern);
            Match match;
            


            foreach(var line in resolutions)
            {
                match = reg.Match(line);
                while (match.Success)
                {
                    string w = match.Groups["width"].Value;
                    int width = int.Parse(w);
                    string h = match.Groups["height"].Value;
                    int height = int.Parse(h);
                    

                    yield return (width, height);
                    match = match.NextMatch();
                }
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
