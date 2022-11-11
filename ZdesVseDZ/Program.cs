/*  1.Пользователь вводит 2 числа (A и B). Выведите в консоль результат деления A 
на B и остаток от деления. 
 
int a = Convert.ToInt32(Console.ReadLine()); 
int b = Convert.ToInt32(Console.ReadLine()); 
Console.WriteLine(a / b); 
Console.WriteLine(a % b);  
*/

/* 2.Пользователь вводит 2 числа (A и B). Выведите в консоль решение 
 
int a = Convert.ToInt32(Console.ReadLine()); 
int b = Convert.ToInt32(Console.ReadLine()); 
int c = (5 * a + b * b ) /( b - a ); 
Console.WriteLine( c ); */

/* 3.Пользователь вводит 2 строковых(string) значения(A и B). Поменяйте 
содержимое переменных A и B местами. 
 
string  a = Console.ReadLine(); 
string b = Console.ReadLine(); 
string tmp = a; 
a = b; 
b = tmp; 
Console.WriteLine(a); 
Console.WriteLine(tmp); 
*/

/* 4.Пользователь вводит 3 не равных 0 числа (A, B и С). Выведите в консоль 
решение(значение X) линейного уравнения стандартного вида, где A*X+B=C. 
 
int a = Convert.ToInt32(Console.ReadLine()); 
int b = Convert.ToInt32(Console.ReadLine()); 
int c = Convert.ToInt32(Console.ReadLine()); 
int x = (c - b) / a; 
Console.WriteLine(x);*/

/* 5.Пользователь вводит 4 числа (X1, Y1, X2, Y2), описывающие координаты 2-х 
точек на координатной плоскости. Выведите уравнение прямой в формате 
Y=AX+B, проходящей через эти точки. 
int x1 = Convert.ToInt32(Console.ReadLine()); 
int x2 = Convert.ToInt32(Console.ReadLine()); 
int y1 = Convert.ToInt32(Console.ReadLine()); 
double y2 = Convert.ToDouble(Console.ReadLine()); 
 
double a = (double)(y2 - y1) / (x2 - x1); 
double b = y1 - a * x1; 
 
Console.WriteLine($"{a} * X + {b} = 0"); */
#region 1ое задание 
/* int a = Convert.ToInt32(Console.ReadLine()); 
int b = Convert.ToInt32(Console.ReadLine()); 
if (a > b) 
{ 
    Console.WriteLine(a + b); 
} 
if (a == b) 
{ 
    Console.WriteLine(a * b); 
} 
if (a < b) 
{ 
    Console.WriteLine(a - b); 
} */
#endregion

#region 2ое задание 
/*int x = Convert.ToInt32(Console.ReadLine()); 
int y = Convert.ToInt32(Console.ReadLine()); 
if (x > 0 && y > 0) 
{ 
    Console.WriteLine("1 cetvert"); 
} 
if (x > 0 && y < 0) 
{ 
    Console.WriteLine("4 cetvert"); 
} 
if (x < 0 && y > 0) 
{ 
    Console.WriteLine("2 cetvert"); 
} 
if (x < 0 && y < 0) 
{ 
    Console.WriteLine("3 cetvert"); 
} */
#endregion

#region 3ое задание 
/*int a = Convert.ToInt32(Console.ReadLine()); 
int b = Convert.ToInt32(Console.ReadLine()); 
int c = Convert.ToInt32(Console.ReadLine()); 
if (a > b && a > c) 
{ 
    if (b > c) 
        Console.WriteLine("B<C<A"); 
    else 
        Console.WriteLine("C<B<A"); 
} 
if (b >a && b > c) 
{ 
    if (a > c) 
        Console.WriteLine("C<A<B"); 
    else 
        Console.WriteLine("A<C<B"); 
} 
if (c >a && c > b) 
{ 
    if (a > b) 
        Console.WriteLine("B<A<C"); 
    else 
        Console.WriteLine("A<B<C"); 
} */
#endregion

#region 4ое задание 
/*int a = Convert.ToInt32(Console.ReadLine());     
int b = Convert.ToInt32(Console.ReadLine()); 
int c = Convert.ToInt32(Console.ReadLine()); 
double d = b * b - (4 * a * c); 
if (d > 0) 
{ 
    double x1 = (-b + Math.Sqrt(d)) / (2 * a); 
    double x2 = (-b - Math.Sqrt(d)) / (2 * a); 
    Console.WriteLine($"x1 = {x1}, x2 = {x2}"); 
} 
else if (d == 0) 
{ 
    double x1 = (-b) / (2 * a); 
    Console.WriteLine("x1 = " + x1); 
} 
else 
{ 
    Console.WriteLine("No roots!"); 
} */
#endregion
/*  1.Пользователь вводит 2 числа (A и B). Выведите в консоль результат деления A 
на B и остаток от деления. 
 
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(a / b);
Console.WriteLine(a % b);
*/

/* 2.Пользователь вводит 2 числа (A и B). Выведите в консоль решение 
 
int a = Convert.ToInt32(Console.ReadLine()); 
int b = Convert.ToInt32(Console.ReadLine()); 
int c = (5 * a + b * b ) /( b - a ); 
Console.WriteLine( c ); */

/* 3.Пользователь вводит 2 строковых(string) значения(A и B). Поменяйте 
содержимое переменных A и B местами. 
 
string  a = Console.ReadLine(); 
string b = Console.ReadLine(); 
string tmp = a; 
a = b; 
b = tmp; 
Console.WriteLine(a); 
Console.WriteLine(tmp); 
*/

/* 4.Пользователь вводит 3 не равных 0 числа (A, B и С). Выведите в консоль 
решение(значение X) линейного уравнения стандартного вида, где A*X+B=C. 
 
int a = Convert.ToInt32(Console.ReadLine()); 
int b = Convert.ToInt32(Console.ReadLine()); 
int c = Convert.ToInt32(Console.ReadLine()); 
int x = (c - b) / a; 
Console.WriteLine(x);*/

/* 5.Пользователь вводит 4 числа (X1, Y1, X2, Y2), описывающие координаты 2-х 
точек на координатной плоскости. Выведите уравнение прямой в формате 
Y=AX+B, проходящей через эти точки. 
int x1 = Convert.ToInt32(Console.ReadLine()); 
int x2 = Convert.ToInt32(Console.ReadLine()); 
int y1 = Convert.ToInt32(Console.ReadLine()); 
double y2 = Convert.ToDouble(Console.ReadLine()); 
 
double a = (double)(y2 - y1) / (x2 - x1); 
double b = y1 - a * x1; 
 
Console.WriteLine($"{a} * X + {b} = 0"); */
#region 1ое задание 
/* int a = Convert.ToInt32(Console.ReadLine()); 
int b = Convert.ToInt32(Console.ReadLine()); 
if (a > b) 
{ 
    Console.WriteLine(a + b); 
} 
if (a == b) 
{ 
    Console.WriteLine(a * b); 
} 
if (a < b) 
{ 
    Console.WriteLine(a - b); 
} */
#endregion

#region 2ое задание 
/*int x = Convert.ToInt32(Console.ReadLine()); 
int y = Convert.ToInt32(Console.ReadLine()); 
if (x > 0 && y > 0) 
{ 
    Console.WriteLine("1 cetvert"); 
} 
if (x > 0 && y < 0) 
{ 
    Console.WriteLine("4 cetvert"); 
} 
if (x < 0 && y > 0) 
{ 
    Console.WriteLine("2 cetvert"); 
} 
if (x < 0 && y < 0) 
{ 
    Console.WriteLine("3 cetvert"); 
} */
#endregion

#region 3ое задание 
/*int a = Convert.ToInt32(Console.ReadLine()); 
int b = Convert.ToInt32(Console.ReadLine()); 
int c = Convert.ToInt32(Console.ReadLine()); 
if (a > b && a > c) 
{ 
    if (b > c) 
        Console.WriteLine("B<C<A"); 
    else 
        Console.WriteLine("C<B<A"); 
} 
if (b >a && b > c) 
{ 
    if (a > c) 
        Console.WriteLine("C<A<B"); 
    else 
        Console.WriteLine("A<C<B"); 
} 
if (c >a && c > b) 
{ 
    if (a > b) 
        Console.WriteLine("B<A<C"); 
    else 
        Console.WriteLine("A<B<C"); 
} */
#endregion

#region 4ое задание 
/*int a = Convert.ToInt32(Console.ReadLine());     
int b = Convert.ToInt32(Console.ReadLine()); 
int c = Convert.ToInt32(Console.ReadLine()); 
double d = b * b - (4 * a * c); 
if (d > 0) 
{ 
    double x1 = (-b + Math.Sqrt(d)) / (2 * a); 
    double x2 = (-b - Math.Sqrt(d)) / (2 * a); 
    Console.WriteLine($"x1 = {x1}, x2 = {x2}"); 
} 
else if (d == 0) 
{ 
    double x1 = (-b) / (2 * a); 
    Console.WriteLine("x1 = " + x1); 
} 
else 
{ 
    Console.WriteLine("No roots!"); 
} */
#endregion
Console.WriteLine(Peremenniye.DivisionOfTwoNumbers(77,11));