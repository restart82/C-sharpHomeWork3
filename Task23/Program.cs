// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

int N = 3; // Степень числа

int InputData(string message)
{
    Console.Write(message);
    int result = int.Parse(Console.ReadLine()!);
    return result;
}

bool ValidateNumber(int number)
{
    if (number < 1)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine($"!!!Число N должно быть > 0!!!");
        Console.ResetColor();
        return false;
    }
    return true;
}

void PowTable(int number)
{
    Console.Write($"Таблица степени {N} числа {number}: ");
    int i = 1;
    while (i <= number)
    {
        if (i == number)
        {
            Console.WriteLine(Math.Pow(i, N) + ".");
            
        }
        else
        {
            Console.Write(Math.Pow(i, N) + ", ");
        }
        i++;
    }
}

int Number = InputData("Введите число N >");

if (ValidateNumber(Number))
{
    PowTable(Number);
}

