Console.WriteLine("Введите число:");
int a = Convert.ToInt32(Console.ReadLine());

int sum = a;
while(sum < 100)
{
  Console.WriteLine("Введите число: ");
  int b = Convert.ToInt32(Console.ReadLine());
  sum = sum + b;
  Console.WriteLine($" сумма -> {sum}");
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




