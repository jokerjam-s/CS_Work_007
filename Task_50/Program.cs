/**
* * Задача 50
*   Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
*   и возвращает значение этого элемента или же указание, что такого элемента нет. Например, задан массив:
*
*   1 4 7 2
*   5 9 2 3
*   8 4 2 4
*
*   17 -> такого числа в массиве нет
*
*   Исходный массив сгенерируем, и заполним значениями от 0 до 100.
*   Большие числа не используем для более лучшего восприятия
**/


// максимальная граница для генерации значений массива
// генерируются целочисленные значения с переводом в double
const int highValue = 100;

// запрос числа у пользователя 
// параметры:
//      message - сообщение, отображаемое пользователю
// возврат:
//      число введенное пользователем в консоли
int InputNumber(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}


// генерация двумерного массива типа int
// параметры:
//      rowCnt - количество строк
//      colCnt - количество колонок
// возврат:
//      двумерный вещественный массив, указанной размерности, 
//      заполненный значениями от 0 до 100 
int[,] GenerateArray(int rowCnt, int colCnt)
{
    int[,] array = new int[rowCnt, colCnt];
    Random rndNum = new Random();

    for (int i = 0; i < rowCnt; i++)
    {
        for (int j = 0; j < colCnt; j++)
        {
            array[i, j] = rndNum.Next(highValue);
        }
    }

    return array;
}


// вывод на экран двумерного целочисленного массива
// параметры:
//      array - массив для печати
// вывод:
//      нет    
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(String.Format("{0,3}\t", array[i, j]));
        }
        Console.WriteLine();
    }
}


// main body
Console.Clear();

int rowCnt = InputNumber("Input rows count (0..9): ");
int columnCnt = InputNumber("Input columns count (0..9): ");

int[,] array = GenerateArray(rowCnt, columnCnt);
PrintArray(array);

int position = InputNumber("Input position: ");

// строка, колонка для поиска элемента
int rowPos = position / 10;
int colPos = position % 10;

if (rowPos < array.GetLength(0) && colPos < array.GetLength(1))
{
    Console.WriteLine($"Item is {array[rowPos, colPos]}");
}
else
{
    Console.WriteLine("Item does not exist.");
}
