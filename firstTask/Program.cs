/*
Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3
*/

Console.WriteLine("Напишите первое число: ");
string inputNumber = Console.ReadLine();
int firstNumber = Convert.ToInt32(inputNumber);

Console.WriteLine("Напишите второе число: ");
inputNumber = Console.ReadLine();
int secondNumber = Convert.ToInt32(inputNumber);

if (firstNumber > secondNumber)
{
    Console.WriteLine($"Первое число больше '{firstNumber}', чем второе '{secondNumber}'");
}
else
{
    Console.WriteLine($"Второе число больше '{secondNumber}', чем первое '{firstNumber}'");
}