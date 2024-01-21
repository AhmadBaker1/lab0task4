namespace lab0task4
{
    class Program
    {
        static void Main()
        {
            // Declare variables to store user input
            double low, high;

            // Ask the user for lower and upper bounds
            GetUserInput(out low, out high);

            // Generate random numbers between the user-provided bounds
            List<double> numbers = GenerateRandomNumbers(low, high);

            // Print the generated random numbers
            Console.WriteLine($"Generated random numbers: {string.Join(", ", numbers)}");

            // Print the sum of the generated numbers
            Console.WriteLine($"Sum of the numbers: {SumNumbers(numbers)}");

            // Print prime numbers between the user-provided bounds
            PrintPrimesBetween(low, high);

            Console.ReadLine(); // Keep console window open
        }

        static void GetUserInput(out double low, out double high)
        {
            // Ask the user for the lower bound
            Console.Write("Enter the lower bound: ");
            low = double.Parse(Console.ReadLine());

            // Ask the user for the upper bound
            Console.Write("Enter the upper bound: ");
            high = double.Parse(Console.ReadLine());
        }

        static List<double> GenerateRandomNumbers(double low, double high)
        {
            // Create a list to store random numbers
            List<double> numbers = new List<double>();
            Random random = new Random();

            // Generate 5 random numbers between the provided bounds
            for (int i = 0; i < 5; i++)
            {
                double randomNumber = (random.NextDouble() * (high - low)) + low;
                numbers.Add(randomNumber);
            }

            return numbers;
        }

        static double SumNumbers(List<double> numbers)
        {
            // Calculate and return the sum of the numbers in the list
            return numbers.Sum();
        }

        static void PrintPrimesBetween(double low, double high)
        {
            // Print prime numbers between the provided bounds
            Console.Write($"Prime numbers between {low} and {high}: ");
            for (double i = low; i <= high; i++)
            {
                if (IsPrime(i))
                    Console.Write($"{i} ");
            }
            Console.WriteLine();
        }

        static bool IsPrime(double num)
        {
            // Check if a number is prime
            if (num < 2)
                return false;

            for (double i = 2; i <= Math.Sqrt(num); i++)
            {
                if (num % i == 0)
                    return false;
            }

            return true;
        }
    }
}