using System;
Main();

void Main()
{
        //Display a message to the user asking them to guess the secret number.
        Console.WriteLine("Welcome to Guessing Game - Can you guess the secret number?");
        Console.WriteLine("Choose your difficulty level:");
        Console.WriteLine("Press 1 for Easy.");
        Console.WriteLine("Press 2 for Medium.");
        Console.WriteLine("Press 3 for Hard.");
        Console.WriteLine("Press 4 to cheat and have endless tries!");
        string difficulty = Console.ReadLine();
        int parsedChosenDifficulty = int.Parse(difficulty);
        int allowedTries = 0; //Give the user four chances to guess the number.
        
        if (parsedChosenDifficulty == 1) { //Easy - this gives the user eight guesses.
            allowedTries = 8;
        }
        if (parsedChosenDifficulty == 2) { //Medium - this gives the user six guesses.
            allowedTries = 6;
        }
        if (parsedChosenDifficulty == 3) { //Hard - this gives the user four guesses.
            allowedTries = 4;
        }
        else if (parsedChosenDifficulty == 4) {  
        };

        Console.WriteLine("Guess any number!"); //Display a prompt for the user's guess.
        
       
        int numberOfTries = 0;
        int secretNumber = new Random().Next(0, 100); //Create a variable to contain the secret number. This number should be hard-coded for now. 42 is a nice number. ; Use a random number between 1 and 100 instead of a hard-coded number.

        while (true)
        {
            string userGuess = Console.ReadLine(); //Take the user's guess as input and save it as a variable.
            // Console.WriteLine($@"You guessed: {userGuess}"); //Display the user's guess back to the screen. ; No longer display the user's guess. They know what they guessed, right?
            
            numberOfTries++;
            int parsedUserGuess = int.Parse(userGuess);

            //Compare the user's guess with the secret number
            if (parsedUserGuess == secretNumber) {
                Console.WriteLine($@"You guessed the secret number - {secretNumber}!"); //Display a success message if the guess is correct,
                break; //added a line so the game ends
            }
            if (numberOfTries == allowedTries) 
            {
                Console.WriteLine($@"The right number was {secretNumber}, sorry!");
                break;
            }
            if (parsedUserGuess == 0) //how do I make this if you didn't put a guess and just hit enter?
            {
                Console.WriteLine("You haven't guessed a number yet!");
            }
            if (parsedChosenDifficulty == 4)
            {
               string highLow = parsedUserGuess > secretNumber ? "Your guess is higher than the secret number." : "Your guess is lower than the secret number.";
                Console.WriteLine($@"FAILURE. You guessed {parsedUserGuess}. {highLow} Keeping guessing!"); //otherwise display a failure message.
            }
            else
            {
                int attemptsLeft = (allowedTries - numberOfTries); //The prompt should display the number of guesses the user has left.
                string highLow = parsedUserGuess > secretNumber ? "Your guess is higher than the secret number." : "Your guess is lower than the secret number.";
                Console.WriteLine($@"FAILURE. You guessed {parsedUserGuess}. {highLow} You have {attemptsLeft} attempt(s) left."); //otherwise display a failure message.
            }
        }
}
