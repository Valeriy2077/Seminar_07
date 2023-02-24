// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.

// 0,5 7 -2 -0,2

// 1 -3,3 8 -9,9

// 8 7,8 -7,1 9

int[,] FillMatrix(int rows, int cols)

{
    Random rand = new Random();
    int [,] mat = new int[rows, cols];

    for(int i = 0; i < rows; i++)
{
    for(int j= 0; j < cols; j++)
    {
        mat[i,j] = rand.Next(0,100);
    }
}

    return mat;

}

void PrintMatrix(int[,] mat)
{

for(int i = 0; i < mat.GetLength(0); i++)
{
    for(int j= 0; j < mat.GetLength(1); j++)
    {
        System.Console.Write(mat[i,j] + "\t");
    }

    System.Console.WriteLine();
}

}
System.Console.WriteLine("Введите m и n: ");
int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());
int[,] mat = FillMatrix (m,n);
PrintMatrix(mat);

