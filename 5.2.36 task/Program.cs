// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях(индексах).

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0
int[] FillArray(int size)
{

int[] arr = new int[size];
for(int i = 0; i < arr.Length; i++)
{
arr[i] = new Random().Next(-10,100);
}
return arr;
}

Console.Write("Введите длину массива: ");

int num = Convert.ToInt32(Console.ReadLine());
int[] array = FillArray(num);
int sum = 0;
Console.WriteLine("Ваш массив:"+ string.Join(" ",array));
for(int i = 0; i< array.Length; i+=2)
{
    sum = array[i]+sum;
   
}
Console.Write($"Сумма элементов равна {sum}");