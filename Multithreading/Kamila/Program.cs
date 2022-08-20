using FileReader;
using System;
using System.Diagnostics;

namespace Multhitreeading
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var allNames = new NamesService();

            var _matchingService = new MatchingService();
            
            var nameList = new PlaceNamesService().PlaceNames().ToArray();

            Stopwatch timer = new Stopwatch();
            timer.Start();

            var retunrnedMatches = _matchingService.GetNameMatches(nameList);


            foreach (var match in retunrnedMatches)
            {
                Console.WriteLine(match.ToString());
            }


            timer.Stop();
            Console.WriteLine("Kamila:" + timer.Elapsed.ToString());
        }
    }
}
