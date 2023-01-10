﻿int[,] CreateRandom2DArray()
{
    Console.Write("Input number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input number of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input min elemrnts: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input max elements: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());

    int[,] array = new int[rows, columns];

    for(int i = 0; i < rows; i++)    
        for(int j = 0; j < columns; j++)
            array[i,j] = new Random().Next(minValue, maxValue +1);        
    
    return array;

}   



void Show2DArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)  
        {
            Console.Write(array[i,j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}


int[,] userArray = CreateRandom2DArray();
Show2DArray(userArray);


//Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы.

// void Revers2DArray(int[,] array)
// {
//     if(array.GetLength(0) == array.GetLength(1))
//     {
//         for(int i = 0; i < array.GetLength(0) - 1; i++)
//             for(int j = i + 1; j < array.GetLength(1); j++)
//             {
//                 int temp = array[i,j];
//                 array[i,j] = array[j,i];
//                 array[j,i] = temp;

//             }
//     }
// }

// Revers2DArray(userArray);
// Show2DArray(userArray);



// Задача1: Задайте двумерный массив. Напишите программу, которая поменяет местами любые 2 строки массива.

void CreateNewArray(int[,] array, int numA, int numB)
{
    if( numA != numB && numA >= 0 && numB >= 0 && numA < array.GetLength(0) && numB < array.GetLength(0))
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            int temp = array[numA,j];
            array[numA,j] = array[numB,j];
            array[numB,j] = temp;
        }
    }
    else Console.WriteLine("No row");
}
int[,] myArray = CreateRandom2DArray();
Show2DArray(myArray);
Console.WriteLine("Input first row");
int indA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input second row");
int indB = Convert.ToInt32(Console.ReadLine());
CreateNewArray(myArray, indA, indB);
Show2DArray(myArray);



// Задача1: Из двумерного массива целых чисел удалить строку и столбец, на пересечении которых расположен наименьший элемент.

int[] MinElement(int[,] array)
{
    int[] min = new int[2];
    int temp = array[0,0];
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            if(array[i,j] < temp)
            {
                temp = array[i,j];
                min[0] = i;
                min[1] = j;
            }
        }
    }
    return min;
}
int[,] CutArray(int[,] array, int minI, int minJ)
{
    int[,] cutArray = new int [array.GetLength(0)- 1, array.GetLength(1) - 1];
    for(int i = 0, x = 0; i < array.GetLength(0);i++, x++)
    {
        if(i != minI)
        {
            for(int j = 0, y = 0; j < array.GetLength(1);j++, y++)
            {
                if( j != minJ)
                {
                    cutArray[x,y] = array[i,j];
                }
                else y--;
            }
        }
        else x--;
    }
    return cutArray;
}

int[] minArray = MinElement(myArray);
int[,] cutNewArray = CutArray(myArray, minArray[0], minArray[1]);
Show2DArray(cutNewArray);

