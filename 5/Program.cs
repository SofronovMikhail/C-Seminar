﻿Console.Clear();
int num = new Random().Next(10, 100);
Console.WriteLine($"Num = {num}");
int num1 = num / 10;
int num2 = num % 10;
int max =num2;
if(num1 > max){
    max = num1;
}
Console.WriteLine($"Max = {max}");