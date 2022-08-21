/* Задача 45: Напишите программу, которая будет создавать копию заданного массива 
с помощью поэлементного копирования.
 */

/*  
void NewArray1(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(0, 15);
}

void NewArray1(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(-10, 11);
}

string SwapDigitsInArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == number)
            return ("Число " + number + " есть в массиве");
    }
    return ("Числа " + number + " нет в массиве");
}

Console.Write("Укажите кол-во элементов в массиве: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
NewArray(array);
Console.WriteLine("Начальный массив: [" + string.Join(", ", array) + "]");
Console.Write("Укажите число, которое Вы хотите найти в массиве: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(SearchNumberInArray(array, number)); */


// С СЕМИНАРА: 

void NewArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(-10, 11);
}

int[] CreateArray(int[] array)
{
    int[] copyArray = new int[array.Length];
    for (int i = 0; i < array.Length; i++)
        copyArray[i] = array[i];
    
    return copyArray;
}

Console.Write("Укажите кол-во элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
int[] copyArray = new int[n];
NewArray(array);
Console.WriteLine("Исходный массива [" + string.Join(", ", array) + "]");
copyArray = CreateArray(array);
copyArray[0] = 20;
Console.WriteLine("Исходный массива [" + string.Join(", ", copyArray) + "]");
