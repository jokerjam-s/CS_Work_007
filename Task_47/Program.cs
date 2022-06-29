/**
* * Задача 47
*   Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
*
*   m = 3, n = 4.
*   0,5 7 -2 -0,2
*   1 -3,3 8 -9,9
*   8 7,8 -7,1 9
*/

// минимальная, максимальная границы для генерации значений массива
// генерируются целочисленные значения с переводом в double
const int lowValue = -1000;
const int highValue = 1001;

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


// генерация двумерного массива типа double
// параметры:
//      rowCnt - количество строк
//      colCnt - количество колонок
// возврат:
//      двумерный вещественный массив, указанной размерности, 
//      заполненный значениями от -10 до 10 
double[,] GenerateArray(int rowCnt, int colCnt)
{
    double[,] array = new double[rowCnt, colCnt];
    Random rndNum = new Random();

    for (int i = 0; i < rowCnt; i++)
    {
        for (int j = 0; j < colCnt; j++)
        {
            array[i, j] = (double)rndNum.Next(lowValue, highValue) / 100;
        }
    }

    return array;
}


// вывод на экран двумерного вещественного массива
// параметры:
//      array - массив для печати
// вывод:
//      нет    
void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(String.Format("{0,6:0.00}\t", array[i, j]));
        }
        Console.WriteLine();
    }
}


// main body
Console.Clear();

int rowCnt = InputNumber("Input rows count:");
int columnCnt = InputNumber("Input columns count:"); 

double[,] array = GenerateArray(rowCnt, columnCnt);
PrintArray(array);