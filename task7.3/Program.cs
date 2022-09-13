// Задайте 2мер массив из целых чисел. Найдите ср. арифм. эл-ов в 
//каждом столбце.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
Console.WriteLine("Введи количество строк:");
int linesCount = int.Parse(Console.ReadLine());
Console.WriteLine("Введи количество столбцов:");
int columnsCount = int.Parse(Console.ReadLine());
int [,] twoDimArray = new int[linesCount, columnsCount];
Random rand = new Random();
//                                              формируем массив чисел
for (int i=0; i<linesCount; i++)
{
    for (int j=0; j<columnsCount; j++)
    {
        twoDimArray[i,j] = rand.Next(1, 100);
        Console.Write(twoDimArray[i,j] + " ");
    }
    Console.WriteLine();
}
//                                              формируем массив средних
double [] averageArray = new double[columnsCount];
for (int j=0; j<columnsCount; j++)
{ //                                            новый массив по кол-ву колонок
    double average = 0;
    double total = 0;
    for (int i=0; i<linesCount; i++)
    {
        total += (twoDimArray[i,j]);
    }
    average = total / linesCount;
    averageArray[j] = Math.Round(average, 1);
}
Console.WriteLine(string.Join("; ", averageArray)); // вывод массива