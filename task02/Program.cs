//task2 
Console.WriteLine("Введите первое число: ");
int a = int.Parse(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
int b = int.Parse(Console.ReadLine());

if (a > b)

    Console.WriteLine("max = " + a + " min = " + b);

else if (a < b)

    Console.WriteLine("max = " + b + " min = " + a);

else

    Console.WriteLine("a = b");
