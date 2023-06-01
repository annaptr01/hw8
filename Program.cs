//Задача 47. Задайте двумерный массив размером m×n, заполненный случайными 
//вещественными числами.
//m = 3, n = 4.
//0,5 7 -2 -0,2
//1 -3,3 8 -9,9
//8 7,8 -7,1 9

/*
double [,] Create2dArray ()
{
    Console.WriteLine("Enter count of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter count of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter minimum: ");
    int minVal = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter maximum: ");
    int maxVal = Convert.ToInt32(Console.ReadLine());
    double [,] createdArray = new double [rows, columns];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            createdArray[i,j] = Math.Round((new Random().Next(minVal, maxVal)) + (new Random().NextDouble()), 2);
        }
    }
    return createdArray;
}

void Show2DArray (double [,] array2D)
{
     for(int i = 0; i < array2D.GetLength(0); i++) 
    {
        for(int j = 0; j < array2D.GetLength(1); j++)
        { 
            Console.Write(array2D[i,j] + " "); 
        }
        Console.WriteLine(); 
    }
    Console.WriteLine();
}

double [,] new2dArray = Create2dArray();
Show2DArray(new2dArray);
*/

//Задача 50. Напишите программу, которая на вход принимает позиции элемента 
//в двумерном массиве, и возвращает значение этого элемента или же указание, 
//что такого элемента нет.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//17 -> такого числа в массиве нет
/*
int [,] Create2DArray (int rows, int columns, int min, int max)
{
    int [,] array2D = new int [rows, columns];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array2D[i,j] = new Random().Next(min, max + 1);
        }
    }
    return array2D;
}

void Show2DArray (int [,] array2D)
{
    for (int i = 0; i < array2D.GetLength(0); i++)
    {
        for (int j = 0; j < array2D.GetLength(1); j++)
        {
            Console.Write(array2D[i,j] + " ");
        }
    Console.WriteLine();
    }
    Console.WriteLine();
}

int [,] ElementReturner (int [,] array2D)
{
    
    for (int i = 0; i < array2D.GetLength(0); i++)
    {
        
         for (int j = 0; j < array2D.GetLength(1); j++)
        {  
           int temp = array2D[i,j];
           if(array2D[i,j] == array2D.GetLength(0) && array2D[i,j] == array2D.GetLength(1))
           {
            
            Console.WriteLine($"Element {temp} exist in array!");
           }
           else
            Console.WriteLine($"Element {temp} doesn`t exist in array!");
        }
    }
    return array2D;

}
Console.WriteLine("Enter count of rows: ");
int userRows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter count of columns: ");
int userColumns = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter minimum: ");
int userMin = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter maximum: ");
int userMax = Convert.ToInt32(Console.ReadLine());

int [,] createdArray = Create2DArray(userRows, userColumns, userMin, userMax);
Show2DArray(createdArray);
Console.WriteLine();
int [,] changedArray = ElementReturner(createdArray);
Show2DArray(changedArray);
*/


//Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее 
//арифметическое элементов в каждом столбце.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
//среднее арифметическое - это сумма элементов деленная на их количество

int [,] Create2DArray (int rows, int columns, int min, int max)
{
    int [,] array2D = new int [rows, columns];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array2D[i,j] = new Random().Next(min, max + 1);
        }
    }
    return array2D;
}

void Show2DArray (int [,] array2D)
{
    for (int i = 0; i < array2D.GetLength(0); i++)
    {
        for (int j = 0; j < array2D.GetLength(1); j++)
        {
            Console.Write(array2D[i,j] + " ");
        }
    Console.WriteLine();
    }
    Console.WriteLine();
}

int [,] ArifmeticheskoyCols(int [,] array2D)
{
    int sum = 0;
    int [,] newArray;
    for(int j = 0; j < array2D.GetLength(1); j++) 
    {
        for(int i = 0; i < array2D.GetLength(0); i++)
        {
            sum = sum + array2D[i, j];
            sum /= array2D.GetLength(0);
            int [,] newArray = array2D[j];
            newArray[i, j] = sum;
        }
       return array2D;
    }    
}

Console.WriteLine("Enter count of rows: ");
int userRows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter count of columns: ");
int userColumns = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter minimum: ");
int userMin = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter maximum: ");
int userMax = Convert.ToInt32(Console.ReadLine());

int [,] createdArray = Create2DArray(userRows, userColumns, userMin, userMax);
Show2DArray(createdArray);
Console.WriteLine();
int [,] changedArray = ArifmeticheskoyCols(createdArray);
Show2DArray(changedArray);
