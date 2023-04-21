// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных
// чисел. Напишите программу, которая будет построчно выводить массив,
// добавляя индексы каждого элемента.

int[, ,] DifferentNumbersMatrixСube(int[, ,] array, int leftRange, int rightRange)
{
    int numberN = array[0, 0, 0];
    int k = 0;
    int i = 0;
    int j = 0;
    for (int c = 0; c < array.GetLength(2); c++)
    {
        for (int a = 0; a < array.GetLength(0); a++)
        {
            for (int b = 0; b < array.GetLength(1); b++)
            {
                numberN = array[a,b,c];
                int z = b + 1;
                   for (i = 0; i < array.GetLength(0); i++)
                   {
                        for (j = z; j < array.GetLength(1); j++)
                        {
                            for (k = 0; k < array.GetLength(2); k++)
                            {
                                if(array[i,j,k] == numberN)
                                {

                                   array[i,j,k] = new Random().Next(leftRange, rightRange + 1);

                                }
                            }
                        }
                   }
                
            }
        }
    }
    return array;
}

void ShowArray(int[, ,] array)
{
    for (int k = 0; k < array.GetLength(2); k++)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write($"{array[i,j,k]}({i},{j},{k}) "); 
            }
            Console.WriteLine();
        }
    }
}

int[, ,] CreateRandomArray(int x, int y, int z, int leftRange, int rightRange)
{
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

    int[, ,] array = new int[x, y, z];
    for (int k = 0; k < array.GetLength(2); k++)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                array[i,j,k] = new Random().Next(leftRange, rightRange + 1);
            }
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

// получить от пользователя X, Y, Z матрицы
int x = EnterNumber("введите количество элементов X ");
int y = EnterNumber("введите количество элементов Y ");
int z = EnterNumber("введите количество элементов Z ");

// создать трехмерный массив и заполнить 
int[, ,] matrixСube = CreateRandomArray(x, y, z, 10, 98); // Создать случайный массив

ShowArray(matrixСube);

 Console.WriteLine();

// сверяем массив на повторяющиеся числа и меняем их
int[, ,] matrixСubeDifferent = DifferentNumbersMatrixСube(matrixСube, 10, 98);

ShowArray(matrixСubeDifferent);