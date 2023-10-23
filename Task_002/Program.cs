//Напишите программу, которая находит сумму элементов 
//c нечетными индексами в одномерном массиве целых чисел и выводит результат на экран.


int[] array = CreateRandomarray();
ShowArray(array);
int sum = SumOfOddIndexElements(array);
Console.WriteLine(sum);

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        System.Console.Write(array[i] + " ");
        if (i < array.Length - 1) // Проверяем, не последний ли элемент
        {
        Console.Write("\t");
        }
    }
    Console.WriteLine();
}

int [] CreateRandomarray()
{
    int minSizeArray = 0;
    int maxSizeArray = 100;
    Random rnd = new Random();
    int[] rndArr = new int [8];
    for (int i = 0; i < rndArr.Length; i++)
    {
        rndArr[i] = rnd.Next(minSizeArray, maxSizeArray);
    }
    return rndArr;
}

int SumOfOddIndexElements(int[] array)
{	
    int sum = 0;
    for ( int i = 1; i < array.Length; i+=2) //i=i+2
    {
        sum = sum + array[i]; 
    }
    return sum;

}
