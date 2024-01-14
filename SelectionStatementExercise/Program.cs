namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)
        {

            var random = new Random();
            var favNumber = random.Next(1, 100);

            
        
                Console.WriteLine("Guess a random number:");
                var userInput = int.Parse(Console.ReadLine());


                if (favNumber < userInput)
                {
                    Console.WriteLine("number is too low");
                }
                else if (favNumber > userInput)
                {
                    Console.WriteLine("number is too high");
                }
                else
                {
                    Console.WriteLine("You guessed it right!!!");
                }
         
        }
    }
}
