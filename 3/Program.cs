//Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

// int FindQuadrant(double x, double y)
// {
//     if(x > 0 && y > 0) return 1;
//     if(x < 0 && y > 0) return 2;
//     if(x < 0 && y < 0) return 3;
//     if(x > 0 && y < 0) return 4;
//     return 0;
// }

// Console.Write("Input x ");
// double xa = Convert.ToDouble(Console.ReadLine());
// Console.Write("Input y ");
// double ya = Convert.ToDouble(Console.ReadLine());

// int quadnum = FindQuadrant(xa, ya);
// Console.WriteLine($"The point A({xa} , {ya}) in on the {quadnum} quadrant");

// Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).

// void ShowDiap(int a)
// {
//     if(a > 0 && a < 5)
//     {
//         if(a == 1)
//             Console.WriteLine("Диапозон значений x от 0 до +8, диапозон y от 0 до +8 ");
//         if(a == 2)
//             Console.WriteLine("Диапозон значений x от 0 до -8, диапозон y от 0 до +8 ");
//         if(a == 3)
//             Console.WriteLine("Диапозон значений x от 0 до -8, диапозон y от 0 до -8 ");
//         if(a == 4)
//             Console.WriteLine("Диапозон значений x от 0 до +8, диапозон y от 0 до -8 ");
//     }
//     else
//         Console.WriteLine("Заданной четверти не существует");
// }

// Console.WriteLine("Задайте значение четверти координатной сетки ");
// int diap = Convert.ToInt32(Console.ReadLine());
// ShowDiap(diap);

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.

// double Length(double xa, double ya, double xb, double yb)
// {
//     double x = xb - xa;
//     double y = yb - ya;
//     double result = Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));
//     return result;

// }

// Console.Write("input xA ");
// int x1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("input yA ");
// int y1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("input xB ");
// int x2 = Convert.ToInt32(Console.ReadLine());
// Console.Write("input uA ");
// int y2 = Convert.ToInt32(Console.ReadLine());

// double lengthResult = Length(x1, y1, x2, y2);

// Console.WriteLine("Расстояние между точками " + lengthResult);

// Напишите программу, которая принимает на вход число (N) и выдаёт ряд квадратов чисел от 1 до N.

// void Quad(int num)
// {
//     int step = 1;
//     while(step < num)
//     {
//         double result =Math.Pow(step, 2);
//         Console.Write(result + " ");
//         step++;
//     }
// }

// Console.Write("Введите число ");
// int usernum = Convert.ToInt32(Console.ReadLine());
// Quad(usernum);

