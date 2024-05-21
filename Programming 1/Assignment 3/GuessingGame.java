import java.util.Random;
import java.util.Scanner;

/*
 * Elizabeth Gress
 * 09/15/2023
 * 
 * Design and implement an application that plays the Over-Under guessing game with numbers. The program should pick a random number between 1 and 100 
 * (inclusive), then repeatedly prompt the user to guess the number. On each guess, report to the user that they are correct or that the guess is over or 
 * under the target random number. Continue accepting guesses until the user guesses correctly or chooses to quit. Count the number of guesses and report 
 * value when the user guesses correctly. If a guess is out of the range 1 to 100, an appropriate message should be displayed to the user and the guess not
 * be counted. At the end of each game (by quitting or a correct guess), prompt to determine whether the user wants to play again. Continue playing another 
 * game until the user chooses to stop.
 * 
 * This is actually the 4th time I've written a game like this (the other ones were in C++) but this was still tricky for me :) 
 */
public class GuessingGame {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);
        Random generator = new Random();
        int answer, playerGuess, numberGuesses = 0;
        boolean restartGame;
        char input;

        do {
            restartGame = true;
            answer = generator.nextInt(100) + 1; // gen number for first round

            while (restartGame) {
                System.out.println("Guess a number between 1 and 100, or press 'q' to quit.");

                String userInput = scan.next();

                if (userInput.equalsIgnoreCase("q")) {
                    restartGame = false; // Exit the game loop
                } else {
                    try {
                        playerGuess = Integer.parseInt(userInput);

                        if (playerGuess >= 1 && playerGuess <= 100) {
                            numberGuesses++;

                            if (playerGuess == answer) {
                                System.out.println("This guess is correct. You win. You have guessed " + numberGuesses
                                        + " times. Game over.");
                                System.out.println("Would you like to play again? Hit 'Y' to continue, 'N' to quit.");
                                input = scan.next().charAt(0);

                                if (input == 'Y' || input == 'y') {
                                    restartGame = true; // Restart the game
                                    answer = generator.nextInt(100) + 1; // re-roll our number
                                    numberGuesses = 0; // reset the guesses
                                } else {
                                    restartGame = false; // Exit the game loop
                                }
                            } else if (playerGuess > answer) {
                                System.out.println("The correct number is lower than your guess.");
                            } else {
                                System.out.println("The correct number is higher than your guess.");
                            }
                        } else {
                            System.out.println("Invalid input. Please enter a number between 1 and 100.");
                        }
                    } catch (NumberFormatException e) {
                        System.out.println("Invalid input. Please enter a valid number or 'q' to quit.");
                    }
                }
            }
        } while (restartGame);

        scan.close();
    }
}