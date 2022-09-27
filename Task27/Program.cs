// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.


int ReadData(string msg)
{
    Console.Write(msg);
    int number = int.Parse(Console.ReadLine()??"0");
    return number;
}

int DigCount(int num)
{
    int result = 0;
    while(num>0)
    {
        result = result + num%10;
        num = num/10;
    }
    return result;
}
void PrintData(string msg, int value)
{
    Console.WriteLine(msg + value);
}
int a = ReadData("Введите число: ");
PrintData("Сумма цифр в числе " + a + " равна ", DigCount(a));