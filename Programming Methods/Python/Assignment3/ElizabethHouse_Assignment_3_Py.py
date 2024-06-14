# Elizabeth House T00738901
# COMP 2211 Programming Methods
# Assignment 3 Version 2
# 06/14/2024
# A company uses codes to represent its products, for example ABC2475A5R-14. 
# Write a Python program that will read 10 product codes from a text file. 
# Determine if each code conforms to the rules. 

def is_valid_code(code):

    # Codes must be at least 10 characters (some codes have more than 10 characters)
    if (len(code) < 10):
         return False
    
    # Check if position 4 through 7 are digits
    for i in range(3, 7):
        if not code[i].isdigit():
            return False
        
    # Check if 10th character is a capital letter
    if not code[9].isupper():
        return False
        
    return True

def main():
    valid_codes = []
    invalid_codes = []
    invalid_restricted_codes = []

    try:
        # Open file for reading
        infile = open("A3 Codes.txt", 'r')

        # Read lines from file
        codes = infile.readlines()

        infile.close()

        for code in codes:
            code = code.strip() # Remove any leading/trailing whitespace

            if is_valid_code(code):
                valid_codes.append(code)
                # Check if it's restricted and violates new law
                if code[9] == 'R' and int(code[3:7]) >= 2000:
                    invalid_restricted_codes.append(code)
            else:
                invalid_codes.append(code)

        # If it does conform, print a heading: Valid Code(s) are: and list the codes that are valid.
        print("Valid Code(s) are: ")
        for code in valid_codes:
            print(code)
        print("\n")
        
        # Print invalid code(s)
        print("Invalid Code(s) are: ")
        for code in invalid_codes:
            print(code)
        print("\n")

        # Invalid Restricted Code(s) are: and list the codes that are invalid in case you encounter 
        # any products that violate these new laws.
        print("Invalid Restricted Code(s) are: ")
        for code in invalid_restricted_codes:
            print(code)

    except IOError:
        print("An error has occurred while trying to read the file.")

    except Exception as e:
        print("An error has occurred.")

main()

