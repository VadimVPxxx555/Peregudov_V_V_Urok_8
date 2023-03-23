// Задайте прямоугольный двумерный массив. Напишите программу,
// которая будет находить строку с наименьшей суммой элементов.

void MinStringArray(int[,] arr)
{
    int min = 1000;
    int minstring = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < arr.GetLength(1); j++)
        {
           sum+= arr[i,j]; 
        } 
        if(sum < min)
        {
           min = sum;
           minstring = i;
        }      
    }
    Console.WriteLine("индекс строки с наименьшей суммой элементов " + minstring);
}

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
int m = EnterNumber("введите количество строк m ");
int n = EnterNumber("введите количество столбцов n ");

// создать двумерный массив и заполнить 
int[,] matrix = CreateRandomArray(m, n, 1, 9); // Создать случайный массив

ShowArray(matrix);

System.Console.WriteLine();

//поиск строки с наименьшей суммой элементов и вывод ее индекса в консоль
MinStringArray(matrix);