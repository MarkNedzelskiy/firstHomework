/*
Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

2, 3, 7 -> 7
44 5 78 -> 78
*/

Console.WriteLine("Напишите первое число: ");
string inputNumber = Console.ReadLine();
int firstNumber = Convert.ToInt32(inputNumber);

Console.WriteLine("Напишите второе число: ");
inputNumber = Console.ReadLine();
int secondNumber = Convert.ToInt32(inputNumber);

Console.WriteLine("Напишите третье число: ");
inputNumber = Console.ReadLine();
int thirdNumber = Convert.ToInt32(inputNumber);

if (firstNumber > secondNumber)
{
    if (firstNumber > thirdNumber) 
    {
        Console.WriteLine($"Первое число '{firstNumber}' самое большое из трех");
    }
    else
    {
        Console.WriteLine($"Третье число '{thirdNumber}' самое большое из трех");
    }
}
else 
{
    if (secondNumber > thirdNumber)
    {
    Console.WriteLine($"Второе число '{secondNumber}' самое большое из трех");
    }
    else
    {
        Console.WriteLine($"Третье число '{thirdNumber}' самое большое из трех");
    }
}