Console.Clear();
Console.Write("Введите первое число: ");
int numberA = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int numberB = int.Parse(Console.ReadLine());
if(numberA * numberA == numberB){
    Console.WriteLine("Да");
    return;
}
if(numberB * numberB == numberA){
    Console.WriteLine("Да");
}
else{
   Console.WriteLine("Нет"); 
}