// Задайте двумерный массив размером m×n, заполненный случайными вещественными 
//(тип double) числами.
//m = 3, n = 4.
//0,5 7 -2 -0,2
//1 -3,3 8 -9,9
//8 7,8 -7,1 9
Console.WriteLine("Двумерный массив 3х4:");
int linesCount = 3;
int columnsCount = 4;
double [,] twoDimArray = new double[linesCount, columnsCount];
Random rand = new Random();

for (int i=0; i<linesCount; i++)
{
    for (int j=0; j<columnsCount; j++)
    {
        twoDimArray[i,j] = rand.NextDouble()*100;
        Console.Write(Math.Round(twoDimArray[i,j], 2) + " ");
    }
    Console.WriteLine();
}