namespace Calculator
{
    public class Calculator
    {
        public Calculator()
        {
            List<string> history = new List<string>();

            while (true)
            {
                Console.WriteLine("------------------------------------------------------------------------------");
                Console.WriteLine("Choose an operation below:");
                Console.WriteLine("+");
                Console.WriteLine("-");
                Console.WriteLine("*");
                Console.WriteLine("/");
                Console.WriteLine("'CF' for CelsiusFahrenheit convertion");
                Console.WriteLine("'N' for Newton's law of motion");
                Console.WriteLine("");
                Console.WriteLine("'H' to se all historical calculations");
                Console.WriteLine("'Q' to quit program");
                Console.WriteLine("------------------------------------------------------------------------------");

                char operation = Console.ReadKey().KeyChar;
                Console.WriteLine();
                decimal num1 = GetNumber();
                decimal num2 = GetNumber();
                var answer = "";

                switch (operation)
                {
                    case '+':
                    case '-':
                    case '*':
                    case '/':
                        answer = Convert.ToString(Math.Calculate(num1, num2, operation));
                        Console.WriteLine(answer);
                        history.Add($"{num1} {operation} {num2} = {answer}");
                        break;
                    case 'F':
                    case 'f':
                        answer = Math.NewtonLawOfMotion(num1, num2);
                        Console.WriteLine(answer);
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
                        break;
                }
            }

            decimal GetNumber()
            {
                while (true)
                {
                    Console.WriteLine("Type in a number!");

                    try
                    {
                        decimal num = decimal.Parse(Console.ReadLine());
                        return num;
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Error: You must type in a number and not anything else!");
                    }
                }
            }
        }
    }
}
