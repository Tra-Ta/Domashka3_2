Console.Write("Enter the coordinate X of the first point ->  ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the coordinate Y of the first point ->  ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the coordinate Z of the first point ->  ");
int z1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter the coordinate X of the second point ->  ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the coordinate Y of the second point ->  ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the coordinate Z of the second point ->  ");
int z2 = Convert.ToInt32(Console.ReadLine());

double Distance(int x1, int y1, int z1, int x2, int y2, int z2)
{
    return Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1) + (z2 - z1) * (z2 - z1));
}
double distance = Math.Round(Distance(x1, y1, z1, x2, y2, z2), 2, MidpointRounding.ToZero);
Console.WriteLine(distance);