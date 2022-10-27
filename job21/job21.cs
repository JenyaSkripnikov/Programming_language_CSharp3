/*Задача 21
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
Например:
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/

double GetXYZ(int x1, int y1, int z1, int x2, int y2, int z2)
{
    double Hypotenuse = Math.Sqrt((Math.Pow(x1-x2, 2) + Math.Pow(y1-y2, 2)) + Math.Pow(z1-z2, 2));
    return Hypotenuse;
}

    int GetNumber(string message) 
{
    int digit;
    while(true)
    {
        Console.WriteLine(message);
        if(int.TryParse(Console.ReadLine(), out int number))
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

int CoordinateX1 = GetNumber("Введите ординату x1 ");
int CoordinateY1 = GetNumber("Введите абциссу y1 ");
int CoordinateZ1 = GetNumber("Введите аппликату z1 ");
int CoordinateX2 = GetNumber("Введите ординату x2 ");
int CoordinateY2 = GetNumber("Введите абциссу y2 ");
int CoordinateZ2 = GetNumber("Введите аппликату z2 ");

double Distan = GetXYZ(CoordinateX1, CoordinateY1, CoordinateZ1, CoordinateX2, CoordinateY2, CoordinateZ2);

Console.WriteLine($"Расстояние между коодинатами ({CoordinateX1}, {CoordinateY1}, {CoordinateZ1}) и ({CoordinateX2}, {CoordinateY2}, {CoordinateZ2}) равняется {Math.Round(Distan, 3)}");
