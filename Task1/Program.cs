using Task1;

var cache = new Cache<int>();
cache.Add(2);
cache.Add(3);
cache.Add(44);
cache.Remove(2);
foreach (var i in cache.Get())
{
    System.Console.WriteLine(i);
}
