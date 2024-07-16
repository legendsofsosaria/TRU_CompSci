#include <stdio.h>
#include "file_operations.h"
#include <stdlib.h>

/* Create the file */
void create_file(const char* filename, FILE **file)
{
    *file = fopen(filename, "ab+");
    int valid_input = 0;

    if (*file == NULL)
    {
        perror("File Error!");
        exit(1);
    }

    Record record;
    
    while (!valid_input) 
    {
        printf("What is the student name?\n");
        if (scanf("%s", record.name) != 1) 
        {
            fprintf(stderr, "Error reading student name.\n");
            clear_input_buffer();
            continue;
        }

        printf("What is the student's ID number?\n");
        if (scanf("%d", &record.studentID) != 1) 
        {
            fprintf(stderr, "Error reading student ID.\n");
            clear_input_buffer();
            continue;
        }

        printf("What is the student's email ID?\n");
        if (scanf("%s", record.emailID) != 1) 
        {
            fprintf(stderr, "Error reading email ID.\n");
            clear_input_buffer();
            continue;
        }

        printf("What is the student's course ID number?\n");
        if (scanf("%d", &record.courseID) != 1) 
        {
            fprintf(stderr, "Error reading course ID.\n");
            clear_input_buffer();
            continue;
        }

        printf("What is the student's numeric grade value?\n");
        if (scanf("%d", &record.grade) != 1) 
        {
            fprintf(stderr, "Error reading grade.\n");
            clear_input_buffer();
            continue;
        }

        valid_input = 1;
    }

    if (fwrite(&record, sizeof(Record), 1, *file) != 1) 
    {
        fprintf(stderr, "Error writing record to file.\n");
    }
}

/* Display the file */
void display_file(FILE *file)
{
    rewind(file);

    Record record;

    while (fread(&record, sizeof(Record), 1, file) == 1) {
 
        printf("Name: %s, Student ID: %d, Email ID: %s, Course ID: %d, Grade: %d\n", \
        record.name, record.studentID, record.emailID, record.courseID, record.grade);
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

/* Search for a record */
void seek_record(FILE *file, const char* name)
{
    fseek(file, 0, SEEK_SET);

    char ch = fgetc(file);
    if (ch != EOF)
    {
        printf("First character in the file: %c\n", ch);
    }
}

/* Update the file */
void update_file(FILE *file, const char* name, Record new_data)
{   
    
}

/* Delete specified record */
void delete_record(FILE *file, const char* name)
{

}

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

