# Read student records and removes one student's record from the file

import os # Needed for remove and rename functions

def main():
    try:
        # Create bool variable to use as a flag
        found = False

        # Get the student record to delete
        search = 'Creed Bratton'

        # Open the original file
        student_file = open('students.txt', 'r')

        # Open a temporary file
        temp_file = open('temp.txt', 'w')

        studentRecord = student_file.readline()

        while studentRecord != '':
            # Strip the \n from record
            studentRecord = studentRecord.rstrip('\n')

            # Split the line into name and score
            name, score = studentRecord.split(', ')

            print(f"Read: {name}, {score}") # Added for debugging

            # If this is not the record to delete, then write it to the temp file
            if name != search:
                # Write the record to the temp file
                temp_file.write(f'{name}, {score}\n')
            else:
                # Set found flag to true
                found = True
                removed_record = f'{name}, {score}'

            # Read next record
            studentRecord = student_file.readline()

        # Close the students file and temp file
        student_file.close()
        temp_file.close()

        # Delete the original student.txt file
        os.remove('students.txt')

        # Rename the temporary file
        os.rename('temp.txt', 'students.txt')

        # If the search value was not found in the file, display message
        if found:
            print('The file has been updated. Removed: ')
            print(removed_record)
        else:
            print('That item was not found in the file.')

    except Exception as e:
        print('An error occurred.', e)
        
main()
