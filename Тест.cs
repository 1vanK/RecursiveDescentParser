using System;

class Тест
{
    static void Main()
    {
        Интерпретатор и = new Интерпретатор();

        string выражение = "(1 + 2 * 3) * (4 + 5) + 6 * (7 + 8) + 9";
        Console.WriteLine(выражение);
        try
        {
            uint результат = и.Вычислить(выражение);
            Console.WriteLine("= " + результат);
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
        Console.WriteLine();

        выражение = "1 + 1";
        Console.WriteLine(выражение);
        try
        {
            uint результат = и.Вычислить(выражение);
            Console.WriteLine("= " + результат);
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
        Console.WriteLine();

        выражение = "1 + 1 qwerty";
        Console.WriteLine(выражение);
        try
        {
            uint результат = и.Вычислить(выражение);
            Console.WriteLine("= " + результат);
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
        Console.WriteLine();

        Console.ReadKey();
    }
}
