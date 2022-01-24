using CollectionsDemo;

var cats = new List<Cat>()
{
    new("Barsik",100,4),
    new("Murka",50,1),
    new("Vsya",80,2),
    new("Pushok",110,6)
};

Console.WriteLine("Your cats: ");
cats.ForEach(Console.WriteLine);
var lights = cats.Where(cat => cat.Weight < 3 ).ToList();
var longsNames = cats.Where(cat => cat.Height > 100).Select(c => c.Name).ToList();
var longCatsNames = (from cat in cats where cat.Height > 100 select cat.Name).ToList();
var middleCatsInfo = cats.Where(cat => cat.Weight is >= 3 and <= 5)
    .Select(cat => new {cat.Name, cat.Height}).ToList();
var middleCatsFluent = (from cat in cats where cat.Weight is >= 3 and <= 5
    select new {cat.Name, cat.Height}).ToList();
var sortedCats = cats.OrderBy(cat => cat.Height).ToList();
var sortedCatsFluent = (from cat in cats orderby cat.Height select cat).ToList();
Console.WriteLine("Light cats: ");
lights.ForEach(Console.WriteLine);
Console.WriteLine();
Console.WriteLine("Long cats: ");
longsNames.ForEach(Console.WriteLine);
Console.WriteLine("\nLong cats names");
longCatsNames.ForEach(Console.WriteLine);
Console.WriteLine("\nMiddle cats:");
foreach(var info in middleCatsInfo)
    Console.WriteLine($"Name: {info.Name}\nHeight: {info.Height}");
Console.WriteLine("\nMiddle cats by fluent:");
foreach(var info in middleCatsFluent)
    Console.WriteLine($"Name: {info.Name}\nHeight: {info.Height}");
Console.WriteLine("\nSorted cats:");
sortedCats.ForEach(Console.WriteLine);
Console.WriteLine("\nSorted cats by fluent:");
sortedCatsFluent.ForEach(Console.WriteLine);
