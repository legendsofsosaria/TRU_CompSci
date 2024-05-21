# Elizabeth House T00738901
# 05/20/2024
# Assignment 1 - Python

import math

def main():
    # Prompt user to input the account's present value, monthly interest rate, and number of months the money will be left in account
    presentValue = get_valid_input("Enter the account's present value in dollars without the comma: ", MIN_PRESENT_VALUE, MAX_PRESENT_VALUE)
    interest = get_valid_input("Enter the interest rate in percent value: ", MIN_INTEREST_RATE, MAX_INTEREST_RATE)

    # Divide the interest user inputs by 100 to get interest rate
    interestRate = interest / 100.0

    # Input validation for number of months
    while True:
        try:
            numberMonths = int(input("Enter the number of months the money will be left in the account: "))
            
            if MIN_NUMBER_MONTHS <= numberMonths <= MAX_NUMBER_MONTHS:
                break
            else:
                print("Number of months must be between", MIN_NUMBER_MONTHS, "and", MAX_NUMBER_MONTHS)
                
        #Exception for invalid user input     
        except ValueError:
            print("Invalid input. Please enter an integer value.")
    
    # Call calc_future_value function and store the result
    futureValue = calc_future_value(presentValue, interestRate, numberMonths)

    # Display the account's future value
    print("The account's future value is: $", format(futureValue, ',.2f'))

def calc_future_value(value, interest, months):
    #Calculate the future amount using the formula F = P * (1 + i)^t
    futureAmount = value * (1 + interest) ** months

    # Return the calculated average
    return futureAmount

def get_valid_input(prompt, min_val, max_val):
    while True:
        try:
            user_input = float(input(prompt))

            if min_val <= user_input <= max_val:
                return user_input
            else:
                print("Input must be between", min_val, "and", max_val)

        #Exception for invalid user input
        except ValueError:
            print("Invalid input. Please enter a numeric value.")

# Constants for input validation
MIN_PRESENT_VALUE = 0
MAX_PRESENT_VALUE = 1000000  # Example upper limit for present value: $1,000,000

MIN_INTEREST_RATE = 0
MAX_INTEREST_RATE = 5  # Example upper limit for interest rate: 5%

MIN_NUMBER_MONTHS = 0
MAX_NUMBER_MONTHS = 120  # Example upper limit for number of months: 10 years (120 months)
                
    
main()
