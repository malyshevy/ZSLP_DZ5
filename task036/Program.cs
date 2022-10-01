// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.
Console.Clear();
int num = enterNum();
int [] array = arrayRandom(num);
int [] arraySum = chetSum (array , num);
Console.WriteLine($"Сумма элементов стоящих на нечётных позициях если счёт ведётся по индексу = {arraySum[1]}");
Console.WriteLine($"Сумма элементов стоящих на нечётных позициях если счёт ведётся по номеру = {arraySum[0]}");
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
        arr[i]=new Random().Next(-100 , 101);
    }
    Console.WriteLine($"Весь массив : [{String.Join(",", arr)}]");
    return (arr);
}

int [] chetSum (int [] arr1, int number)
{
    int [] arr2 = new int [2];
    for (int i = 0;number>i;i++)
    {
        if (i==0)
        {
            arr2[0]=arr2[0]+arr1[i];
        }
        else if ((i%2)==0)
        {
            arr2[0]=arr2[0]+arr1[i];
        }
        else
        {
            arr2[1]=arr2[1]+arr1[i];
        }
    }
    return (arr2);
}
