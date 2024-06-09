# Elizabeth House T00738901
# COMP 2211 Programming Methods
# Assignment 2 Version 2
# 06/09/2024

# Validates if password contains
# 1 uppercase letter, 1 lowercase letter, and 1 digit
# Checks if password is more than 6 characters in length
def verify_password(password):
    # Set boolean variables to false
    correct_length = False
    has_uppercase = False
    has_lowercase = False
    has_digit = False
    is_valid = False

    # Check that password is at least 7 characters
    if len(password) >= 7:
        correct_length = True

        # Test each character and set flag when required character is found
        for ch in password:
            if ch.isupper():
                has_uppercase = True
            if ch.islower():
                has_lowercase = True
            if ch.isdigit():
                has_digit = True
        
        # Determine if all requirements are met for password
        if correct_length and has_uppercase and \
        has_lowercase and has_digit:
            is_valid = True
        else:
            is_valid = False

    return is_valid