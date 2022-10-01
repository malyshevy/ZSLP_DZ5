// Задача 34: Задайте массив заполненный случайными положительными 
//            трёхзначными числами. Напишите программу, 
//            которая покажет количество чётных чисел в массиве.

Console.Clear();
int num = enterNum();
int [] array = arrayRandom(num);
Console.WriteLine($"Количество чётных чисел в массиве = {chetSum(array, num)}");

int enterNum ()
{
    Console.Write("Введите количество элементов массива: ");
    return (int.Parse(Console.ReadLine()));
}

int [] arrayRandom (int number)
{
    int [] arr = new int [number];
    for (int i=0;number>i;i++)
    {
        arr[i]=new Random().Next(100 , 1000);
    }
    Console.WriteLine($"Весь массив : [{String.Join(",", arr)}]");
    return (arr);
}

int chetSum (int [] arr, int number)
{
    int sum = 0;
    for (int i = 0;number>i;i++)
    {
        if ((arr [i]%2)==0) sum+=1;
    }
    return (sum);
}