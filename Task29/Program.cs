//Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

int ReadData(string msg)
{
    System.Console.Write(msg);
    int number = int.Parse(System.Console.ReadLine() ?? "0");
    return number;
}

int[] CreateArr(int arrLen, int arrLowBord, int arrHighBord)
{
    int[] array = new int[arrLen];
    for (int i = 0; i < arrLen; i++)
    {
        array[i] = new System.Random().Next(arrLowBord, arrHighBord + 1);
    }
    return array;
}

void Print1DArr(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ", ");
    }
    Console.Write(arr[arr.Length - 1] + "]");
}

int arrLen = ReadData("Введите длину массива: ");
int arrLowBord = ReadData("Введите нижний предел массива ");
int arrHighBord = ReadData("Введите верхний предел массива ");
int[] arr = CreateArr(arrLen, arrLowBord, arrHighBord);
Print1DArr(arr);


