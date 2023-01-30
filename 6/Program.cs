Console.Clear();
int num = new Random().Next(100, 1000);
Console.WriteLine($"Num = {num}");
int num1 = num / 100;
int num2 = num % 10;
int max =num1;
Console.WriteLine($"Max = {max}{num2}");
