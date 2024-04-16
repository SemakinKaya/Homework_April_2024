// Задача 3: Напишите программу, которая принимает на вход 
//целое число из отрезка 
// [10, 99] и показывает наибольшую цифру числа.

System.Console.WriteLine("Enter a number from the segment [10, 99]: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number >= 10 && number <= 99)
{
    int firstDigit = number / 10;
    int secondDigit = number % 10;
    if (firstDigit >= secondDigit)
    {
        System.Console.WriteLine(firstDigit);
    }
    else
    {
        System.Console.WriteLine(secondDigit);
    }
}
else
{
    System.Console.WriteLine("you added the wrong number according to the range");
}