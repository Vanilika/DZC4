//Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

void FillArray(int [] array)
{
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    array[i] = rnd.Next(0, 100);
}
int arraySize = 8;

int [] array = new int[arraySize];
FillArray(array);
System.Console.WriteLine(string.Join(",", array));
