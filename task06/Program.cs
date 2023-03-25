// task6
Console.WriteLine("Введите число: ");
int a = int.Parse(Console.ReadLine());

int x = a % 2;

if (x == 0)
    Console.WriteLine("Введенное число является четным.");
else
    Console.WriteLine("Введенное число является нечетным.");
