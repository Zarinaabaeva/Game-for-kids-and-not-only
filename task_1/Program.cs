int firstNumber = 0;
while (firstNumber < 1 || firstNumber > 10)
{
    Console.WriteLine("Введите число от 1 до 10:");
    firstNumber = Convert.ToInt32(Console.ReadLine());
}

int sum = firstNumber;

while (sum < 100)
{
    Console.WriteLine("Введите число от 1 до 10: ");
    int secondNumber = Convert.ToInt32(Console.ReadLine());
    if (secondNumber > 1 && secondNumber < 10)
    {
        sum = sum + secondNumber;
        Console.WriteLine($" сумма -> {sum}");
    }
    if (sum > 100)
    {
        sum = sum - secondNumber;
        Console.WriteLine("Введите такое число, чтобы сумма с предыдущим числом не превышала 100: ");
        int correctNumber = Convert.ToInt32(Console.ReadLine());
        sum = sum + correctNumber;
    }
    if (sum == 100)
    {
        Console.WriteLine("Вы выиграли!");
    }
}









