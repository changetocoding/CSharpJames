namespace FileReader
{
    // You are not allowed to change this class

        // https://raw.githubusercontent.com/changetocoding/CSharpTraining/main/Lesson-10-multi/PlaceNamesUkWithC.txt

        // You are not allowed to change this class
        public class PlaceNamesService
        {
            public IEnumerable<PlaceNames> GetPlaceNames()
            {
                var fileLoc = @"C:\Dev\temp\PlaceNamesUkWithC.txt";
                var id = 0;
                var lines = File.ReadAllLines(fileLoc);
                foreach (var line in lines)
                {
                    var split = line.Split(",");
                    yield return new PlaceNames(id++, split[0], split[1], split[2]);
                }
            }

        public IEnumerable<string> PlaceNames()
        {
            var fileLoc = @"C:\Dev\temp\PlaceNamesUkWithC.txt";
            return File.ReadAllLines(fileLoc);
        }
    }

        // You are not allowed to change this class
        public class PlaceNames
        {
            public PlaceNames(int id, string name, string county, string country)
            {
                Id = id;
                Name = name;
                County = county;
                Country = country;
                Postcode = String.Join("", county.Take(2));
            }

            public int Id { get; }
            public string Name { get; }
            public string County { get; }
            public string Country { get; }
            public string Postcode { get; }
        }
    
}