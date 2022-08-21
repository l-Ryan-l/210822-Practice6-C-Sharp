// Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3  -> 11
// 2  -> 10


// ДОПИЛИТЬ! ЧИСЛО РАЗВЕРНУТО НАОБОРОТ!

int Conver (int userNumber)
{
    int result = 0;
    int temp = 0;

    while(userNumber > 0)
        {
            result = userNumber % 10; 
            temp = result % 2;
            Console.Write(temp);
            userNumber = userNumber/ 2;
        }
        return temp;
}

Console.WriteLine("Введите число: ");
int userNumber = int.Parse(Console.ReadLine()!);

int result = 0;
int temp = 0;

Conver(userNumber);



/* 
решение с семинара 

string check(int n)
{
    string? result = "";
    while (n > 0)
    {
        int x = n % 2;
        result = Convert.ToString(x) + result;
        n /= 2;
    }
    return result;

}
Console.Write("Введите число, которое необходимо перевести в 2-ую систему: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(check(n));

 */
