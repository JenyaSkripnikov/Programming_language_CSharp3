/*Задача 23
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
Например:
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/

int GetNumber(string message) 
{
    int digit;
    while(true)
    {
        Console.WriteLine(message);
        if(int.TryParse(Console.ReadLine(), out int number) && number > 0)
        {
            digit = number;
            break;
        }
        else
        {
            Console.WriteLine($"{number} - Введены не корректные данные. Повторите ввод \n");
        }
    }
    return digit;
}  

void Cube(int n)
{
    for(int i = 1; i <= n; i++)
    {
        Console.WriteLine($"{Math.Pow(i, 3)} ");
    }
}

int number = GetNumber("Введите натуральное число N: ");
Cube(number);