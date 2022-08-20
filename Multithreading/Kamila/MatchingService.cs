using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multhitreeading
{
    public class MatchingService
    {
        public List<MatchModel> GetNameMatches(string[] names)
        {
            var namesList = new List<MatchModel>();

            Parallel.ForEach(names, (i, state) =>
            {

                double topRatio = 0;
                var topResult = new MatchModel();

                // O(n)
                for (int l = 0; l < names.Length; l++)
                {
                    var name1 = i;
                    var name2 = names[l];

                    // Does not depend on n
                    var ratio = FuzzySharp.Levenshtein.GetRatio(name1, name2);
                    if (ratio != 1 & ratio != 0)
                    {
                        if(ratio > topRatio)
                        {
                            topResult = new MatchModel()
                            {
                                Name1 = name1,
                                Name2 = name2,
                                Ratio = Math.Round(ratio, 2)
                            };
                        }
                    }
                    continue;
                }

                // Sort:
                //  O(n) < O(nlogn) < O(n^2)
                namesList.Add(topResult);

                }
            );
            var results = namesList.OrderByDescending(x => x.Ratio).ToList();

            return results;

        }
    }
}
