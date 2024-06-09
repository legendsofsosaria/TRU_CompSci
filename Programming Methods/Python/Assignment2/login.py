# Elizabeth House T00738901
# COMP 2211 Programming Methods
# Assignment 2 Version 4
# 06/09/2024

import verify

# Generates a username with 3 first letters of first name
# first 3 letters of last name, and last 3 digits of ID number
# If name is 3 characters, assign those 3 characters to the username. 
def get_login_name(first, last, id):

    username = first[0:3] + last[0:3] + id[-3:] 
    return username

# Prompts user to input first name, last name and ID number
# Calls the method to generate login name
# Prints login name after generation
# Prompts the user to input a password
# Calls the method to validate the password
# Handles exceptions
def main():
    try:
        print("Username Creation")
        print("-------------------")
        first_name = input("Enter your first name: ")

        # Added validation to be sure the first name input is actually a name
        while not first_name.isalpha():
                print("Invalid input.")
                print("Please enter alphabetic characters only.")
                first_name = input("Please enter your first name: ")

        last_name = input("Enter your last name: ")

        # Added validation to be sure the last name input is actually a name
        while not last_name.isalpha():
                print("Invalid input.")
                print("Please enter alphabetic characters only.")
                last_name = input("Please enter your last name: ")

        id_number = input("Enter your student ID number: ")

        # Added validation to be sure the user inputs something for ID number
        while not id_number.isalnum():
            print("Invalid input.")
            print("You must input an ID number.")
            id_number = input("Enter your student ID number: ")

        username = get_login_name(first_name, last_name, id_number)
        print("Your login name is:", username, "\n")

        print("Password Creation")
        print("-------------------")
        print("Passwords must be at least 7 characters in length.")
        print("Passwords must contain at least one uppercase letter, one lowercase letter, and one digit.")
        entered_password = input("Enter a password: ")

        # If password is not valid, user needs to re-enter password
        while not verify.verify_password(entered_password):
            print("That password is not valid.")
            entered_password = input("Enter a password: ")
        
        print("Password is valid.")
    
    # Exception handling
    except KeyboardInterrupt:
        print("Program interrupted by user.")
    except Exception as e:
        print('An error occurred.', e)
main()