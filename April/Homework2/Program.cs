Console.WriteLine("Add сoordinate X: ");
Console.WriteLine("Add сoordinate Y: ");
int x = Convert.ToInt32(Console.ReadLine());
int y = Convert.ToInt32(Console.ReadLine());
if (x > 0 && y > 0)
{
    Console.WriteLine("First Coordinate Plane");
}
if (x < 0 && y > 0)
{
    Console.WriteLine("Second Coordinate Plane");
}
if (x < 0 && y < 0)
{
    Console.WriteLine("Third Coordinate Plane");
}
if (x == 0 && y == 0)
{
    Console.WriteLine("Error");
}