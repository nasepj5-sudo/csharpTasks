namespace ConsoleApp1.Tasks
{
    class Task4
    {
        static void Main()
        {
            char choice = 'Y';

            while (choice == 'Y' || choice == 'y')
            {
                Console.WriteLine("Press any following key to perform an arithmetic operation:");
                Console.WriteLine("1 - Addition");
                Console.WriteLine("2 - Subtraction");
                Console.WriteLine("3 - Multiplication");
                Console.WriteLine("4 - Division");

                Console.Write("Enter your choice: ");
                string? opInput = Console.ReadLine();
                int operation = Convert.ToInt32(opInput ?? "0");

                Console.Write("Enter value 1: ");
                string? v1Input = Console.ReadLine();
                double value1 = Convert.ToDouble(v1Input ?? "0");

                Console.Write("Enter value 2: ");
                string? v2Input = Console.ReadLine();
                double value2 = Convert.ToDouble(v2Input ?? "0");

                double result = 0;
                string symbol = "";

                switch (operation)
                {
                    case 1:
                        result = value1 + value2;
                        symbol = "+";
                        break;

                    case 2:
                        result = value1 - value2;
                        symbol = "-";
                        break;

                    case 3:
                        result = value1 * value2;
                        symbol = "*";
                        break;

                    case 4:
                        if (value2 == 0)
                        {
                            Console.WriteLine("Error: Cannot divide by zero.");
                            continue;
                        }
                        result = value1 / value2;
                        symbol = "/";
                        break;

                    default:
                        Console.WriteLine("Invalid choice. Please select 1–4 only.");
                        continue;
                }

                Console.WriteLine($"{value1} {symbol} {value2} = {result}");

                Console.Write("Do you want to continue (Y/N): ");
                string? input = Console.ReadLine();
                choice = string.IsNullOrEmpty(input) ? 'N' : input[0];
            }

            Console.WriteLine("Program ended. Thank you!");
        }
    }
}