// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.WriteLine("Введите число");
string strNum = Console.ReadLine();
int Num = Convert.ToInt32(strNum);
int L = strNum.Length;
int n = 3;

if (L - n < 0) 
{
    Console.WriteLine("Третьей цифры нет");
}
else
{
    int StepNum1 = Convert.ToInt32(Math.Pow(10, L-1));
    int Num1 = Num / StepNum1;

    int StepNum2 = Convert.ToInt32(Math.Pow(10, L-2));
    int Num2 = (Num - Num1*StepNum1) / StepNum2;

    int StepNum3 = Convert.ToInt32(Math.Pow(10, L-3));
    int Num3 = (Num - Num1*StepNum1-Num2*StepNum2) / StepNum3;

    
    Console.WriteLine("Третья цифра числа " + Num + ": " + Num3);

}


