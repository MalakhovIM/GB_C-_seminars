// Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.

// int Length(int num)
// {   
//     int result = 0;
//     if(num == 0) result = 1;
//     while(num != 0)
//     {
//         num = num / 10; // temp /= 10;
//         result++;
//     }
//     return result;
// }

// Console.Write("Input number: ");
// int answer = Convert.ToInt32(Console.ReadLine());

// int result = Length(answer);

// Console.WriteLine(result);

//  Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.

// int SumN(int num)
// {
//     int result = 0;
//     for(int count = 1; count <= num; count++)
//     {
//         result += count;
//     }
//     return result;
// }

// Console.Write("Input number: ");
// int sum = Convert.ToInt32(Console.ReadLine());

// int usernum = SumN(sum);
// Console.WriteLine(usernum);


//Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.

// int Fact(int num)
// {
//     int result = 1;
//     for(int count = 2; count <= num; count++)
//     {
//         result *= count;
//     }
//     return result;
// }

// Console.Write("Input number: ");
// int fact = Convert.ToInt32(Console.ReadLine());

// int usernum = Fact(fact);
// Console.WriteLine(usernum);

// Заполнение массива

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

Console.Write("Input number of elements: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min elemrnts: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max elements: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] userarray = CreateRandomArray(size, min, max);
ShowArray(userarray);