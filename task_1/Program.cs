m1:
Console.WriteLine("Введите число от 1 до 10:");
int a = Convert.ToInt32(Console.ReadLine());
if(a < 1 || a > 10) goto m1;

 int sum = a;

    while(sum < 100)
    {
    Console.WriteLine("Введите число от 1 до 10: ");
    int b = Convert.ToInt32(Console.ReadLine());
    if( b > 1 && b < 10)
    {
      sum = sum + b;
      Console.WriteLine($" сумма -> {sum}");
    }
    if(sum > 100)
    {
      sum = sum - b;
      Console.WriteLine("Введите такое число, чтобы сумма с предыдущим числом не превышала 100: ");
      int c = Convert.ToInt32(Console.ReadLine());
      sum = sum + c;
    }
   if(sum == 100)
   {
    Console.WriteLine("Вы выиграли!");
   }
    } 
 

 






