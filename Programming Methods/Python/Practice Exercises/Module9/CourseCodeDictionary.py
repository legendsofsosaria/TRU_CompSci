# Write a program that creates a dictionary containing course numbers and room numbers
# of the rooms where courses meet. The dictionary should have the following key-value pairs:
# Course number (key)       Room Number (value)
# CS101                     3004
# CS102                     4501
# CS103                     6755
# NT110                     1244
# CM241                     1411
# The program should also create a dictionary containing course numbers and the names of the 
# instructors who teach each course. The dictionary should have the following key-value pairs:
# CS101                     Haynes
# CS102                     Alvarado
# CS103                     Rich
# NT110                     Burke
# CM241                     Lee
# The program should also create a dictionary containing course numbers and the meeting times of each course. 
# The dictionary should have the following key-value pairs:
# CS101                     8:00 AM
# CS102                     9:00 AM
# CS103                     10:00 AM
# NT110                     11:00 AM
# CM241                     1:00 PM
# The program should let the user enter a course number, then it should display the course's room number,
# instructor, and meeting time. 

def main():

    course_dict = {"CS101" : [3004, "Haynes", "8:00 AM"], "CS102" : [4501, "Alvarado", "9:00 AM"], \
                    "CS103" : [6755, "Rich", "10:00 AM"], "NT110" : [1244, "Burke", "11:00 AM"], "CM241" : [1411, "Lee", "1:00 PM"]}

    print("**Course code information**")
    course_num = input("Enter a course number: ")

    if (course_num in course_dict):
        print(course_dict[course_num])
    else:
        print("Error. Course code not found.")

main()
