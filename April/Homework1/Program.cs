System.Console.WriteLine("Add digit: ");
int digit = Convert.ToInt32(Console.ReadLine());
int number1 = 7;
int number2 = 23;

if (digit % number1 == 0 && digit % number2 == 0)
{
    Console.WriteLine("Yes");
}
else
{
    Console.WriteLine("No");
}

