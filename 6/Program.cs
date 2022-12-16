int[] CreateRandomArray(int size, int minValie, int maxValue)
{
    int[] array = new int[size];

    for(int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(minValie, maxValue +1);
    }
    return array;
}


void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.WriteLine($"Array [{i +1}] is {array[i]} ");
    }
    
}



//Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, а первый - на последнем и т.д.)

// void ReversArray(int[] array)
// {
//     for(int i = 0; i < array.Length / 2; i++)  // for(int i = 0, j = array.length - 1; i < j; i++, j-- )
//     {
//         int temp = array[i];
//         array[i] = array[array.Length - i -1]; // array[i] = array[j];
//         array[array.Length - i -1] = temp;     // array[j] = temp;

//     }
    

// }


// Console.Write("Input number of elements: ");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input min elemrnts: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input max elements: ");
// int max = Convert.ToInt32(Console.ReadLine());

// int[] userarray = CreateRandomArray(size, min, max);
// ShowArray(userarray);
// ReversArray(userarray);
// ShowArray(userarray);

// Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.

// bool Treug(double a, double b, double c)
// {
//     if(a + b > c)
//         if(b + c > a)
//             if(a + c > b)
//                 return true;
//     return false;
// }

// Console.Write("Input number A: ");
// int numA = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input number B: ");
// int numB = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input number C: ");
// int numC = Convert.ToInt32(Console.ReadLine());

// bool result = Treug(numA, numB, numC);
// Console.WriteLine(result);

//Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: a и b.

// int[] Fibanacci(int a, int b, int n)
// {
//     int[] array = new int[n];
//     array[0] = a;
//     array[1] = b;
//     for(int i = 2; i < n; i++)    
//         array[i] = array[i-1] + array[i -2];     
    
//     return array;
// }

// Console.Write("Input number A: ");
// int numA = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input number B: ");
// int numB = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input number of last Fibonacci: ");
// int numC = Convert.ToInt32(Console.ReadLine());

// int[] userarray = Fibanacci(numA, numB, numC);

// ShowArray(userarray);


//Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.

// int[] CopyArray(int[] array)
// {
//     int[] copyArray = new int[array.Length];
//     for(int i = 0; i < array.Length; i++)
//     {
//         copyArray[i] = array[i];
//     }
//     return copyArray;
// }

// Console.Write("Input number of elements: ");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input min elemrnts: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input max elements: ");
// int max = Convert.ToInt32(Console.ReadLine());

// int[] userarray = CreateRandomArray(size, min, max);
// ShowArray(userarray);

// int[] secondArrray = CopyArray(userarray);
// ShowArray(secondArrray);