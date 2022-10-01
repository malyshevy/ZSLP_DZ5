// Задача 38: Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементов массива.
Console.Clear();
int num = enterNum();
double num2;
double [] array = arrayRandom(num);
double [] arraySum = chetSum (array , num);
Console.WriteLine($"Разница между максимальным {arraySum[0]} и минимальным {arraySum[1]} значениями массива = {num2=arraySum[0]-arraySum[1]}");

int enterNum ()
{
    Console.Write("Введите количество элементов массива: ");
    return (int.Parse(Console.ReadLine()));
}

double [] arrayRandom (int number)
{
    double [] arr = new double [number];
    for (int i=0;number>i;i++)
    {
        arr[i]=new Random().Next(-100 , 101);
    }
    Console.WriteLine($"Весь массив : [{String.Join(", ", arr)}]");
    return (arr);
}

double [] chetSum (double [] arr1, int number)
{
    double [] arr2 = new double [2];
    for (int i = 0;number>i;i++)
    {
        if (arr2[0]<arr1[i])
        {
            arr2[0]=arr1[i];
        }
        if (arr2[1]>arr1[i])
        {
            arr2[1]=arr1[i];
        }
    }
    Console.WriteLine($"MAX и MIN : [{String.Join(",", arr2)}]");
    return (arr2);
}