// Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, 
// может ли существовать треугольник с сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.


void check(int a, int b, int c)
{
    if (a + b > c && b + c > a && a + c > b)
        Console.WriteLine("yes");
    else
        Console.WriteLine("no");
}
Console.Write("Введите длину 1-ой стороны треугольника: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите длину 2-ой стороны треугольника: ");
int b = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите длину 3-уй стороны треугольника: ");
int c = Convert.ToInt32(Console.ReadLine());
check(a, b, c);
