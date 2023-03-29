// Задайте две матрицы. напишите программу, которая будет находить
// произведение двух матриц.

void MatrixNaMatrix(int[,] matrixA, int[,] matrixB)
{
    int[,] matrixC = new int[matrixA.GetLength(0), matrixB.GetLength(1)];
    
    ShowArray(matrixC);

    Console.WriteLine();

    for (int k = 0; k < matrixB.GetLength(1); k++)
    {

        for (int i = 0; i < matrixA.GetLength(0); i++)
        {
            int sum1 = 0;
            for (int j = 0; j < matrixA.GetLength(1); j++)
            {
                sum1 += matrixA[i,j] * matrixB[j,k];
            }
            matrixC[i,k] = sum1; 
        }
    }
    ShowArray(matrixC);
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

// получить от пользователя Arows и Acolumns первой матрицы
int iA = EnterNumber("введите количество строк Arows ");
int jA = EnterNumber("введите количество столбцов Acolumns ");

// получить от пользователя Brows и Bcolumns второй матрицы
int iB = EnterNumber("введите количество строк Brows ");
int jB = EnterNumber("введите количество столбцов Bcolumns ");

// создать двумерный массив и заполнить 
int[,] matrixA = CreateRandomArray(iA, jA, 1, 9); // Создать случайный массив

// создать двумерный массив и заполнить 
int[,] matrixB = CreateRandomArray(iB, jB, 1, 9); // Создать случайный массив

ShowArray(matrixA);

Console.WriteLine();

ShowArray(matrixB);

Console.WriteLine();

// создание matrixС из произведения matrixA и matrixB
MatrixNaMatrix(matrixA, matrixB);