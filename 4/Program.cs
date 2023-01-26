Console.Clear();
Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());
if (number < 100 || number > 999){
     Console.WriteLine("Введен не правильный номер");
     return;
}
int otvet = number % 10;
 Console.WriteLine($"3 цифра: {otvet}");

