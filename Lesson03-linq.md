
# Resources
- Internet access
- https://github.com/zbma/linq-exercises


# Objectives
- Understand common linq functions groupby, sum, select, where


# Code
```
    class Class2
    {
        static void Main(string[] args)
        {
            IEnumerable<string> it = new List<string>() { "test", "Jacob", "Sean" , "test", "test", };
            it.Where(x => x.Length > 2);
            it.Select(x => x.Length);
            it.GroupBy(x => x.Length);
            it.OrderBy(x => x.Length);

            var sum = it.Select(x => x.Length).Sum();
            Console.WriteLine($"Sum - {sum}");

            foreach (var grp in it.GroupBy(x => x))
            {
    
                Console.WriteLine($"{grp.Key} - {grp.Count()}");
            }
        }

        public void Do()
        {
            IEnumerable<string> it = new string[10];
            IEnumerable<string> it2 = new List<string>();
            IEnumerable<KeyValuePair<string, int>> it3 = new Dictionary<string, int>();

            foreach (var item in it2)
            {

            }
        }
    }
```

# Class code 2
```cs
    class Program
    {
        static void Main(string[] args)
        {
            var it = new List<int>() {10, 20, 12, 88, 98, 288};

            // variables
            // select (if)
            // for loop - next
            foreach (var item in it)
            {
                
            }

            // Functional programing
            var res2 = it.Select(x => x + 1);


            // linq ienumberable - List, dictionary, arrays
            IEnumerable<string> it2 = new string[] { "test", "Jacob", "Sean", "test", "test", };
            it2.Last(); // test

            var morethan4chars = it2.Where(x => x.Length > 4);
            Console.WriteLine(morethan4chars.First());

            var lengths = it2.Where(x => x == "test").Count();


            IEnumerable<int> res3 = MultiplesOfTen();

            foreach (var no in res3)
            {
                Console.WriteLine(no);
            }
        }

        public static IEnumerable<int> MultiplesOfTen()
        {
            var start = 0;
            while (start < 200)
            {
                start = start + 10;
                yield return start;
            }
        }


        public static IEnumerable<int> MultiplesOfTen2()
        {
            var start = 0;
            var rtn = new List<int>();
            while (start < 200)
            {
                start = start + 10;
                rtn.Add(start);
            }

            return rtn;
        }

        public IEnumerable<int> FourInARow()
        {
            yield return 10;
            yield return 20;
            yield return 15;
            yield return 25;
        }

    }
```

# Other


Linq: Pull vs push

IEnumerable: you can iterate through me

Have to implement 3 things

yield return keyword as simpler way of doing it.



1. Lists, Arrays ...

2. Iterate

3 for ... /if ... 

4. Ienumberable : list, array, dictionary ... implements this.


7. Linq - since enumberables are so important. Lets create some helper methods to do common stuff on them. But we work out how to do it efficently and lazily so you dont have to


8. Yield Return Keywords
```csharp
        public static IEnumerable<int> DavidsEnumerable2YieldImpl()
        {
            var i = 0;
            while (true)
            {
                yield return i;
                i++;
				
		if(i>100)
			yield break;
            }
        }

```

9. Lazily executed. Only executes when you need it to


# Yield return
```cs
        public IEnumerable<int> FourInARow()
        {
            yield return 10;
            yield return 20;
            yield return 15;
            yield return 25;
        }

        public IEnumerable<string> ReadBigrams()
        {
            var lines = File.ReadAllLines("c:\\path");
            List<string> results = new List<string>();
            for (int i = 0; i < lines.Length; i++)
            {
                var line = lines[i];
                if (line.StartsWith("0x"))
                {
                    results.Add(Combine(line, next).Replace("Space", "__"));
                }
            }

            return results;
        }
```


# Make your linked list Ienumerable
Implement (Ienumerable)
Example here - https://docs.microsoft.com/en-us/dotnet/csharp/fundamentals/types/generics
```cs
        public IEnumerator<T> GetEnumerator()
        {
            Node current = head;

            while (current != null)
            {
                yield return current.Data;
                current = current.Next;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
```

# Gottchas
Yield return - example 4 in a row
Example building list to return ,(common pattern)

Lazy vs eager loading
Enumerating twice (Example for. Break on % 4)

 
# Class Code
```csharp
class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var result = Transform(DateTime.Now, x => x.Year);
            var result2 = TransformToT<int>(DateTime.Now, x => x.Year);

            //var days = NextFourDays().ToList();
            //Console.WriteLine(days.Count());
            //foreach (var item in days)
            //{
            //    Console.WriteLine(item.ToLongDateString());
            //}
            var magic = MagicNumbersEnumerable();
            //Console.WriteLine(magic.ToList().Count());
            foreach (var item in magic.Take(10))
            {
                Console.WriteLine(item);
            }

            // lazy evaluation
            // Ienumberable .ToList, ToDictionary .ToArray or in a foreach
            // Same applies to linq
        }

        // generic
        public static int Transform<T>(T data, Func<T, int> transfrom)
        {
            return transfrom(data);
        }


        // generic
        public static T TransformToT<T>(DateTime data, Func<DateTime, T> transfrom)
        {
            return transfrom(data);
        }

        // return numbers not divisible by 2, 3,5,7,11
        public static IEnumerable<int> MagicNumbers()
        {
            var toReturn = new List<int>();
            int i = 0;
            while (true)
            {
                i++;
                if(i % 2 != 0 && i % 3 != 0 && i % 5 != 0 && i % 7 != 0)
                {
                    toReturn.Add(i);
                }
            }

            return toReturn;
        }

        public static IEnumerable<int> MagicNumbersEnumerable()
        {
            int i = 0;
            while (true)
            {
                i++;
                if (i % 2 != 0 && i % 3 != 0 && i % 5 != 0 && i % 7 != 0)
                {
                    yield return i;
                }
            }
        }

        public static IEnumerable<int> MagicNumbersForLoop()
        {
            var toReturn = new List<int>();
            for (int i = 0; i < 100; i++)
            {
                if(i % 2 != 0 && i % 3 != 0 && i % 5 != 0 && i % 7 != 0)
                {
                    toReturn.Add(i);
                }
            }

            return toReturn;
        }

        public static IEnumerable<int> MagicNumbersEnumerableForLoop()
        {
            for (int i = 0; i < 100; i++)
            {
                if (i % 2 != 0 && i % 3 != 0 && i % 5 != 0 && i % 7 != 0)
                {
                    yield return i;
                }
            }
        }


        public static IEnumerable<DateTime> NextFourDays()
        {
            yield return DateTime.Today;
            yield return DateTime.Today.AddDays(1);
            yield return DateTime.Today.AddDays(2);
            yield return DateTime.Today.AddDays(3);
        }
    }
```



# Homework
1. Make linked List generic
2. Count bi-grams. Given a string count character pairs. E.g "See the sea" 
```
se - 2
ee - 1
e_ - 2 (space)
_t - 1
th - 1
_s - 1
ea - 1
```
3. Pnl
In GSA folder you will find a file "pnl.csv". Your task is to transform it into a list of the _StrategyPnl_ class below:
```cs
    public class StrategyPnl
    {
        public string Strategy { get; set; }
        List<Pnl> Pnls { get; set; }
    }

    public class Pnl
    {
        public DateTime Date { get; set; }
        public decimal Amount { get; set; }
    }
```

I actually got this as part of an interview for a senior role and it's a good task that included a db and webserver. We'll slowly work through it.







