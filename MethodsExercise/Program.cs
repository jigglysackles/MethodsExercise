namespace MethodsExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            string namePerson = "";
            int agePerson;
            string personFavFood = "";
            string personFavGame = "";
            int fingersUp;
            int fingerAge = 0;

            Console.WriteLine("What's your name?");
            
            string? readResultName = Console.ReadLine();
            if (readResultName != null)
            {
                namePerson = readResultName;
            }


            
            do
            {
                string? readResult;
                Console.WriteLine("What's your age?");
                readResult = Console.ReadLine();

                if (int.TryParse(readResult, out agePerson) || !ValidAge(agePerson))
                {
                    Console.WriteLine("Your age is not valid. Try again.");
                    
                }

            } while (!ValidAge(agePerson));



            Console.WriteLine("What's your favorite food?");
            string? readResultFood = Console.ReadLine();
            if (readResultFood != null)
            {
                personFavFood = readResultFood;
            }


            Console.WriteLine("What's your favorite game?");
            string? readResultGame = Console.ReadLine();
            if (readResultGame != null)
            {
                personFavGame = readResultGame;
            }

            do
            {
                Console.WriteLine("How many fingers am I holding up?");
                string? readResultFingers = Console.ReadLine();
                if (int.TryParse(readResultFingers, out fingersUp))
                {
                    MultiplyNumbers(fingersUp, agePerson, ref fingerAge);
                }
                
                if (fingersUp <= 0)
                {
                    Console.WriteLine("Please enter a number above 0.");
                }
                    
            } while (fingerAge <= 0 || fingersUp <= 0 || agePerson <= 0);


            Console.WriteLine(
                $"\n\nOK! Thanks for the information {namePerson}! We'll make sure your data is sold to the highest bidder.\n\n");
            Console.WriteLine(
                $"Just to confirm {namePerson}...\nYou're {agePerson} years old.\nAnd you enjoy {personFavFood}, and {personFavGame}.\n");
            Console.WriteLine(
                $"Side Note: If you multiply your fingers up {fingersUp} and your age {agePerson} you will get {fingerAge}.\nIt doesn't affect anything, just thought you'd like to know.\n\n");
            
            // yes/no menu
            //string? menuSelection; 
            Console.WriteLine(
                "By the way, I can do other math with your age and fingers. Would you like to see more options? (y/n)\n");
            do
            {
                string? readResultMenu = Console.ReadLine()?.ToLower();
                
                if (readResultMenu == "y")
                {
                    try
                    {
                        Console.Clear();
                    }
                    catch (IOException)
                    {
                        //Ignore: Clears debug session exceptions
                    }
                    Console.WriteLine(
                        $"\nGreat choice {namePerson}! What would you like me to do? \nI can Add, Subtract, or Divide (I already did multiplication so look above for that.)\n(please enter a,s,d) ");
                    string? readResultSelection = Console.ReadLine();
                    if (readResultSelection != null)
                    {
                        //menuSelection = readResult.ToLower();
                        
                        switch (readResultSelection?.ToLower())
                        {
                            case "a":
                            
                                AddNumbers(agePerson, fingersUp, ref fingerAge);
                                Console.WriteLine(
                                    $"Adding your age, {agePerson}, and my fingers up, {fingersUp}, will give you {fingerAge}.");

                                break;
                                
                            case "s":
                            
                                SubtractNumbers(agePerson, fingersUp, ref fingerAge);
                                Console.WriteLine(
                                    $"Subtracting your age, {agePerson}, by my fingers up, {fingersUp}, will give you {fingerAge}.");

                                break;
                                
                            case "d":
                                DivideNumbers(agePerson, fingersUp, ref fingerAge);
                                Console.WriteLine(
                                    $"Dividing your age, {agePerson}, by my fingers up, {fingersUp}, will give you {fingerAge}.");

                                break;
                            
                        }
                        
                    }
                    
                    break;
                }
                

                if (readResultMenu == "n")
                {
                    Console.WriteLine("Well that's disappointing.");
                    break;
                }

                {
                    Console.WriteLine("Is entering 'y' or 'n' really that hard?");
                }
            }while (readResultMenu != "y" && readResultMenu != "n");
            
            
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

        public static void MultiplyNumbers(int agePerson, int fingersUp, ref int fingerAge)
        {
            fingerAge = agePerson * fingersUp;

        }
        public static void AddNumbers(int agePerson, int fingersUp, ref int fingerAge)
        {
            fingerAge = agePerson + fingersUp;

        }
        public static void SubtractNumbers(int agePerson, int fingersUp, ref int fingerAge)
        {
            fingerAge = agePerson - fingersUp;

        }
        public static void DivideNumbers(int agePerson, int fingersUp, ref int fingerAge)
        {
            fingerAge = agePerson / fingersUp;

        }
        

    }
}
    