//Напишите программу, которая принимает 
//на вход число N и выдаёт произведение чисел от 1 до N.
Console.Clear();
 Console.Write("Введите число: ");
 int num = int.Parse(Console.ReadLine());
int GetMultiply(int n){ // n=3
    int result = 1;
    for (int i = 2; i <= n; i++){ // i <= n; 2 <= 3
        result *= i; // result
    }
    return result;
}
