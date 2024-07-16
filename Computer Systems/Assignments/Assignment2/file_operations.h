#ifndef FILE_OPERATIONS_H
#define FILE_OPERATIONS_H

typedef struct 
{
    char name[50];
    char emailID[50];
    int studentID, courseID, grade;
} Record;

/* function declarations */
void create_file(const char *filename, FILE **file);
void display_file(FILE *file);
void seek_record(FILE *file, const char *name);
void update_file(FILE *file, const char *name, Record new_data);
void delete_record(FILE *file, const char *name);
void close_file(FILE *file);
void clear_input_buffer();

#endif