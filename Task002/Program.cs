// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

Console.Clear();
int rous = NumberFromUser ("Введите количество строк массива: ","Ошибка ввода!");
int columns = NumberFromUser ("Введите количество столбцов массива: ","Ошибка ввода!");
int[,] array = GetArray (rous, columns, 0, 10);
int i = NumberFromUser ("Введите номер элемента в строке ","Ошибка ввода!");
int j = NumberFromUser ("Введите номер элемента в столбце: ","Ошибка ввода!");
PrintArray(array);
int position = ResultPosition (array, rous, columns, i, j);

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

// возвращает значение элемента на указанной позиции

int ResultPosition (int[,] ourArray, int doneRous, int doneColumns, int iRous, int jColumns)
{
if (iRous <= doneRous && jColumns <= doneColumns)
{
    Console.WriteLine($"Значение элемента в позиции ({iRous};{jColumns}) : {ourArray[iRous-1, jColumns-1]} ");
}
else
{
    Console.WriteLine($"({iRous};{jColumns}) -> такого числа в массиве нет!");
}
return ourArray[iRous-1, jColumns-1];
}