// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.WriteLine("Введите номер дня недели");
int NumDay = Convert.ToInt32(Console.ReadLine());

if ((0 < NumDay) && (NumDay < 6)) Console.WriteLine("Нет");
if ((5 < NumDay) && (NumDay < 8)) Console.WriteLine("Да");
if (NumDay < 1) Console.WriteLine("Введен неверный номер");
if (NumDay > 7) Console.WriteLine("Введен неверный номер");
