// Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

Console.Clear();
int rous = NumberFromUser ("Введите количество строк массива: ","Ошибка ввода!");
int columns = NumberFromUser ("Введите количество столбцов массива: ","Ошибка ввода!");
int[,] array = GetArray (rous, columns, 0, 10);
PrintArray(array);

for (int j = 0; j < columns; j++)
{
    double averageSum = 0;
    for (int i = 0; i < rous; i++)
    {
        averageSum += array[i,j];
    }
    averageSum = Math.Round(averageSum/rous,2);   
    Console.WriteLine($"Среднее арифметическое всех элементов столбца {j} -> {averageSum}");
}

// возвращает количество элементов (строк и столбцов) массива, либо сообщение об ошибке

int NumberFromUser (string message, string errorMessage)
{
    while(true)
    {
        Console.Write(message);
        bool isCorrect = int.TryParse(Console.ReadLine(), out int userNumber);
        if (isCorrect)
            return userNumber;
        Console.WriteLine(errorMessage);
    }
}

// возвращает массив размером mxn 

int[,] GetArray (int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i,j] = new Random().Next(minValue, maxValue + 1);
;
        }
    }
    return result;
}

// выводит массив в консоль

void PrintArray (int [,] inArray)
{
for (int i = 0; i < inArray.GetLength(0); i++)
{
    for (int j = 0; j < inArray.GetLength(1); j++)
    {
       Console.Write($"{inArray[i,j]} "); 
    }
    Console.WriteLine();
}
}

/*double averageSum = AverageSumInColumn (array, rous, columns);
Console.WriteLine($"Среднее арифметическое {averageSum}");
// возвращает среднее арифметическое элементов в каждом столбце
double AverageSumInColumn (int[,] ourArray, int doneRous, int doneColumns)
{
for (int j=0; j < ourArray.GetLength(1); j++)
{   
    int sum = 0;
    for (int i = 0; i < ourArray.GetLength(0); i++)
    {
       sum += ourArray[i,j];
    }
    double average = (double) sum/doneRous;
}
return average;
}*/