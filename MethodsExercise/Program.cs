namespace MethodsExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            string namePerson;
            string ageInput;
            int agePerson = 0;
            string personFavFood;
            string personFavGame;
            bool ageOk;
            
            Console.WriteLine("What's your name?");
            namePerson = Console.ReadLine();
            
            Console.WriteLine("What's your age?");
            ageInput = Console.ReadLine();
            if (!ValidAge(ageInput));
            {
                Console.WriteLine("Your age is not valid. Try again.");
            }
            
            Console.WriteLine("What's your favorite food?");
            personFavFood = Console.ReadLine();
            
            Console.WriteLine("What's your favorite game?");
            personFavGame = Console.ReadLine();

            Console.WriteLine(
                $"OK! Thanks for the information {namePerson}! Well make sure your data is sold to the highest bidder.");
            
            
            
            
            // Console.WriteLine($"")
            // {agePerson} {personFavFood} {personFavGame}");

        }
        //Custom Method Definitions
        public static bool ValidAge(string, out bool ageOk);
        {
            ageInput.TryParse();
            
            // Check over 10
            if (agePerson <= 10)
            {
                Console.WriteLine("You're too young to be using this. Get someone older than 10 and try again.");
                return false;
            }
            // Check unlikely
            if (agePerson >= 90)
            {
                Console.WriteLine("Yeah...I don't believe you.");
                return false;
            }
            return true;

        }
        
    }
    
}
