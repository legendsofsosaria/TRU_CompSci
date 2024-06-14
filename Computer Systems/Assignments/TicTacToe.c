/* Elizabeth House T00738901
COMP 2131
06/09/2024
Programming Assignment #1
*/

#include <stdio.h>
#include <stdlib.h>
#include <time.h>

#define SIZE 3 /* Game board is a 3x3 */

/* Global variables */
char board[SIZE][SIZE];
char player = 'X';
char computer = 'O';

/* Function prototypes */
void printBoard();
void initializeBoard();
int checkWin();
void playerMove();
void computerMove();
int playAgain();

int main()
{
    /* Initialize a char array with 10 characters for a name */
    char name[10];
    int gameStatus = 0; /* 0 is ongoing, 1 is win, -1 is draw */

    srand(time(NULL)); /* Initialize a random seed */

    /* While the game is ongoing, print the board, have the player and computer perform moves */
    do 
    {
        gameStatus = 0;
        printf("**********************************************\n");
        printf("Tic Tac Toe\n");
        printf("COMP 2131 06/2024\n");
        printf("You will be playing against the computer\n");
        printf("**********************************************\n");
        printf("Enter player name and press enter: \n\n");
        scanf("%9s", name);

        printf("Hello, %s... Let's have fun! You = X Computer = O\n\n\n", name);
        initializeBoard();

        while (gameStatus == 0)
        {
            printBoard();
            playerMove();
            printBoard();
            gameStatus = checkWin();

            if (gameStatus != 0) break;
            computerMove();
            gameStatus = checkWin();
        }
    
        printBoard();

        /* Check if there is a winner, and output results. Ask player if they want to play again */
        if (gameStatus == 1)
        {
            printf("Congratulations, %s! You win!\n", name);
        }
        else if (gameStatus == -1)
        {
            printf("It's a draw!\n");
        }
        else
        {
            printf("You lose! Better luck next time.\n");
        }
    } 
    while (playAgain());

    return 0;
}

/* Sets up empty board. Loops through 3x3 cells [index 0-2] and assigns empty 
character to represent empty cells*/
void initializeBoard() 
{
    for (int i = 0; i < SIZE; i++) 
    {
        for (int j = 0; j < SIZE; j++) 
        {
            board[i][j] = ' ';
        }
    }
}

/* Function to print the game board */
void printBoard() 
{
    printf("   1  2  3\n"); /* Print column number */

    for (int i = 0; i < SIZE; i++) 
    {
        printf("%d", i + 1); /* Print row number */

        for (int j = 0; j < SIZE; j++) 
        {
            printf(" %c ", board[i][j]);
            if (j < SIZE - 1) printf("|");
        }
        printf("\n");

        if (i < SIZE - 1) printf(" ---|---|---\n");
    }
    printf("\n");
}

/* Function to check if there is a win or a draw. Returns 1 if the player wins
-1 if it is a draw, and 2 if the computer wins */
int checkWin() 
{
    /* Check rows and columns */
    for (int i = 0; i < SIZE; i++) 
    {
        if (board[i][0] == board[i][1] && board[i][1] == board[i][2] && board[i][0] != ' ') return board[i][0] == player ? 1 : 2;
        if (board[0][i] == board[1][i] && board[1][i] == board[2][i] && board[0][i] != ' ') return board[0][i] == player ? 1 : 2;
    }
    /* Check diagonals */
    if (board[0][0] == board[1][1] && board[1][1] == board[2][2] && board[0][0] != ' ') return board[0][0] == player ? 1 : 2;
    if (board[0][2] == board[1][1] && board[1][1] == board[2][0] && board[0][2] != ' ') return board[0][2] == player ? 1 : 2;

    /* Check for draw */
    for (int i = 0; i < SIZE; i++) 
    {
        for (int j = 0; j < SIZE; j++) 
        {
            if (board[i][j] == ' ') return 0; /* Game continues */
        }
    }
    return -1; /* Draw */
}

/* Function to get the player's move and validate it */
void playerMove() 
{
    int x, y;
    printf("Enter X,Y coordinates for your move (e.g., 1,1 or 1, 1): ");

    while (scanf("%d%*[, ]%d", &x, &y) != 2 || x < 1 || x > SIZE || y < 1 || y > SIZE || board[x-1][y-1] != ' ') 
    {
        /* Clear the input buffer */
        while (getchar() != '\n');
        printf("Invalid move! Try again: ");
    }
    board[x-1][y-1] = player;
}

/* Function to generate the computer's move */
void computerMove() 
{
    int x, y;

    /* Generate a random move for the computer's move */
    do 
    {
        x = rand() % SIZE;
        y = rand() % SIZE;
    } 
    while (board[x][y] != ' ');
    board[x][y] = computer;
    printf("Computer moves to %d,%d\n", x+1, y+1);
}

/* Function to check if player wants to play again */
int playAgain()
{
    char again;

    while(1)
    {
        printf("Would you like to play again?\n");
        printf("Press Y for yes, N for no.\n");

        scanf(" %c", &again);

        if (again == 'Y' || again == 'y')
        {
            return 1;
        }
        /* User says no */
        else if (again == 'N' || again == 'n')
        {
            printf("Thanks for playing!\n");
            return 0;
        }
        /* To handle invalid input and clear buffer */
        else
        {
            printf("Invalid input! Please enter Y or N.\n");
            while (getchar() != '\n'); 
        }
    }
}

