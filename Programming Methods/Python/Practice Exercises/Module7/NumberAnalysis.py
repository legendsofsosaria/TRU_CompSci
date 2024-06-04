# Design a program that asks the user to enter a series of 20 numbers. 
# The program should store the numbers in a list then display the following data:
# lowest number in the list
# highest number in the list
# the total of the numbers in the list
# the average of the numbers in the list

def main():
    
    try:
        # Create empty list
        numbers = []

        # Create number for accumulator
        total = 0

        # have user input 20 numbers
        for i in range(20):
            while True:
                try:
                    int(input(f"Enter number {i+1}: "))
                    numbers.append(num)
                    break
                except ValueError:
                    print("Invalid input. Please enter a valid integer.")

        total = sum(numbers)
            
        average = total / len(numbers)
        
        print("The lowest number is: ", min(numbers))
        print("The highest number is: ", max(numbers))
        print("The total is: ", total)
        print("The average is: ", average)
    
    except Exception as err:
       print('An error has occurred', err)

main()
    


