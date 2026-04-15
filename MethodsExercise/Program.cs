namespace MethodsExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            string namePerson = "";
            int agePerson = 0;
            string personFavFood = "";
            string personFavGame = "";
            string? readResult;
            
            
            Console.WriteLine("What's your name?");
            readResult = Console.ReadLine();
            if (readResult != null)
            {
                namePerson = readResult;
            }

            
            do
            {
                Console.WriteLine("What's your age?");
                readResult = Console.ReadLine();

                if (int.TryParse(readResult, out agePerson))
                {
                    if (!ValidAge(agePerson))
                    {
                        Console.WriteLine("Your age is not valid. Try again.");
                    }
                }
                
                else 
                {
                    Console.WriteLine("Your age is not valid. Try again.");
                }
                
            } while (!ValidAge(agePerson));



            Console.WriteLine("What's your favorite food?"); 
            readResult = Console.ReadLine();
            if (readResult != null)
            {
                personFavFood = readResult;    
            }
            
            
            Console.WriteLine("What's your favorite game?");
            readResult = Console.ReadLine();
            if (readResult != null)
            {
                personFavGame = readResult;    
            } 
            
            
            Console.WriteLine($"OK! Thanks for the information {namePerson}! We'll make sure your data is sold to the highest bidder.");
            Console.WriteLine($"Just to confirm {namePerson}...\nYou're {agePerson} years old.\nAnd you enjoy {personFavFood}, and {personFavGame}.");
            Console.WriteLine("Have a nice day! Press enter to exit.");
            Console.ReadLine();
            
        }
        
            //Custom Method Definitions
        public static bool ValidAge(int agePerson)
        {
            if (agePerson <= 11 || agePerson >= 90)
            {
                return false;
            }
           
            return true;
        } 
            
    }

}
    