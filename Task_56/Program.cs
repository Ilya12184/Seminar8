/*Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
которая будет находить строку с наименьшей суммой элементов.*/

int rows = ReadInt("Введите количество строк: ");
int colums = ReadInt("Введите количество столбцов: ");
int[,] matrix = new int[rows, colums];

void PrintArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();  
    }
} 

void FillArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = new Random().Next(1, 10);
        }    
    }
}

FillArray(matrix);
PrintArray(matrix);
Console.WriteLine();

NumberMinSumElements(matrix);

void NumberMinSumElements(int[,] array)
{
    int minim = 0;
    int minimSumma = 0;
    int summa = 0;
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        minim += matrix[0, i];
    }
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++) summa += matrix[i, j];
        if (summa < minim)
        {
            minim = summa;
            minimSumma = i;
        }
        summa = 0;
    }
    Console.Write($"{minimSumma + 1} строка");
}

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
