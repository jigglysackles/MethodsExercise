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
            int fingersUp = 0;
            string? readResult;
            int fingerAge = 0;

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

            do
            {
                Console.WriteLine("How many fingers am I holding up?");
                readResult = Console.ReadLine();
                if (int.TryParse(readResult, out fingersUp))
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
            string? menuSelection; 
            Console.WriteLine(
                "By the way, I can do other math with your age and fingers. Would you like to see more options? (y/n)\n");
            do
            {
                readResult = Console.ReadLine()?.ToLower();
                
                if (readResult == "y")
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
                    readResult = Console.ReadLine();
                    if (readResult != null)
                    {
                        menuSelection = readResult.ToLower();
                        
                        switch (menuSelection)
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
                

                if (readResult == "n")
                {
                    Console.WriteLine("Well that's disappointing.");
                    break;
                }

                {
                    Console.WriteLine("Is entering 'y' or 'n' really that hard?");
                }
            }while (readResult != "y" && readResult != "n");
            
            
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
    