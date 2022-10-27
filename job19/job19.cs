/*Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
Например:
14212 -> нет
12821 -> да
23432 -> да
*/

int GetNumber(string message) 
{
    int digit;
    while(true)
    {
        Console.WriteLine(message);
        if(int.TryParse(Console.ReadLine(), out int number) && number > 9999 && number < 100000 || number > -100000 && number < -9999)
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

int number = GetNumber("Введите пятизначное число: ");

int oneDigit = Math.Abs(number / 10000);
int fiveDigit = Math.Abs(number % 10);
int temporari1 = Math.Abs(number / 10);
int fourDigit = Math.Abs(temporari1 % 10);
int temporari2 = Math.Abs(number / 1000);
int twoDigit = Math.Abs(temporari2 % 10);

if(oneDigit != fiveDigit)
Console.WriteLine($"Число {number} не является палиндромом.");
else if(twoDigit == fourDigit)
Console.WriteLine($"Число {number} является палиндромом.");