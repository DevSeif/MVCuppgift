namespace MVCuppgift.Models
{
    public class GuessingGameModel
    {
        public bool IsCorrect { get; set; } = false;

        public string IsItCorrect(int guess, int? secretNumber)
        {
            if(guess == secretNumber)
            {
                IsCorrect = true;
                return "Congratulations your guess was right! Here's another number to guess";
            }

            else if ( guess > 100)
            {
                return "You cannot guess on a number over 100";
            }

            else if (guess > secretNumber)
            {
                return "Your guess is too high!";
            }

            else if (guess < secretNumber)
            {
                return "Your guess is too low!";
            }
            return "Invalid input";
        }
    }
}
