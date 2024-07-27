/*
Elizabeth House
COMP 2131
07/27/2024
Programming Assignment #2
Version 2

File Handling Operations
*/

#include <stdio.h>
#include "file_operations.h"
#include <stdlib.h>
#include <string.h>

#define NAME_LENGTH 50

/* Create the file */
void open_file(const char* filename, FILE **file)
{
    /* Open for reading, writing (appending) */
    *file = fopen(filename, "ab+");

    /* File doesn't exist */
    if (*file == NULL)
    {
        perror("File Error!");
        exit(1);
    }
}

/* Function to create a student's record */
void create_record(FILE *file, Record *new_record)
{
    int valid_input = 0;

    while (!valid_input) 
    {   
        /* Add student's name */
        printf("What is the student's name?\n");
        if (fgets(new_record->name, NAME_LENGTH, stdin) == NULL) 
        {
            fprintf(stderr, "Error reading student name.\n");
            clear_input_buffer();
            return;
        }
        new_record->name[strcspn(new_record->name, "\n")] = '\0';  /* Remove newline character */

        /* Add student ID # */
        printf("What is the student's ID number?\n");
        if (scanf("%d", &new_record->studentID) != 1) 
        {
            fprintf(stderr, "Error reading student ID.\n");
            clear_input_buffer();
            continue;
        }
        clear_input_buffer();  /* Clear newline left by scanf */

        /* Add student email ID */
        printf("What is the student's email ID?\n");
        if (fgets(new_record->emailID, NAME_LENGTH, stdin) == NULL) 
        {
            fprintf(stderr, "Error reading email ID.\n");
            clear_input_buffer();
            return;
        }
        new_record->emailID[strcspn(new_record->emailID, "\n")] = '\0';  /* Remove newline character */

        /* Add student course ID # */
        printf("What is the student's course ID number?\n");
        if (scanf("%d", &new_record->courseID) != 1) 
        {
            fprintf(stderr, "Error reading course ID.\n");
            clear_input_buffer();
            continue;
        }
        clear_input_buffer();  /* Clear newline left by scanf */

        /* Add student grade */
        printf("What is the student's numeric grade value?\n");
        if (scanf("%d", &new_record->grade) != 1) 
        {
            fprintf(stderr, "Error reading grade.\n");
            clear_input_buffer();
            continue;
        }
        clear_input_buffer();  /* Clear newline left by scanf */

        valid_input = 1;
    }
    if (fwrite(new_record, sizeof(Record), 1, file) != 1) 
    {
        fprintf(stderr, "Error writing record to file.\n");
    }
}

/* Function to display contents of the student records */
void display_file(FILE *file, Record *record)
{
    rewind(file); /* Make sure we are reading from the start of the file... */

    while (fread(record, sizeof(Record), 1, file) == 1) 
    {
        printf("Name: %s, Student ID: %d, Email ID: %s, Course ID: %d, Grade: %d\n", \
        record->name, record->studentID, record->emailID, record->courseID, record->grade);
    }

    if (feof(file)) 
    {
        printf("End of file reached.\n");
    } 
    else if (ferror(file)) 
    {
        perror("Error reading file");
    }
}

/* Function to seek a specific student record */
void seek_record(FILE *file, Record *record, const char *search_name)
{
    printf("Seeking Record...\n");

    int found = 0;
    rewind(file);  /* Make sure we are reading from the start of the file... */

    while (fread(record, sizeof(Record), 1, file) == 1) 
    {
        if (strcmp(record->name, search_name) == 0) 
        {
            printf("Record found:\n");
            printf("Name: %s, Student ID: %d, Email ID: %s, Course ID: %d, Grade: %d\n", \
            record->name, record->studentID, record->emailID, record->courseID, record->grade);
            found = 1;
            break; 
        }
    }
    if (!found)
    {
        printf("Record not found.\n");
    }
}

/* Function to update a student's record */
void update_file(FILE *file, const char *name, Record *new_data)
{
    FILE *tempFile = fopen("temp.bin", "wb");
    if (tempFile == NULL)
    {
        perror("Error creating temporary file.");
        return;
    }

    int found = 0;

    rewind(file); /* Make sure we are reading from the start of the file... */

    while (fread(new_data, sizeof(Record), 1, file) == 1) 
    {
        if (strcmp(new_data->name, name) == 0) 
        {
            found = 1;
            printf("Enter updated information for %s:\n", name);
            create_record(tempFile, new_data);
        }
        else
        {
            fwrite(new_data, sizeof(Record), 1, tempFile);
        }
    }

    fclose(file);
    fclose(tempFile);

    remove("student_record.bin");
    rename("temp.bin", "student_record.bin");
    printf("Student record updated.\n");

    if (!found)
    {
        printf("Student record not found.\n");
    }
}

/* Function to delete a student's record */
void delete_record(FILE *file, const char *name, Record *record_to_delete)
{
    FILE *tempFile = fopen("temp.bin", "wb");
    if (tempFile == NULL)
    {
        perror("Error creating temporary file.");
        return;
    }

    int found = 0;

    rewind(file); /* Make sure we are reading from the start of the file... */

    while (fread(record_to_delete, sizeof(Record), 1, file) == 1) 
    {
        if (strcmp(record_to_delete->name, name) == 0) 
        {
            found = 1;
        }
        else
        {
            fwrite(record_to_delete, sizeof(Record), 1, tempFile);
        }
    }

    fclose(file);
    fclose(tempFile);

    remove("student_record.bin");
    rename("temp.bin", "student_record.bin");

    if (found)
    {
        printf("Student record deleted.\n");
    }
    else
    {
        printf("Student record not found.\n");
    }
}

/* Function to close the file */
void close_file(FILE *file)
{
    if (file != NULL)
    {
        fclose(file);
    }
}

/* Function to clear the input buffer */
void clear_input_buffer()
{
    int c;
    while ((c = getchar()) != '\n' && c != EOF);
}

