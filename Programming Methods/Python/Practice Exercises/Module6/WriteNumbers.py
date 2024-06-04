# Opens an output file, uses a loop to write the numbers 1 through 100
# then closes the file.

def main():
    try:
        # Opens file for writing
        outfile = open('number_list.txt', 'w')

        # Loop to write numbers 1 through 100
        for num in range(1, 101):
            outfile.write(str(num) + '\n')

        # Close the file
        outfile.close()

        print('File written')

    except Exception as e:
        print('An error occurred.', e)

main()
        
