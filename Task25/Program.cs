//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

int ReadData(string msg)
{
    Console.Write(msg);
    int number = int.Parse(Console.ReadLine()??"0");
    return number;
}

int PowAToB( int a, int b)
{
    int result = 1;
    for (int i = 0; i < b; i++)
    {
        result = result*a;
    }
    return result;
}
int PowAToBMath( int a, int b)
{
    int result = (int)Math.Pow(a,b);
    return result;

}

void PrintData(string msg, int value)
{
    Console.WriteLine(msg + value);
}

int a = ReadData("Введите число А: ");
int b = ReadData("Введите число B: ");
DateTime d1 = DateTime.Now;
PrintData("Число " + a + " возведенное в степень " + b + " равно = " , PowAToB(a,b));
Console.WriteLine(DateTime.Now-d1);
DateTime d2 = DateTime.Now;
PrintData("Число " + a + " возведенное в степень " + b + " равно = " , PowAToBMath(a,b));
Console.WriteLine(DateTime.Now-d2);