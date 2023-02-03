Console.Clear();
Console.Write("Введите номер четверти: ");
int N = int.Parse(Console.ReadLine());
switch(N){
    case 1:
    {
        Console.WriteLine("X>0  Y>0"); 
        break;
    }
   case 2:
    {
        Console.WriteLine("X<0  Y>0"); 
        break;
    }
    case 3:
    {
        Console.WriteLine("X<0  Y<0"); 
        break;
    }
    case 4:
    {
        Console.WriteLine("X>0  Y<0"); 
        break;
    }
    default:
    {
        Console.WriteLine("Введено не правильное число"); 
        break;
    }
}
