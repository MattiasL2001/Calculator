namespace Calculator
{
    public class Math
    {
        public static object Calculate(decimal a, decimal b, char operation)
        {
            switch (operation)
            {
                case '+':
                    return a + b;
                case '-':
                    return a - b;
                case '*':
                    return a * b;
                case '/':
                    if (b != 0) { return a / b; }
                    else { return "ERROR: Tried to divide by zero."; }
                default:
                    return 0;
            }
        }

        public static decimal Plus(decimal a, decimal b)
        {
            return a + b;
        }
        public static decimal Minus(decimal a, decimal b)
        {
            return a - b;
        }
        public static decimal Times(decimal a, decimal b)
        {
            return a * b;
        }
        public static object Division(decimal a, decimal b)
        {
            if (b != 0)
            {
                return a / b;
            }
            else
            {
                return "Can not divide by zero!";
            }
        }
        public static string NewtonLawOfMotion(decimal dMass, decimal dAcceleration)
        {
            return "F = " + (dMass * dAcceleration).ToString();
        }

        public static void CelsiusFahrenheitConvert(string input)
        {
            Console.WriteLine("Write '1' for Celsius to Fahrenheit, and '2' for vice versa.");

            string number;
            decimal numberD;

            while (true)
            {
                switch (input)
                {
                    case "1":
                        try
                        {
                            Console.WriteLine("Write a number to convert!");
                            number = Console.ReadLine();
                            numberD = Convert.ToDecimal(number);
                            numberD = numberD * 9 / 5 + 32;
                            Console.WriteLine("F = " + numberD);
                            break;
                        }
                        catch (Exception)
                        {
                            goto case "1";
                        }
                    case "2":
                        try
                        {
                            Console.WriteLine("Write a number to convert!");
                            number = Console.ReadLine();
                            numberD = Convert.ToDecimal(number);
                            numberD = (numberD - 32) * 9 / 5;
                            Console.WriteLine("F = " + numberD);
                            break;
                        }
                        catch (Exception)
                        {
                            goto case "2";
                        }
                    default:
                        Console.WriteLine("Non-valid input");
                        break;
                }
                break;
            }
        }
    }
}
