/* Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет
*/

Console.Write("Введите количество строк массива: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов массива: ");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] array = CreateArray(rows, columns, -100, 100);
ShowArray(array);

Console.Write("Введите число, которое необходимо найти в массиве: ");
int f = Convert.ToInt32(Console.ReadLine());
FindNumber(array, f);

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

void FindNumber(int[,] inArray, int find)
{
    int s = 0;
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            if (inArray[i,j] == find) s+=1;
        }
    }
    if (s != 0) Console.Write($"Число {find} в массиве имеется");
    else 
    {
        Console.Write("Такого числа в массиве нет");
    }
}