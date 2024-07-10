#ifndef FILE_OPERATIONS_H
#define FILE_OPERATIONS_H

typedef struct 
{
    char name[50];
    int studentID, emailID, courseID, grade;
} Record;

/* function declarations */
void create_file(const char *filename);
void display_file(const char *filename);
void seek_record(const char *filename, const char *name);
void update_file(const char *filename, const char *name, Record new_data);
void delete_record(const char *filename, const char *name);

#endif