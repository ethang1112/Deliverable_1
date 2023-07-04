namespace Deliverable_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input = 0;
            string series = "";

            while (true)
            {
                try
                {
                    Console.Write("Enter an integer value between 1 and 100: ");
                    input = int.Parse(Console.ReadLine());

                    if (input >= 1 && input <= 100)
                    {
                        break;
                    }
                  
                }
                catch
                {
                    
                }
            }

            while (true)
                try
                {
                    Console.Write("Specify the series type: Even or Odd ");
                    series = Console.ReadLine();

                    if (series == "Even" || series == "Odd")
                    {
                        break;
                    }
                }
                catch
                {

                }
            {
                
            }

            

            if (series == "Odd")
            {
                Console.WriteLine("You have selected " + series + " series. The numbers between 0 and " + input + " are:");
                for (int i = 1; i <= input; i = i + 2)
                {
                    Console.WriteLine(i);
                }
            }

            if (series == "Even")
            {
                Console.WriteLine("You have selected " + series + " series. The numbers between 0 and " + input + " are:");
                for (int i = 0; i <= input; i = i + 2)
                {
                    Console.WriteLine(i);
                }
            }

        }
    }
}