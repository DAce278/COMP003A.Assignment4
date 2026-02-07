namespace COMP003A.Assignment4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // menu
            Console.WriteLine("1. Start/Continue Routine\n2. View Progress\n3. Exit");

            int stepsTaken = 0;
            char selection = ' ';

            // start of loop
            do
            {

                //usual loop before 5 steps taken
                Console.Write("Enter choice: ");
                selection = char.Parse(Console.ReadLine());

                if (selection == '1')
                {
                    //start of multiple checks depending on current step in routine

                    //check for skipped step if at the correct location in routine
                    if (stepsTaken == 2)
                    {
                        stepsTaken++;
                        Console.WriteLine($"Step 3 is restricted and was skipped.\n");
                    }
                    //check for safety limit after enough steps taken
                    else if (stepsTaken >= 5)
                    {
                        Console.WriteLine("Safety limit reached. Routine stopped.\n");
                    }
                    else
                    {
                    //typical routine process
                        stepsTaken++;
                        Console.WriteLine($"Step {stepsTaken} was completed.\n");
                    }
                }
                else if (selection == '2')
                {
                    Console.WriteLine($"{stepsTaken} step(s) has/have been taken.\n");
                }
                else if (selection == '3')
                {
                    Console.WriteLine("\nGoodbye!");
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
