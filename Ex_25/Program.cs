/*
Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/

System.Console.WriteLine("Введите первое число: ");
int num = int.Parse(Console.ReadLine()!);
System.Console.WriteLine("Введите второе число: ");
int pow = int.Parse(Console.ReadLine()!);

int GetFunct(int num, int pow)
{
    int res = 1;
    for(int i = 1; i <= pow; i++)
    {
        res *= num;
    }
    return res;
}

System.Console.Write(GetFunct(num , pow));