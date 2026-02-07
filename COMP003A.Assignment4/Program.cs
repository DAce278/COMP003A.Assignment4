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
                // selection process starts here


                //check for safety stop
                while (stepsTaken >= 5)
                {
                    Console.Write("Enter choice: ");
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
                        Console.WriteLine("Goodbye!");
                        break;
                        //breaks loop and ends program
                    }
                    else
                    {
                        Console.WriteLine("Invalid selection, try again.\n");
                    }
                }
                if (stepsTaken >= 5)
                {
                    break;
                    //secondary break to leave both loops
                }


                //usual loop before 5 steps taken
                Console.Write("Enter choice: ");
                selection = char.Parse(Console.ReadLine());

                if (selection == '1')
                {
                    if (stepsTaken == '3')
                    //start of skipped step logic
                    {
                        stepsTaken++;
                        Console.WriteLine($"Step 3 is restricted and was skipped.");
                    }
                    else
                    {
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
