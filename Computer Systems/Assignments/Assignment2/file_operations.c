/*
Elizabeth House
COMP 2131
07/16/2024
Programming Assignment #2
Version 1

File Handling Operations
*/

#include <stdio.h>
#include "file_operations.h"
#include <stdlib.h>
#include <string.h>

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

void create_record(FILE *file, Record new_record)
{
    int valid_input = 0;
    
    /* Check for valid input for creating a record */
    while (!valid_input) 
    {   
        /* Add student's name */
        printf("What is the student's name?\n");
        if (scanf("%s", new_record.name) != 1) 
        {
            fprintf(stderr, "Error reading student name.\n");
            clear_input_buffer();
            continue;
        }
        /* Add student ID # */
        printf("What is the student's ID number?\n");
        if (scanf("%d", &new_record.studentID) != 1) 
        {
            fprintf(stderr, "Error reading student ID.\n");
            clear_input_buffer();
            continue;
        }
        /* Add student email ID */
        printf("What is the student's email ID?\n");
        if (scanf("%s", new_record.emailID) != 1) 
        {
            fprintf(stderr, "Error reading email ID.\n");
            clear_input_buffer();
            continue;
        }
        /* Add student course ID # */
        printf("What is the student's course ID number?\n");
        if (scanf("%d", &new_record.courseID) != 1) 
        {
            fprintf(stderr, "Error reading course ID.\n");
            clear_input_buffer();
            continue;
        }
        /* Add student grade */
        printf("What is the student's numeric grade value?\n");
        if (scanf("%d", &new_record.grade) != 1) 
        {
            fprintf(stderr, "Error reading grade.\n");
            clear_input_buffer();
            continue;
        }

        valid_input = 1;
    }
    /* Write student record to the binary file, if there is an error output it */
    if (fwrite(&new_record, sizeof(Record), 1, file) != 1) 
    {
        fprintf(stderr, "Error writing record to file.\n");
    }
}

/* Display the file */
void display_file(FILE *file, Record record)
{
    /* Go to beginning of file */
    rewind(file);

    /* Print the contents of the file */
    while (fread(&record, sizeof(Record), 1, file) == 1) {
 
        printf("Name: %s, Student ID: %d, Email ID: %s, Course ID: %d, Grade: %d\n", \
        record.name, record.studentID, record.emailID, record.courseID, record.grade);
    }

    /* Check for end of file */
    if (feof(file)) 
    {
        printf("End of file reached.\n");
    } 
    else if (ferror(file)) 
    {
        perror("Error reading file");
    }
}

/* Search for a record */
void seek_record(FILE *file, Record record)
{
    char search_name[50];

    clear_input_buffer();

    /* Search the record by name in the file */
    fgets(search_name, sizeof(search_name), stdin);
    search_name[strcspn(search_name, "\n")] = 0;

    int found = 0;
    while (fread(&record, sizeof(Record), 1, file) == 1) 
    {
        /* Compare input name to the record names */
        if (strcmp(record.name, search_name) == 0) 
        {
            /* Output if the record is found */
            printf("Record found:\n");
            printf("Name: %s, Student ID: %d, Email ID: %s, Course ID: %d, Grade: %d\n", \
            record.name, record.studentID, record.emailID, record.courseID, record.grade);
        
            found = 1;
            break; 
        }
    }
    if (found == 0)
    {
        printf("Record not found.\n");
    }
}

/* Update the file */
void update_file(FILE *file, const char *name, Record new_data)
{   
    /* Create a temporary file */
    FILE *tempFile = fopen("temp.bin", "wb");
    if (tempFile == NULL)
    {
        perror("Error creating temporary file.");
        return;
    }

    int found = 0;

    /* Go to beginning of file */
    rewind(file);
    while (fread(&new_data, sizeof(Record), 1, file) == 1) 
    {
        if (strcmp(new_data.name, name) == 0) 
        {
            found = 1; /* Name was found */
            printf("Enter updated information for %s:\n", name);
            create_record(tempFile, new_data);
        }
        else
        {
            fwrite(&new_data, sizeof(Record), 1, tempFile); /* Write to a temporary file */
        }
    }

    fclose(file);
    fclose(tempFile);

    /* Replace original with the temporary file */
    remove("student_record.bin");
    rename("temp.bin", "student_record.bin");
    printf("Student record updated.\n");
}

/* Delete specified record */
void delete_record(FILE *file, const char *name, Record record_to_delete)
{
    /* Create a temporary file */
    FILE *tempFile = fopen("temp.bin", "wb");
    if (tempFile == NULL)
    {
        perror("Error creating temporary file.");
        return;
    }

    int found = 0;

    /* Go to beginning of file */
    rewind(file);
    while (fread(&record_to_delete, sizeof(Record), 1, file) == 1) 
    {
        if (strcmp(record_to_delete.name, name) == 0) 
        {
            found = 1; /* Name was found, so we will skip it */
        }
        else
        {
            fwrite(&record_to_delete, sizeof(Record), 1, tempFile); /* Write names not found to a temporary file */
        }
    }

    fclose(file);
    fclose(tempFile);

    /* Replace original with the temporary file */
    remove("student_record.bin");
    rename("temp.bin", "student_record.bin");
}

/* Function to close the file */
void close_file(FILE *file)
{
    if (file != NULL)
    {
        fclose(file);
    }
}

void clear_input_buffer()
{
    int c;
    while ((c = getchar()) != '\n' && c != EOF);
}

