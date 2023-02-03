Console.Write("Введите число: ");
int N = int.Parse(Console.ReadLine());
int i = 1;
while(i <= N)
{
  Console.WriteLine($"{Math.Pow(i, 2)}");
  i++;
}


//Второе решение 
//Console.Write("Введите число: ");
//int N = int.Parse(Console.ReadLine());
//int i = 1;
//if(N<0);
//{
//  i=N;
//  N= -1; или по другому N=N*(-1)
//}
//for(; i<=N; i++)
//{
//  Console.WriteLine($"{Math.Pow(i, 2)}");



//Решение через массив.
//Console.Write("Введите число: ");
//int N = int.Parse(Console.ReadLine());
//int i = 1;
//int m = N
//if(N < 0);
//{
//  i = N;
//  m = -N;
//  N = -1; или по другому N=N*(-1)
//}
//int[] result = new int[m];
//for(int j = 0; i<=N; i++)
//{
// result[j] = i * i;
//  j++;
//}
//for(j=0; j<m; j++)
//{
//  Console.WriteLine($"{result[j]}");
//}


