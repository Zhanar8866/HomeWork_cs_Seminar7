/* Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/

Console.Write("Введите количество строк массива: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов массива: ");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] array = CreateArray(rows, columns, 0, 10);
ShowArray(array);

Average(array);

int[,] CreateArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}

void ShowArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write(inArray[i,j] + " ");
        }
            Console.WriteLine();
    }

}

void Average (int[,] inArray)
{
    double[] Column = new double[inArray.GetLength(1)];
    for (int i = 0; i < inArray.GetLength(1); i++) Column[i] = 0;
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Column[j] = Column[j] + inArray[i,j];
        }
    }
    for (int i = 0; i < inArray.GetLength(1); i++) 
    {
        Console.WriteLine(Column[i]);
        Column[i] = Math.Round((Column[i]/inArray.GetLength(0)),2);
        Console.WriteLine($"Среднее значение столбца {i+1} равно {Column[i]}");
    }
}