// Задача:
// Напишите программу, которая принимает на вход
// число N и выдаёт произведение чисел от 1 до N.
// Например:
// 4 -> 24
// 5 -> 120

int ReadData(string msg) // метод для ввода числа
{
    Console.Write(msg);
    int number = int.Parse(Console.ReadLine());
    return number;
}
long Faktor(int num)
{
    long res = 1;
    for (int i = 1; i <= num; i++)
    {
        res = res * i;
    }
    return res;
}

void PrintData(string msg, long value)
{
    Console.WriteLine(msg + value);
}
int numN = ReadData ("Введите число N: ");
long OutResult = Faktor(numN);
PrintData ("Факториал числа " + numN + " равен ", OutResult);