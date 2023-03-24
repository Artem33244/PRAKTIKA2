using ClassLibrary2;

NumberIncrementer incrementer = new NumberIncrementer();

while (true)
{
    Console.WriteLine("Введите число:");
    int number = int.Parse(Console.ReadLine());

    if (incrementer.SetNumber(number))
    {
        Console.WriteLine("Правильно! Ожидаемое число: " + incrementer.GetExpectedNumber());
    }
    else
    {
        Console.WriteLine("Неправильно! Попробуйте еще раз.");
    }
}