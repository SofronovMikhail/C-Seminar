﻿Console.Clear();
Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());
if(number < 1 || number > 7){
    Console.WriteLine("Введен не правильный номер");
    return;
}

if(number == 1){
    Console.WriteLine("понедельник");
}
if(number == 2){
    Console.WriteLine("вторник");
}
if(number == 3){
    Console.WriteLine("среда");
}
if(number == 4){
    Console.WriteLine("четверг");
}
if(number == 5){
    Console.WriteLine("пятница");
}
if(number == 6){
    Console.WriteLine("суббота");
}
if(number == 7){
    Console.WriteLine("воскресенье");
}

