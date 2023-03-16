namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            int favoriteNumber = 7;
            Console.WriteLine("Try to guess my favorite number from 1-10");
            int userInput = int.Parse(Console.ReadLine());

            if (userInput < favoriteNumber)
            {
                Console.WriteLine($"{userInput} is too low");
            }
            else if (userInput > favoriteNumber)
            {
                Console.WriteLine($"{userInput} is too high");
            }
            else 
            {
                Console.WriteLine("You guessed it");
            }
        
            //Switch Case
            Console.WriteLine("What is your favorite school subject?");
            string subject = Console.ReadLine();
            switch (subject.ToLower()) 
            {
                case "math":
                    Console.WriteLine("I hate Math");
                    break;
                case "science":
                    Console.WriteLine("Its alright def not my favorite");
                    break;
                case "english":
                    Console.WriteLine("I love writing(");
                    break;
                case "pe":
                    Console.WriteLine("Emjoyed it ");
                    break;
                case "history":
                    Console.WriteLine("My favorite!");
                    break;
                default:
                    Console.WriteLine("I don't like that answer");
                    break;



            }
        
        }

    }
}
