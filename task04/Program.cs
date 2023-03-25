//task4
Console.WriteLine("Введите первое число: ");
int a = int.Parse(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
int b = int.Parse(Console.ReadLine());

Console.WriteLine("Введите третье число: ");
int c = int.Parse(Console.ReadLine());

if (a > b && a > c)
    Console.WriteLine("max = " + a);
else if (b > a && b > c)
    Console.WriteLine("max = " + c);
else if (c > a && c > b)
    Console.WriteLine("max = " + c);

else if (a == b && a > c)
    Console.WriteLine("max1 = " + a + " max2 = " + b);
else if (a == c && a > b)
    Console.WriteLine("max1 = " + a + " max2 = " + c);
else if (b == c && b > a)
    Console.WriteLine("max1 = " + b + " max2 = " + c);

else if (a == b && a < c)
    Console.WriteLine("max = " + c);
else if (a == c && a < b)
    Console.WriteLine("max = " + b);
else if (b == c && b < a)
    Console.WriteLine("max = " + a);

else
    Console.WriteLine("Все значения равны между собой.");
