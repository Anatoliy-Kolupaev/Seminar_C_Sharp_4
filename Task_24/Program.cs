// Задача:
// Напишите программу, которая принимает на вход
// число (А) и выдаёт сумму чисел от 1 до А.
// Например:
// 7 -> 28
// 4 -> 10
// 8 -> 36

int ReadData(string msg) // метод для ввода числа
{
    Console.Write(msg);
    int number = int.Parse(Console.ReadLine());
    return number;
}
int SumDigitOneToA(int numA) // метод для подсчета суммы
{
    int sum = 0;
    for (int i = 1; i <= numA; i++)
    {
        sum = sum + i; // sum += i
    }
    return sum;
}
int GaussMethod (int numA) // Метод гауса подсчета суммы
{
    int sum = ((1+numA) * numA) / 2;
    return sum;
}
void PrintData(string msg, int value)
{
    Console.WriteLine(msg + value);
}
int numA = ReadData("Введите число А: ");
DateTime d1 = DateTime.Now; // засекает время перед началом выполнения метода
int sum = SumDigitOneToA(numA);
System.Console.WriteLine(DateTime.Now-d1); // выдает время за сколько сделали метод
PrintData("Сумма чисел от 01 до А: ");