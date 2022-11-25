//list to store all mathematical operations in
List<string> history = new List<string>();
//made a separate method for the main functionality of the calculator, not a necessity but
//it makes the code readable, especially as the name of the method tells what its purpose is
ChooseOperation();
void ChooseOperation()
{
    //this creates a starting-menu, the first and last line with the dashes is just for visual purposes
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
            //passing num 1 and num 2 but also 'o', which is the type of operation into the method,
            //this allows to make a similar structure in the given method with switch cases, like this one
            //this is ´not necessary but helps to keep the project readable and understandable with
            //small method that all have their own easy-to-understand purpose and thus makes it easier for
            //a perosn to read and understand
            //for a small project like this I could have just have coded everything here in this switch case,
            //as projects this small of a size still would make it readable
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

//Separate class to handle different kind of calculations, not necessary for a small
//project like this but it helps with the entire structure/readability
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
        //returns 'invalid' if none of the circumstances above will occur, to give the user some extra feedback
        //not necessary in order for the calculator to function but users allways appreciate good feedback
        return "invalid";
    }
}