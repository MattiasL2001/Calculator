List<string> history = new List<string>();
ChooseOperation();
void ChooseOperation()
{
    Console.WriteLine("------------------------------------------------------------------------------");
    Console.WriteLine("Choose a mathematical operation below:");
    Console.WriteLine("+");
    Console.WriteLine("-");
    Console.WriteLine("*");
    Console.WriteLine("/");
    Console.WriteLine("");
    Console.WriteLine("'H' to se all historical calculations");
    Console.WriteLine("'Q' to quit program");
    Console.WriteLine("------------------------------------------------------------------------------");

    char o = Console.ReadKey().KeyChar;
    Console.WriteLine();
    Console.WriteLine(o);

    switch (o)
    {
        //all the valid operator-types, if not one of these are entered, the code will just loop back and the
        //user gets another chanse to put in a valid-type operator
        case '+':
        case '-':
        case '*':
        case '/':
            float num1 = Calculate.InputNums();
            float num2 = Calculate.InputNums();
            string answer = (Calculate.CalculateNums(num1, num2, o));
            Console.WriteLine(answer);
            history.Add($"{num1} {o} {num2} = {answer}");
            ChooseOperation();
            break;
        case 'H':
        case 'h':
            Console.WriteLine("History:");
            foreach (string h in history)
                Console.WriteLine(h);
            Console.WriteLine("-------------------------------------------------------");
            break;
        case 'Q':
        case 'q':
            Environment.Exit(0);
            break;
        default:
            ChooseOperation();
            break;
    }
}

class Calculate
{
    //This is the method that handles the users input of numbers to the mathematical operation
    //It checks if the input from user is acceptable, otherwise it throws an exception
    public static float InputNums()
    {
        while (true)
        {
            Console.WriteLine("Type in a number!");

            try
            {
                float num = float.Parse(Console.ReadLine());
                return num;
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: You must type in a number and not anything else!");
            }
        }
    }

    //This method is responsible for returning the calculations, or writes out an error if theu ser is
    //trying to divide by zero
    public static string CalculateNums(float num1, float num2, char o)
    {
        switch (o)
        {
            case '+':
                return (num1 + num2).ToString();
            case '-':
                return (num1 - num2).ToString();
            case '*':
                return (num1 * num2).ToString();
            case '/':
                if (num2 != 0)
                {
                    return (num1 / num2).ToString();
                }
                else { Console.WriteLine("Invalid input! You can not divide by zero."); }
                break;
            default:
                break;
        }
        return "invalid";
    }
}