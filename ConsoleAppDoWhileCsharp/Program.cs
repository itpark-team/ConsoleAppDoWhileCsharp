double number;

do
{
    try
    {
        Console.Write("введите число >0 для извлечения кв корня: ");
        number = double.Parse(Console.ReadLine());
        if (number < 0)
        {
            Console.WriteLine("ошибка. число должно быть >0");
        }
    }
    catch
    {
        Console.WriteLine("ошибка. ввод должен быть числом");
        number = -1;
    }
} while (number < 0);


double res = Math.Sqrt(number);

Console.WriteLine($"Квадратный корень из {number} = {res}");