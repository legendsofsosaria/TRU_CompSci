# This program demonstrates reading from a file

def main():

    try:
        # Open the file for reading
        infile = open('my_name.txt', 'r')

        # Read name from file
        line1 = infile.readline()

        # Strip the \n from the string
        line1 = line1.rstrip('\n')

        # Close the file
        infile.close()

        #Print data that was read to memory
        print(line1)

    except IOError:
        print('An error occurred trying to read the file.')
        
    except Exception as e:
        print('An error occurred.', e)

main()
