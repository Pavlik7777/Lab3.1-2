//Лабораторная работа №3
//Операторы цикла с предусловием и постусловием
//Средний уровень. Вариант 22
//Console.WriteLine("Введите n:");
//int n = int.Parse(Console.ReadLine());
//int i = 0;
//int s = 1;
//while (i <=n)
//{
//    s = 2 << i - 1;
//    i++;
//}
//Console.WriteLine($"Клеток {n} спустя {s} минут");

//Лабораторная работа №3
//Оператор цикла for
//Базовый уровень. Вариант 22

Console.WriteLine("Введите n:");
int n = int.Parse(Console.ReadLine());
for (int i = 1; i <= n; i++)
{
    Console.WriteLine("Введите x:");
    double x = double.Parse(Console.ReadLine());
    double r = double.Parse(Console.ReadLine());
    if (0 < x && x < Math.PI)
        r = Math.Sin(x);
    else if (-Math.PI <= x && x < 0)
        r = Math.Pow(x, 3);
    else if (x < -2 * Math.PI || x > 2 * Math.PI)
        r = Math.Pow(x, 2);
    else
        r = 0;
    Console.WriteLine($"{r}");
}
