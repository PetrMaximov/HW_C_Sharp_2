// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.


Console.WriteLine("Введите трехзначное число");

int Num = Convert.ToInt32(Console.ReadLine());

int Num100 = Num / 100;
int Num10 = (Num - Num100*100) / 10;
int Num1 = Num % 10;

Console.WriteLine("вторая цифра числа " + Num + ": " + Num10);

