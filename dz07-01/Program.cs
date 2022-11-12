// Написать программу, упорядочивания по убыванию элементы каждой строки двумерной массива.


void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

void Sortirovka(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int k = j + 1; k < arr.GetLength(1); k++)
            {
                if (arr[i, j] < arr[i, k])
                {
                    int temp = arr[i, j];
                    arr[i, j] = arr[i, k];
                    arr[i, k] = temp;
                }
            }
        }
    }
}

int[,] matrix = new int[,]
{
    {4,5,3,9,4,11,20,78},
    {7,2,9,1,8,25,14,95},
};

PrintArray(matrix);
Console.WriteLine();

Sortirovka(matrix);
PrintArray(matrix);
