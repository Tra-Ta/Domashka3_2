Console.WriteLine("Enter a five-digit number -> ");
int number = Convert.ToInt32(Console.ReadLine());

void Palindrome(int num)
{
    int num1 = num / 10000;
    int num2 = (num / 1000) % 10;
    int num3 = (num / 10) % 10;
    int num4 = num % 10;
    if (num1 == num4 || num2 == num3)
        Console.WriteLine("The number is a palindrome");
    else Console.WriteLine("The number is not a palindrome");
}
if (number > 100000 || number < 9999) Console.WriteLine("The number is not five-digit");
else Palindrome(number);