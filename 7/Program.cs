Console.Clear();
Console.Write("Введите первое число: ");
int numberA = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int numberB = int.Parse(Console.ReadLine());
if(numberA % numberB == 0){
    Console.WriteLine("кратно");
}
else{
   Console.WriteLine($"не кратно, остаток - {numberA % numberB}"); 
}
