// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

Console.Clear();
int rous = NumberFromUser ("Введите количество строк массива: ","Ошибка ввода!");
int columns = NumberFromUser ("Введите количество столбцов массива: ","Ошибка ввода!");
double[,] array = GetArray(rous, columns);
PrintArray (array);

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

double [,] GetArray (int m, int n)
{
    double[,] result = new double[m, n];
    Random rand = new Random();
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i,j] = rand.NextDouble()*100;
        }
    }
    return result;
}

// выводит массив в консоль

void PrintArray (double [,] inArray)
{
for (int i = 0; i < inArray.GetLength(0); i++)
{
    for (int j = 0; j < inArray.GetLength(1); j++)
    {
       Console.Write("{0,6:F2}", inArray[i,j]); 
    }
    Console.WriteLine();
}
}