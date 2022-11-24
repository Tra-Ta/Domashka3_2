Console.Write("Enter natural number ->  ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
void CubeNumbers(int num)
{
    int num1 = 1;
    while (num1 <= num)
    {
        double cube = num1 * num1 * num1;
        Console.WriteLine($"{num1,2} {cube,4}");
        num1++;
    }
}
if (number > 0)
    CubeNumbers(number);
else Console.WriteLine("The number is not natural");