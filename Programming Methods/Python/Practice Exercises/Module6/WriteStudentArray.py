# This program opens an output file, writes name to file, then closes file

def main():
    try:
        # Opens the file
        myfile = open('students.txt', 'w')
        students = [['Elizabeth House', 97], ['Pam Beesly', 64], ['Jim Halpert', 87], ['Michael Scott', 43],
                    ['Dwight Schrute', 82], ['Creed Bratton', 54], ['Kevin Malone', 35], ['Kelly Kapoor', 68],
                    ['Ryan Howard', 84], ['Toby Flenderson', 95]]
    
        for student in students:
            name, score = student
            myfile.write(f'{name}, {score}\n')

        myfile.close()
        print('The names and scores were written to the file.')

    except Exception as e:
        print('An error occurred.', e)
                  
main()
                  
