// Задайте двумерный массив. Напишите программу, 
// которая упорядочит по убыванию элемнгты каждой строки 
// двумерного массива.

void ShowArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }
}

int[,] OrderingArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
           int max = arr[i,j];
           int countk = j;
           int k = j;
           for(k = j; k < arr.GetLength(1); k++)
           {
              if(arr[i,k] > max)
              {
                max = arr[i,k];
                countk = k;
              }
           }
           int temp = arr[i,j];
           arr[i,j] = max;
           arr[i,countk] = temp;
        }       
    }
    return arr;
}

int[,] CreateRandomArray(int rows, int columns, int leftRange, int rightRange)
{
    int[,] array = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i,j] = new Random().Next(leftRange, rightRange + 1);
        }
    }
    return array;
}

int EnterNumber(string message)  //message - сообщение
{
    Console.Write(message);
    int number = int.Parse(Console.ReadLine());
    return number;
}

// получить от пользователя M и N 
int m = EnterNumber("введите значение m ");
int n = EnterNumber("введите значение n ");

// создать двумерный массив и заполнить 
int[,] matrix = CreateRandomArray(m, n, 1, 9); // Создать случайный массив

ShowArray(matrix);

System.Console.WriteLine();

// упорядочить по убыванию массив
int[,] arr = OrderingArray(matrix);

// вывести массив в консоль
ShowArray(arr);