# This program opens an output file, writes name to file, then closes file

def main():
    try:
        # Opens the file
        myfile = open('my_name.txt', 'w')
        name1 = "Elizabeth House"
        myfile.write(name1 + '\n')

        myfile.close()
        print('The name was written to the file.')
        
    except Exception as e:
        print('An error occurred.', e)
                  
main()
                  
