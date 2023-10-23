// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите
// программу, которая покажет количество чётных чисел в массиве.

int[] array = CreateArray();
ShowArray(array);
Console.WriteLine($"\nКол-во четных чисел - {CalcEventNumbers(array)}");

void ShowArray(int[] array)
{
    
    for(int i = 0; i < array.Length; i++)
    {
        System.Console.Write(array[i] + "\t");
    }
    System.Console.Write("\n");
}

int[] CreateArray()
{
    Random random = new Random();
    int maxSizeArray = 15;
    int minSizeArray = 10;
    int maxSizeNumber = 1000;
    int minSizeNumber = 100;

    int[] array = new int[random.Next(minSizeArray, maxSizeArray)];

    for(int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(minSizeNumber, maxSizeNumber);
    }

    return array;
}

int CalcEventNumbers(int[] array)
{
    int count = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] % 2 == 0)
            count++;
    }

    return count;
}