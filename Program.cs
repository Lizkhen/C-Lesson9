/* Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в 
промежутке от M до N 
Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два 
неотрицательных числа m и n*/
Console.WriteLine ("Выберите номер задачи");
Console.WriteLine ("Задача 66. Найдём сумму натуральных элементов от m до n.");
Console.WriteLine ("Задача 68. Вычисление функции Аккермана.");
int n = Convert.ToInt32(Console.ReadLine ());
switch (n)
{
    case 66:
        Task66();
        break;
    case 68:
        Task68();
        break;
    default:
        break;
}
void Task66()
{
   {
    Console.WriteLine("Введите число m");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите число n");
    int n = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine( "Сумма всех натуральных элементов  в промежутке между заданными числами, включая их");
    if (m < n)
        Console.WriteLine( SumOfNumbers (m-1,n));
    else
        Console.WriteLine( SumOfNumbers (n-1,m));
    int SumOfNumbers (int m, int n)
    {   if (m == n)
            return 0; 
        if (m > n)
        { 
            n++;
            return  n + SumOfNumbers (n, m);
        }
        else
        {
            m++;
            return  m + SumOfNumbers (m, n);
        }
    }
}
}
void Task68()
{
    Console.WriteLine("Введите число m");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите число n");
    int n = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine(Akkerman(m, n));
    int Akkerman(int m, int n)
    {
        if (m == 0)
            return n + 1;
        else if (n == 0 && m > 0)
            return Akkerman(m - 1, 1);
        else
            return (Akkerman(m - 1, Akkerman(m, n - 1)));
    }
}
