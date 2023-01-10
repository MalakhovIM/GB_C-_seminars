//Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.

// void ShowNum(int num)
// {
//     if(num > 1)
//         ShowNum(num -1);
//     Console.Write(num + " ");
// }

// ShowNum(5);

//Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.

// int GetSumOfDigits(int num)
// {
//     if(num != 0) return GetSumOfDigits(num / 10) + num % 10;
//         else return 0;

// }

// Console.WriteLine(GetSumOfDigits(125));

//Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.

void SeriesNumsFromMToN(int m, int n)
{
    if(m < n) 
    {
        SeriesNumsFromMToN(m, n - 1);
        Console.Write(n + " ");
    }
    
    if(n < m)
    {
        Console.Write(m + " ");
        SeriesNumsFromMToN(m - 1, n); 
    }
    if(n == m) Console.Write(m + " ");
}
SeriesNumsFromMToN(5, 2);



//Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B. 1/a b

double Power(int basic, int degree)
{
    if(degree > 0) return Power(basic, degree - 1) * basic;
    else if(degree < 0) return Power(basic, degree + 1) / basic;
    else return 1;
}
Console.WriteLine(Power(2, -3));