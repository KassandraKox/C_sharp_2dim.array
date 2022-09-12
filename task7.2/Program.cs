// Напишите программу, которая на вход принимает позиции (две) элемента в 
//двумерном массиве, и возвращает значение этого элемента или же указание, 
//что такого элемента нет.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//17 -> такого числа в массиве нет
Console.WriteLine("Введи количесво строк:");
int linesCount = int.Parse(Console.ReadLine());
Console.WriteLine("Введи количесво столбцов:");
int columnsCount = int.Parse(Console.ReadLine());
int [,] twoDimArray = new int[linesCount, columnsCount];
Random rand = new Random();
//                                                          формируем массив
for (int i=0; i<linesCount; i++)
{
    for (int j=0; j<columnsCount; j++)
    {
        twoDimArray[i,j] = rand.Next(1, 100);
        Console.Write(twoDimArray[i,j] + " ");
    }
    Console.WriteLine();
}
Console.WriteLine("Из какой строки вывести на экран элемент?"); //      определяем индекс элемента
int elementLineIndex = int.Parse(Console.ReadLine());
Console.WriteLine("Из какого столбца вывести на экран элемент?");
int elementColumnIndex = int.Parse(Console.ReadLine());

if (elementLineIndex < linesCount && elementColumnIndex < columnsCount)
{
    
    Console.Write(twoDimArray[elementLineIndex-1,elementColumnIndex-1]); // на печать если входит в массив
}
else
{
    Console.WriteLine("Такого числа в массиве нет"); // иначе
}