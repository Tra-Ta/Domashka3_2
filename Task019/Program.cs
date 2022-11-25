Console.WriteLine("Enter a five-digit number -> ");
int number = Convert.ToInt32(Console.ReadLine());

bool Palindrome(int num)
{
    int num1 = num / 10000;
    int num2 = (num / 1000) % 10;
    int num3 = (num / 10) % 10;
    int num4 = num % 10;
    return num1 == num4 && num2 == num3;
}
if (number > 100000 || number < 9999) Console.WriteLine("The number is not five-digit");
else Console.WriteLine( Palindrome(number)? "The number is a palindrome" : "The number is not a palindrome");
