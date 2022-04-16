# GSA


# Part 1 - Importing Pnl csv
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
