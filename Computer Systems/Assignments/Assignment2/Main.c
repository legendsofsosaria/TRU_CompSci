/* 
Elizabeth House
COMP 2131
07/16/2024
Programming Assignment #2
Version 1

Write a menu driven program to create and manage the records in the binary file 
The record structure for the binary file is:
Student ID
Student Name
Email ID
Course ID
Grade 
*/

#include <stdio.h>
#include "file_operations.h"


int main()
{
    int selection;
    FILE *file = NULL;
    const char *filename = "student_record.bin";
    char name[50];
    Record record;

    do 
    {
        /* Display menu options */
        printf("\n      M A I N  M E N U\n");
        printf("1. Create the binary file\n");
        printf("2. Display the contents of the file\n");
        printf("3. Seek a specific record\n");
        printf("4. Update the contents of a record\n");
        printf("5. Delete a record for the specific name\n");
        printf("6. Exit\n");
        printf("\n         Please enter your choice: \n");
        scanf("%d", &selection);

        /* Switch for user's selection */
        switch (selection)
        {
            case 1: /* Creates file if it doesn't exist. Adds a record to the file. */
                printf("Creating File...\n");
                open_file(filename, &file);
                create_record(file, record);
                close_file(file);
                break;
            case 2: /* Opens the file and displays the contents */
                open_file(filename, &file);

                if (file == NULL) /* Safety net */
                {
                    printf("\nFile not created yet. Please create the file first.\n");
                } 
                else 
                {
                    printf("\nDisplaying File...\n");
                    display_file(file, record);
                    close_file(file);
                }
                break;
            case 3: /* Opens the file and searches for a record by input name */
                open_file(filename, &file);

                if (file == NULL) /* Safety net */
                {
                    printf("\nFile not created yet. Please create the file first.\n");
                }
                else
                {
                    printf("\nSeeking Record...\n");
                    printf("Enter the name of the student to search: ");
                    seek_record(file, record);
                    close_file(file);
                }
                break;
            case 4: /* Option to update existing record in a file */
                open_file(filename, &file);

                if (file == NULL) /* Safety net */
                {
                    printf("\nFile not created yet. Please create the file first.\n");
                }
                else
                {
                    printf("\nUpdate File\n");
                    printf("Enter the name of the student to update record: ");
                    scanf("%s", name);
                    update_file(file, name, record);
                    close_file(file);
                }
                break;
            case 5: /* Deletes a record in the file by input name */
                open_file(filename, &file);

                if (file == NULL) /* Safety net */
                {
                    printf("\nFile not created yet. Please create the file first.\n");
                }
                else
                {
                    printf("\nDelete Record in File\n");
                    printf("Enter the name of the student to delete: ");
                    scanf("%s", name);
                    delete_record(file, name, record);
                    close_file(file);
                }
                break;
            case 6: /* Exiting the program */
                printf("\nExiting...\n");
                break;
            default: /* Default case for invalid choice */
                printf("\nInvalid choice. Please try again.\n");
        }
    } 
    while (selection != 6); /* Option 6 ends the program */

    return 0;
}