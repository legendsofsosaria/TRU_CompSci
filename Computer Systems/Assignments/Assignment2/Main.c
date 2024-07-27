/* 
Elizabeth House
COMP 2131
07/27/2024
Programming Assignment #2
Version 2

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
#include <string.h>

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

        // Handle input for menu selection
        if (scanf("%d", &selection) != 1) 
        {
            fprintf(stderr, "Invalid input. Please enter a number.\n");
            clear_input_buffer();
            continue;
        }
        clear_input_buffer(); /* Clear newline from input buffer */

        /* Switch for user's selection */
        switch (selection)
        {
            case 1:
                printf("Creating File...\n");
                open_file(filename, &file);
                create_record(file, &record);
                close_file(file);
                break;
            case 2:
                open_file(filename, &file);
                if (file == NULL)
                {
                    printf("\nFile not created yet. Please create the file first.\n");
                } 
                else 
                {
                    printf("\nDisplaying File...\n");
                    display_file(file, &record);
                    close_file(file);
                }
                break;
            case 3:
                open_file(filename, &file);
                if (file == NULL)
                {
                    printf("\nFile not created yet. Please create the file first.\n");
                }
                else
                {
                    printf("\nSeeking Record...\n");
                    printf("Enter the name of the student to search: ");
                    fgets(name, sizeof(name), stdin);
                    name[strcspn(name, "\n")] = '\0'; /* Remove newline character */
                    seek_record(file, &record, name);
                    close_file(file);
                }
                break;
            case 4:
                open_file(filename, &file);
                if (file == NULL)
                {
                    printf("\nFile not created yet. Please create the file first.\n");
                }
                else
                {
                    printf("\nUpdate File\n");
                    printf("Enter the name of the student to update record: ");
                    fgets(name, sizeof(name), stdin);
                    name[strcspn(name, "\n")] = '\0'; /* Remove newline character */
                    update_file(file, name, &record);
                    close_file(file);
                }
                break;
            case 5:
                open_file(filename, &file);
                if (file == NULL)
                {
                    printf("\nFile not created yet. Please create the file first.\n");
                }
                else
                {
                    printf("\nDelete Record in File\n");
                    printf("Enter the name of the student to delete: ");
                    fgets(name, sizeof(name), stdin);
                    name[strcspn(name, "\n")] = '\0'; /* Remove newline character */
                    delete_record(file, name, &record);
                    close_file(file);
                }
                break;
            case 6:
                printf("\nExiting...\n");
                break;
            default:
                printf("\nInvalid choice. Please try again.\n");
        }
    } while (selection != 6);

    return 0;
}