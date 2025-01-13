//Calculator();
//Week();

void Calculator()
{
    while (true)
    {
        double firstNum;
        double secondNum;
        char action;

        try
        {
            Console.Write("First value: ");
            firstNum = double.Parse(Console.ReadLine());

            Console.Write("Second value: ");
            secondNum = double.Parse(Console.ReadLine());

            Console.Write("Math sign: ");
            action = char.Parse(Console.ReadLine());
        }
        catch
        {
            Console.WriteLine("Invalid value or math sign was entered");
            Console.ReadLine();
            continue; //якщо помилка повертаємось до вайл впочаток коду
        }
        switch (action)
        {
            case '+':
                Console.WriteLine($" = {firstNum + secondNum}");
                break;

            case '-':
                Console.WriteLine($" = {firstNum - secondNum}");
                break;

            case '*':
                Console.WriteLine($" = {firstNum * secondNum}");
                break;

            case '/':
                if (secondNum == 0)
                    Console.WriteLine("Divided on 0 is impossible");
                else
                    Console.WriteLine($" = {firstNum / secondNum}");
                break;

            default:
                Console.WriteLine("Incorrect operation sign");
                break;
        }
        Console.ReadLine();
    }
}


/// <summary>
/// Користувач вводить із клавіатури номер дня тижня (1-7). Необхідно вивести на екран назви дня тижня. Наприклад, якщо 1, на екрані напис понеділок, 2 — вівторок тощо.
/// Розпарсила трайпарсом, використала if else, switch, метод Сlear для очищення консолі
/// </summary>
void Week()
{
    while (true)
    {
        Console.Clear();
        Console.Write("Enter num from 1 to 7: ");
        var numberStr = Console.ReadLine();

        int number = 0;
        bool isConverted = int.TryParse(numberStr, out number);
        if (!isConverted)
            Console.WriteLine("Only nums from 1 to 7 should be entered. Please, try again");
        else

            switch (number)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                case 7:
                    Console.WriteLine("Sunday");
                    break;
                default:
                    Console.WriteLine("Only nums from 1 to 7 should be entered. Please, try again");
                    break;
            }
        Console.ReadLine();
    }
}

