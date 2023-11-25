using TriangleTesting;

var c = Triangle.GetTriangleInfo("122,5", "232,5", "112,5");

Console.WriteLine(c.Item1);

foreach (var item in c.Item2)
{
    Console.WriteLine(item);
}
