Dictionary<string, string> shapes = new Dictionary<string, string>();

Console.WriteLine("Capacity " + shapes.Capacity);

shapes.Add("First", "Square");
shapes.Add("Second", "Circle");
shapes.Add("Third", "Rectangle");
shapes.Add("Fourth", "Triangle");
shapes.Add("Fifth", "Oval");
Console.WriteLine();

foreach(KeyValuePair<string, string> shape in shapes)
{
    Console.WriteLine(shape);
}

Console.WriteLine("Capacity " + shapes.Capacity);
Console.WriteLine("Current Amount " + shapes.Count);


/*
string[] shapes1 = new string[5];
string[] shapes2 = ["Square", "Circle", "Rectangle", "Triangle", "Oval"];

Console.WriteLine("Capacity " + shapes1.Length);
Console.WriteLine("Capacity " + shapes2.Length);

foreach(string shape in shapes1)
{
    Console.WriteLine(shape);
}

foreach(string shape in shapes2)
{
    Console.WriteLine(shape);
}
*/

/*
List<string> shapes = new List<string>();

Console.WriteLine("Capacity " + shapes.Capacity);

shapes.Add("Square");
shapes.Add("Circle");
shapes.Add("Rectangle");
shapes.Add("Triangle");
shapes.Add("Oval");
Console.WriteLine();
foreach(string shape in shapes)
{
    Console.WriteLine(shape);
}

Console.WriteLine("Capacity " + shapes.Capacity);
Console.WriteLine("Current Amount " + shapes.Count);
*/
