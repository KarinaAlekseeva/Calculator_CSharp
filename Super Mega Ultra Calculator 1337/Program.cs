Console.WriteLine("Super Mega Ultra Calculator 1337 к вашим услугам! Пожалуйста, выберите операцию из данного списка: ");

Console.WriteLine("|a| Сложение");

Console.WriteLine("|b| Вычитание");

Console.WriteLine("|c| Умножение");

Console.WriteLine("|d| Деление");

Console.WriteLine("|e| Возведение числа в степень");

Console.WriteLine("|f| Нахождение факториала числа");

Console.WriteLine("|g| Найти корень из числа");

Console.WriteLine("|h| Найти один процент от числа");

Console.WriteLine("|i| Выход из программы");

string oper;

oper = Console.ReadLine();

while (oper != "i")
{
    double operand1, operand2;

    switch (oper)
    {
        case "a":
            Console.WriteLine("Введите первое число: ");

            operand1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите второе число: ");

            operand2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Результат: " + (operand1 + operand2));

            Console.WriteLine("");

            Console.WriteLine("Введите операцию: ");

            oper = Console.ReadLine();

            break;

        case "b":
            Console.WriteLine("Введите первое число: ");

            operand1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите второе число: ");

            operand2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Результат: " + (operand1 - operand2));

            Console.WriteLine("");

            Console.WriteLine("Введите операцию: ");

            oper = Console.ReadLine();

            break;

        case "c":
            Console.WriteLine("Введите первое число: ");

            operand1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите второе число: ");

            operand2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Результат: " + (operand1 * operand2));

            Console.WriteLine("");

            Console.WriteLine("Введите операцию: ");

            oper = Console.ReadLine();

            break;

        case "d":
            Console.WriteLine("Введите первое число: ");

            operand1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите второе число: ");

            operand2 = Convert.ToDouble(Console.ReadLine());

            if (operand2 != 0)
            {
                Console.WriteLine("Результат: " + (operand1 / operand2));

                Console.WriteLine("");

                Console.WriteLine("Введите операцию: ");

                oper = Console.ReadLine();
            }
            else
            {
                Console.WriteLine("На ноль делить нельзя! Введите другое число, не равное нулю.");

                Console.WriteLine("");

                Console.WriteLine("Введите операцию: ");

                oper = Console.ReadLine();
            }
            break;

        case "e":
            Console.WriteLine("Введите первое число: ");

            operand1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите степень, в которую нужно возвести: ");

            operand2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Результат: " + (Math.Pow(operand1, operand2)));

            Console.WriteLine("");

            Console.WriteLine("Введите операцию: ");

            oper = Console.ReadLine();

            break;

        case "f":
            operand2 = 1;

            Console.WriteLine("Введите первое число: ");

            operand1 = Convert.ToDouble(Console.ReadLine());

            if (operand1 < 0)
            {
                Console.WriteLine("Не существует факториала отрцательного числа!");

                Console.WriteLine("");

                Console.WriteLine("Введите операцию: ");

                oper = Console.ReadLine();
            }

            else if (operand1 == 0)
            {
                Console.WriteLine("Результат: " + 1);

                Console.WriteLine("");

                Console.WriteLine("Введите операцию: ");

                oper = Console.ReadLine();
            }

            else
            {
                for (int i = 1; i <= operand1; i++)
                {
                    operand2 *= i;

                }
                Console.WriteLine("Результат: " + operand2);

                Console.WriteLine("");

                Console.WriteLine("Введите операцию: ");

                oper = Console.ReadLine();
            }
            break;

        case "g":
            Console.WriteLine("Введите первое число: ");

            operand1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Результат: " + Math.Sqrt(operand1));

            Console.WriteLine("");

            Console.WriteLine("Введите операцию: ");

            oper = Console.ReadLine();

            break;

        case "h":
             Console.WriteLine("Введите первое число: ");

             operand1 = Convert.ToDouble(Console.ReadLine());

             Console.WriteLine("Результат: " + $"1% от {operand1} " + "это " + (operand1 / 100));

             Console.WriteLine("");

             Console.WriteLine("Введите операцию: ");

             oper = Console.ReadLine();

             Console.WriteLine("Некорректный ввод");

             Console.WriteLine("");

             Console.WriteLine("Введите операцию: ");

            oper = Console.ReadLine();
            
            break;

        default:
            Console.WriteLine("Нет такой операции");

            Console.WriteLine("");

            Console.WriteLine("Введите операцию: ");

            oper = Console.ReadLine();

            break;
    }
}