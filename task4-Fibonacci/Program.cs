/* Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. 
Первые два числа Фибоначчи: 0 и 1.
 */

Console.Write("Введите до какого цисла нужно показать последовательность:");
int userNumber = int.Parse(Console.ReadLine()!);

int numberA = 0;
int numberB = 1;

while (numberA < userNumber)
{
    Console.Write($"{numberA} ");
    int save = numberA;
    numberA = numberA + numberB;
    numberB = save;

}


/* Второе решение с семинара через с процедуру: 

void check(int n)
{
    int numberOne = 0;
    int numberTwo = 1;
    for (int i = 0; i < n; i++)
    {
        Console.Write(numberOne + " ");
        int x = numberOne + numberTwo;
        numberOne = numberTwo;
        numberTwo = x;
    }
}
Console.Write("Укажите кол-во чисел: ");
int n = Convert.ToInt32(Console.ReadLine());
check(n);
 */