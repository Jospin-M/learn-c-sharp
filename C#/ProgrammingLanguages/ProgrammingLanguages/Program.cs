using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using ProgrammingLanguages;

namespace ProgrammingLanguages
{
    internal class Program
    {
        static void Main()
        {
            List<Language> languages = File.ReadAllLines("./languages.tsv")
              .Skip(1)
              .Select(line => Language.FromTsv(line))
              .ToList();

            /*foreach(Language lang in languages)
            {
                Console.WriteLine(lang.Prettify());
            }*/

            var special = languages.Select(lang => new { lang.Year, lang.Name, lang.ChiefDeveloper });

            /*foreach(var sp in special)
            {
                Console.WriteLine(sp);
            }*/

            var sharpNames = from lang in languages
                             where lang.Name.Contains("C#")
                             select lang.Prettify();

            /*foreach(var name in sharpNames)
            {
                Console.WriteLine(name);
            }*/

            var microsoftLanguages = from lang in languages
                                     where lang.ChiefDeveloper.Contains("Microsoft")
                                     select lang.Prettify();

            //PrintResult(microsoftLanguages);

            var lispPredecessor = from lang in languages
                                  where lang.Predecessors.Contains("Lisp")
                                  select lang.Name;

            //PrintResult(lispPredecessor);

            var scripts = from lang in languages
                          where lang.Name.Contains("Script")
                          select lang.Name;

            //PrintResult(scripts);

            //Console.WriteLine(languages.Count());

            var validLaunchYear = from lang in languages
                                  where lang.Year is >= 1995 and <= 2005
                                  select lang.Prettify();

            PrintResult(validLaunchYear);

        }

        static void PrintResult<T>(IEnumerable<T> list)
        {
            foreach(var item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}
