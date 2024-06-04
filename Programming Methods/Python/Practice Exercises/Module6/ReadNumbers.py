# Opens numbers file, reads all of the numbers from the file
# displays the numbers, adds the numbers up and displays the total

def main():

    # Initialize the accumulator
    total = 0
    
    try:
        # Opens file for reading
        infile = open('number_list.txt', 'r')

        for line in infile:
            # Convert line to int after stripping whitespace
            amount = int(line.strip()) 
            total += amount
            print(amount)

        #Display the file's contents
        print('Total:', total)

        # Close the file
        infile.close()

    except IOError:
        print('An error occurred while trying to read the file.')

    except Exception as e:
        print('An error occurred.', e)

main()
