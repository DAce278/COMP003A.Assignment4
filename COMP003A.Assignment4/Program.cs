namespace COMP003A.Assignment4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1. Start/Continue Routine\n2. View Progress\n3. Exit");

            int stepsTaken = 0;
            char selection = ' ';

            do
            {
                Console.Write("Enter choice: ");
                // selection process starts here


                //check to catch safety stop
                while (stepsTaken >= 5)
                {
                    selection = char.Parse(Console.ReadLine());

                    if (selection == '1')
                    {
                        Console.WriteLine("Safety limit reached. Routine stopped.\n");
                    }
                    else if (selection == '2')
                    {
                        Console.WriteLine($"{stepsTaken} step(s) has/have been taken.\n");
                    }
                    else if (selection == '3')
                    {
                        break;
                        //breaks loop and ends program
                    }
                }


                //usual loop before 5 steps taken
                selection = char.Parse(Console.ReadLine());
                if (selection == '1')
                    {
                        stepsTaken++;
                        Console.WriteLine($"Step {stepsTaken} was completed.\n");
                    }
                    else if (selection == '2')
                    {
                        Console.WriteLine($"{stepsTaken} step(s) has/have been taken.\n");
                    }
                    else if (selection == '3')
                    {
                        Console.WriteLine("Goodbye!");
                        break;
                        //breaks loop and ends program
                    }
                    else
                    {
                        Console.WriteLine("Invalid selection, try again.\n");
                    }

            
                
            } while (true);
    }
}}
