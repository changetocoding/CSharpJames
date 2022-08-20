using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using FuzzySharp;
using System.Diagnostics;
using FileReader;

class Program
{
    /// <summary>
    /// Sean:  00:00:03.9166570
    /// Jacob: 00:00:07.8313599
    /// Kamila:00:00:07.9751648
    /// 
    /// Kamila:00:00:04.5754829
    /// </summary>



    static void Main()
    {

        List<string> names = new PlaceNamesService().PlaceNames().ToList();

        Stopwatch timer = new Stopwatch();
        timer.Start();

        List<MatchedResults> results = new List<MatchedResults>();

        Parallel.ForEach(names, baseName =>
        {
            List<MatchedResults> comparativeValues = new List<MatchedResults>();

            foreach (string comparedName in names)
            {
                if (baseName != comparedName)
                {
                    double score = FuzzySharp.Levenshtein.GetRatio(baseName, comparedName);
                    comparativeValues.Add(
                        new MatchedResults(baseName, comparedName, score)
                        );
                }
            };
            var bestMatch = comparativeValues.OrderByDescending(x => x.Score).FirstOrDefault();
            results.Add(bestMatch);
        });

        var orderedResults = results.OrderByDescending(x => x.Score).AsEnumerable();
        foreach (var result in orderedResults)
        {
            Console.WriteLine($"{result.Score}: {result.BaseName} -> {result.ComparedName}");
        }

        timer.Stop();
        Console.WriteLine("Jacob:"+ timer.Elapsed.ToString());
    }

    public class MatchedResults
    {
        public string BaseName { get; set; }
        public string ComparedName { get; set; }
        public double Score { get; set; }

        public MatchedResults(string baseName, string comparedName, double score)
        {
            BaseName = baseName;
            ComparedName = comparedName;
            Score = score;
        }
    }
}