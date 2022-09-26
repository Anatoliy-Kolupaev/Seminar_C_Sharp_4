// Задача
// Напишите программу, которая принимает на вход
// число и выдаёт количество цифр в числе.
// Пример:
// 456 -> 3
// 78 -> 2
// 89126 -> 5

int ReadData(string msg) // метод для ввода числа
{
    Console.Write(msg);
    int number = int.Parse(Console.ReadLine()??"0"); // ??"0" позволяет избавится от желтого токста в терминале
    return number;
}
int CountNum (int num)
{
    int count = 0;
    while (num > 0)
    {
        num = num/10;
        count++;
    }
    return count;
}

void PrintData(string msg, int value)
{
    Console.WriteLine(msg + value);
}
int num = ReadData("Введите число: ");
PrintData("Количество цифр в числе " + num + " равно = ", CountNum(num));