// Задача 38: Задайте массив вещественных(тип int) чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

int [] FillArray(int size)
{

int[] arr = new int[size];
for(int i = 0; i < arr.Length; i++)
{
arr[i] = new Random().Next(1,100);
}
return arr;
}

Console.Write("Введите длину массива: ");
int num = Convert.ToInt32(Console.ReadLine());
int[] array = FillArray(num);
Console.WriteLine("Ваш массив:"+ string.Join(" ",array));
double min = Int32.MaxValue;
double max = Int32.MinValue;
for(int i = 0; i < array.Length; i++)
{
    if(array[i]>max)
    {
      max = array[i];
    }
     if(array[i]<min)
     {
       min = array[i];
     }
   
}

Console.Write($"Разницы между максимальным и минимальным числом равна { max-min } ");