namespace COMP003A.Assignment4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1. Start/Continue Routine\n2. View Progress\n3. Exit");

            int stepsTaken = 0;

            do
            {
                Console.Write("Enter choice: ");
                char selection = char.Parse(Console.ReadLine());
                // selection process starts here

                if (selection == '1')
                {
                    stepsTaken++;
                    Console.WriteLine($"Step {stepsTaken} was completed.");
                }
                else if (selection == '2')
                {
                    Console.WriteLine($"{stepsTaken} step(s) has/have been taken.");
                }
                else if (selection == '3')
                {
                    Console.WriteLine("Goodbye!");
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid selection, try again.");
                }

            }
            while (true;
        }
    }
}
