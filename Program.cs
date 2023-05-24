using System;
Main();

void Main()
{
        //Display a message to the user asking them to guess the secret number.
        Console.WriteLine("Welcome to Guessing Game - Can you guess the secret number?");

        int allowedTries = 4; //Give the user four chances to guess the number.
        int numberOfTries = 0;

        while (true)
        {
            Console.WriteLine("Guess any number!"); //Display a prompt for the user's guess.
            string userGuess = Console.ReadLine(); //Take the user's guess as input and save it as a variable.

            if (userGuess.Length == 0)
            {
                Console.WriteLine("You haven't guessed a number yet!");
            }

            // Console.WriteLine($@"You guessed: {userGuess}"); //Display the user's guess back to the screen. ; No longer display the user's guess. They know what they guessed, right?
            
            
            numberOfTries++;
            int secretNumber = new Random().Next(0, 100); //Create a variable to contain the secret number. This number should be hard-coded for now. 42 is a nice number. ; Use a random number between 1 and 100 instead of a hard-coded number.
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
            else
            {
                int attemptsLeft = (allowedTries - numberOfTries); //The prompt should display the number of guesses the user has left.
                Console.WriteLine($@"FAILURE. You guessed {parsedUserGuess}. You have {attemptsLeft} attempt left."); //otherwise display a failure message.
            }
            
        }
}


/*

Phase 6
The program should be updated to...

Inform the user if their guess was too high or too low, when they guess incorrectly.
Phase 7
The program should be updated to...

Prompt the user for a difficulty level before they are prompted to guess the number.
The difficulty level should determine how many guesses the user gets. The difficulty levels should be:
Easy - this gives the user eight guesses.
Medium - this gives the user six guesses.
Hard - this gives the user four guesses.
Phase 8
The program should be updated to...

Add a difficulty level of "Cheater" which will cause the program to continue prompting the user until they get the answer correct.
*/