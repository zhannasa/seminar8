// Задача 58: Задайте две матрицы. Напишите программу, 
//которая будет находить произведение двух матриц.
//Например, даны 2 матрицы:
//2 4 | 3 4
//3 2 | 3 3
//Результирующая матрица будет:
//18 20
//15 18


int ReadNumberFromConsole(string message = "")
{
    if (message != "") Console.Write(message);
    string input = Console.ReadLine()!;
    return int.Parse(input);
}
void FillArrayRandomNumbers(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 5);
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.Write("]");
        Console.WriteLine("");
    }
}

int size = ReadNumberFromConsole("Matrix size: ");
int[,] matrixA = new int[size, size];
int[,] matrixB = new int[size, size];
FillArrayRandomNumbers(matrixA);
FillArrayRandomNumbers(matrixB);
int[,] matrixC = new int[size, size];
MultMatrices(matrixC);

void MultMatrices (int[,] array)
{
    for (int i = 0; i < size; i++)
    {
        for (int j = 0; j < size; j++)
        {
            for (int k = 0; k < size; k++)
            {
                matrixC[i, j] = matrixC[i, j] + (matrixA[i, k] * matrixB[k, j]);
            }
        }
    }
}
Console.WriteLine("Matrix - A");
PrintArray(matrixA);
Console.WriteLine();
Console.WriteLine("Matrix - B");
PrintArray(matrixB);
Console.WriteLine();
Console.WriteLine("Product of matrices is A*B");
PrintArray(matrixC);