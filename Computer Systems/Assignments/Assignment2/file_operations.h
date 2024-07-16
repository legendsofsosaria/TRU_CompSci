/*
Elizabeth House
COMP 2131
07/16/2024
Programming Assignment #2
Version 1

Function headers
*/

#ifndef FILE_OPERATIONS_H
#define FILE_OPERATIONS_H

typedef struct 
{
    char name[50];
    char emailID[50];
    int studentID, courseID, grade;
} Record;

/* function declarations */
void open_file(const char* filename, FILE **file);
void create_record(FILE *file, Record new_record);
void display_file(FILE *file, Record record);
void seek_record(FILE *file, Record record);
void update_file(FILE *file, const char *name, Record new_data);
void delete_record(FILE *file, const char *name, Record record_to_delete);
void close_file(FILE *file);
void clear_input_buffer();

#endif