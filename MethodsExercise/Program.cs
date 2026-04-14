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
        public static bool ValidAge(string ageInput)
        {
            if (!int.TryParse(ageInput, out int agePerson))
            {
                return false;
            }
            
            // Check over 10
            if (agePerson <= 10)
            {
                return false;
            }
            
            // Check unlikely
            if (agePerson >= 90)
            {
                return false;
            }
            return true;

        }
        
    }
    
}
