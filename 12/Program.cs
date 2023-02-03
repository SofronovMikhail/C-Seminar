Console.Write("Введите координаты по Х1: ");
int x1 = int.Parse(Console.ReadLine());
Console.Write("Введите координаты по Y1: ");
int y1 = int.Parse(Console.ReadLine());
Console.Write("Введите координаты по Х2: ");
int x2 = int.Parse(Console.ReadLine());
Console.Write("Введите координаты по Y2: ");
int y2 = int.Parse(Console.ReadLine());
double s = Math.Sqrt(Math.Pow(x1 - x2, 2)) + (Math.Pow(x1 - x2, 2));
Console.WriteLine($"s = {s:f3}");
//Так же можно все int поменять на double
