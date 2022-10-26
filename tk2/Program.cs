/*Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)*/

Console.WriteLine("Введите значение b1: ");
double b1 = Convert.ToDouble (Console.ReadLine());
Console.WriteLine("Введите значение k1: ");
double k1 = Convert.ToDouble (Console.ReadLine());
Console.WriteLine("Введите значение b2: ");
double b2 = Convert.ToDouble (Console.ReadLine());
Console.WriteLine("Введите значение k2: ");
double k2 = Convert.ToDouble (Console.ReadLine());

void Сrossing (double c1, double c2, double n1, double n2)
{
    double x = 0;
    double y = 0; 
    x = ((c2 - c1) / (n1 - n2));

    y = ((n1 * x) + c1);
    y = ((n2 * x) + c2);
Console.WriteLine($"точку пересечения двух прямых ({x}, {y})");
}

Сrossing (b1, b2, k1, k2);








/* примеры методов

void ConsoleWriteLineSum (int a, int b)
{
    int с = a + b;
    Console.WriteLine($"сумма введенных переменных равна " + с);
}

ConsoleWriteLineSum(4, 5);

int ReturnSum (int a, int b)
{
    int с = a + b;
    return c;
}
int i = ReturnSum(5, 7);

int VozvedStepen (int x, int stepen)
{
    while(stepen > 1)
    {
        x = x * x;
        stepen--;
    }
    return x;
}*/