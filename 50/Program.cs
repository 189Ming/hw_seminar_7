// Задача 50. Напишите программу, которая 
// на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же 
// указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 1, 7 -> такого элемента в массиве нет

Console.WriteLine("Введите номер строки: ");
int firstIndex = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите номер столбца: ");
int secondIndex = Convert.ToInt32(Console.ReadLine());


int[,] matrix1 = CreateMatrixRndInt(4, 4, 0, 10);
PrintMatrix(matrix1);
int[,] position = PositionElement(matrix1, firstIndex, secondIndex);


int[,] PositionElement(int[,] matrix, int A, int B)
{
    Console.Write($" Ваш элемент: {matrix[A - 1, B - 1]}");
    return matrix;
    
}

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{

    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j],5} ");
        }
        Console.WriteLine(" |");
    }
}

