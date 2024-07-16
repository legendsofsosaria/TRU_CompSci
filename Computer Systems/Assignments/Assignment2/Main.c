/* Write a menu driven program to create and manage the records in the binary file 
The record structure for the binary file is:
Student ID
Student Name
Email ID
Course ID
Grade */

#include <stdio.h>
#include "file_operations.h"


int main()
{
    int selection;
    FILE *file;
    const char *filename = "student_record.bin";

    do 
    {
        /* Display menu options */
        printf("      M A I N  M E N U\n");
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
            case 1:
            printf("Creating File...\n");
            create_file(filename, &file);
            break;
            case 2:
            printf("Displaying File...\n");
            display_file(file);
            break;
            case 3:
            //seek_record();
            printf("Seek Record\n");
            break;
            case 4:
           // update_file();
           printf("Update File\n");
            break;
            case 5:
            //delete_record();
            printf("Delete Record in File\n");
            break;
            case 6:
            printf("Exiting...\n");
            break;
            default:
            printf("Invalid choice. Please try again.\n");
        }
    } 
    while (selection != 6); /* Option 6 ends the program */

    return 0;
}