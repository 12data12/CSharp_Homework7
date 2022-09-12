// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

Console.WriteLine("Enter the number of tne line: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the number of the column: ");
int m = Convert.ToInt32(Console.ReadLine());
int [,] numbers = new int [10,10];
FillArrayRandomNumbers(numbers);

if (n > numbers.GetLength(0) || m > numbers.GetLength(1))
{
    Console.WriteLine("Ooops...There is no such array element.");
}
else
{
    Console.WriteLine($"Array element located in {n} line and {m} column is {numbers[n-1,m-1]}");
}

PrintArray(numbers);

void FillArrayRandomNumbers(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        {        
            for (int k = 0; k < array.GetLength(1); k++)
            {
                array [i,k] = new Random().Next(-100, 100)/10;
            }   
        }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int k = 0; k < array.GetLength(1); k++)
        {
            Console.Write(array[i,k] + " ");
        }   
        Console.Write("]");
        Console.WriteLine(""); 
    }
}
