while (true)
{
    double firstvalue, twovalue;
    string operation;
    double степень;
    string step;

    Console.WriteLine("Выберите какую операцию вы хотите выполнить: ");
    Console.WriteLine("1. Вычесть первое из второго");
    Console.WriteLine("2. Вычесть первое из второго");
    Console.WriteLine("3. Перемножить два числа");
    Console.WriteLine("4. Разделить первое на второе");
    Console.WriteLine("5. Возвести в степень N первое число");
    Console.WriteLine("6. Найти квадратный корень из числа");
    Console.WriteLine("7. Найти 1 процент из числа");
    Console.WriteLine("8. Найти факториал из числа");
    Console.WriteLine("9. Выйти из программы");

    operation = Console.ReadLine();

    if (operation == "9")
    {
        Environment.Exit(0);
    }

    Console.WriteLine("Введите первое значение: ");
    firstvalue = Double.Parse(Console.ReadLine());

    Console.WriteLine("Введите второе значение: ");
    twovalue = Double.Parse(Console.ReadLine());

    switch (operation)
    {
        case "1":
            Console.WriteLine(firstvalue + twovalue);
            break;
        case "2":
            Console.WriteLine(firstvalue - twovalue);
            break;
        case "3":
            Console.WriteLine(firstvalue * twovalue);
            break;
        case "4":
            if (firstvalue == 0)
                Console.WriteLine(0);
            else if (twovalue == 0)
                Console.WriteLine(0);
            else
                Console.WriteLine(firstvalue / twovalue);
            break;
        case "5":
            Console.WriteLine("Введите степень, в которую нужно возвести число");
            step = Console.ReadLine();
            степень = Convert.ToInt32(step);
            Console.WriteLine(Math.Pow(firstvalue, степень));
            break;
        case "6":
            Console.WriteLine(Math.Sqrt(firstvalue));
            break;
        case "7":
            Console.WriteLine(firstvalue * 0.01);
            break;
        case "8":
            double factorial = 1;
            for (int i = 1; i <= firstvalue; i++)
            {
                factorial *= i;
            }
            Console.WriteLine(factorial);
            break;


        default:
            Console.WriteLine("Ошибка");
            break;


    }
}