#include <stdio.h>
#include "file_operations.h"

/* Create the file */
void create_file(const char* filename)
{
    FILE* file;

    file = fopen("student_record.bin", "ab+");

    if (file == NULL)
    {
        perror("File Error!");
        exit(1);
    }
}

/* Display the file */
void display_file(const char *filename)
{

}

/* Search for a record */
void seek_record(const char *filename, const char* name)
{

}

/* Update the file */
void update_file(const char *filename, const char* name, Record new_data)
{   
    //size_t num_written = fwrite(&record)
}

/* Delete specified record */
void delete_record(const char *filename, const char* name)
{

}


