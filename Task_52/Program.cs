/**
*
* * Задача 52: Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
*
*   Например, задан массив:
*   1 4 7 2
*   5 9 2 3
*   8 4 2 4
*
*   Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*
*   Исходный массив сгенерируем, и заполним значениями от 0 до 100.
*   Большие числа не используем для более лучшего восприятия
**/

// максимальная граница для генерации значений массива
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

// вывод на экран одномерного вещественного массива
// параметры:
//      array - массив для печати
// вывод:
//      нет
void PrintVector(double[] vector)
{
    for (int i = 0; i < vector.GetLength(0); i++)
    {
        Console.Write(String.Format("{0,5:0.00}\t", vector[i]));
    }
}


// main body
Console.Clear();

int rowCnt = InputNumber("Input rows count: ");
int columnCnt = InputNumber("Input columns count: ");

int[,] array = GenerateArray(rowCnt, columnCnt);
PrintArray(array);

// массив для расчета ср. значений
double[] avgValues = new double[array.GetLength(1)];

// расчет средних 
for (int i = 0; i < array.GetLength(1); i++)
{
    double avgColValue = 0;
    for (int j = 0; j < array.GetLength(0); j++)
    {
        avgColValue += array[j, i];
    }
    avgValues[i] = avgColValue / array.GetLength(0);
}

// вывод ср. значений
Console.WriteLine("Average values:");
PrintVector(avgValues);
