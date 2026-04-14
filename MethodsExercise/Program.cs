namespace MethodsExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            string namePerson = "";
            string ageInput = "";
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

            bool ageOk = false;
            do
            {
                Console.WriteLine("What's your age?");
                readResult = Console.ReadLine();
                if (readResult != null)
                {
                    ageOk = ValidAge(ageInput);

                    if (!ageOk)
                    {
                        Console.WriteLine("Your age is not valid. Try again.");
                        
                    }
                    else
                    {
                        agePerson = Convert.ToInt32(ageInput);
                    }

                }
                
            } while (!ageOk);



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
            
            
            Console.WriteLine($"OK! Thanks for the information {namePerson}! Well make sure your data is sold to the highest bidder.");
            Console.WriteLine($"Just to confirm {namePerson}...\nYou're {agePerson} years old.\nAnd you enjoy {personFavFood}, and {personFavGame}.");
            Console.WriteLine("Have a nice day! Press enter to exit.");
            Console.ReadLine();
            
        }
        
            //Custom Method Definitions
        public static bool ValidAge(string ageInput)
        {
            if (!int.TryParse(ageInput, out int agePerson))
            {
                return false;
            }

            // Check over 10
            int.TryParse(ageInput, out agePerson);
            if (agePerson <= 10)
            {
                Console.WriteLine("You're too young. Find an adult and try again.");
                return false;
            }

            // Check unlikely
            int.TryParse(ageInput, out agePerson);
            if (agePerson >= 90)
            {
                Console.WriteLine("This is highly doubtful. Try a lower age.");
                return false;
            } 
            return true;
        } 
            
    }

}
    