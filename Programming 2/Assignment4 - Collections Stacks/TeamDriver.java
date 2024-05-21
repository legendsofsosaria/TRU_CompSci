import java.util.*;

/**
 * Elizabeth House
 * 02/21/2024
 * Makes an array list of students applying, checks GPA, prints list of students who do and do not qualify, 
 * removes and lists last applicant, and sorts GPA in descending order.
 */
public class TeamDriver
{
    public static void main(String[] args)
    {
        Team<Student> studentList = new Team<>();
        
        Student standard = new Student(3.67, "Standard Student");
        
        /* Create a list of members applying */
        studentList.addToTeam(new Student(3.98, "Kelly"));
        studentList.addToTeam(new Student(2.44, "Joshua"));
        studentList.addToTeam(new Student(3.77, "Leonard"));
        studentList.addToTeam(new Student(1.99, "George"));
        studentList.addToTeam(new Student(3.69, "Lisa"));
        studentList.addToTeam(new Student(3.88, "Fred"));
        studentList.addToTeam(new Student(3.66, "Albert"));
        studentList.addToTeam(new Student(3.67, "Jason"));
        
        /* Print list of members applying */
        System.out.println("The following students want to join the competition team:");
        for (Student student : studentList.getMemberList()) 
        {
            System.out.println(student);
        }
        
        /* Print the number of members applying */
        System.out.println("\nTotal Number of Students: " + studentList.getNumberOfMembers());
        
        /* Print students who do not fulfill GPA requirements */
        System.out.println("\nStudents who do not fulfill cumulative GPA requirements:");
        for (Student student : studentList.getMemberList()) 
        {
            if (student.getGPA() < standard.getGPA()) 
            {
                System.out.println(student);
            }
        }
        
        /* Form a candidate list of students who have fulfilled the cumulative GPA requirement */
        Team<Student> candidateList = new Team<>();
        for (Student student : studentList.getMemberList()) 
        {
            if (student.getGPA() >= standard.getGPA()) 
            {
                candidateList.addToTeam(student);
            }
        }
        
        /* Print candidates who have fulfilled cumulative GPA requirement  */
        System.out.println("\nCandidates who have fulfilled cumulative GPA requirement (3.67):");
        if (!candidateList.hasNoMember())
        {
            System.out.println(candidateList);
        }
        else
        {
            System.out.println("No candidate has been selected!\n");
        }
        
        /* Remove the last candidate from studentList and print */
        System.out.println("The following candidate who last submitted their application has been removed from the list:");
        Student removedCandidate = candidateList.removeFromTeam();
        if (removedCandidate != null) 
        {
            System.out.println("Name: " + removedCandidate.getName() + "; Cumulative GPA: " + removedCandidate.getGPA() + "\n");
        }
        
        /* Sort the final list of candidates in descending order according to their cumulative GPA and print */
        System.out.println("The candidates sorted in descending order based on their cumulative GPA:");
        if (!candidateList.hasNoMember())
        {
            Collections.sort(candidateList.getMemberList(), Collections.reverseOrder());
            System.out.println(candidateList);
        }
        else
        {
            System.out.println("No candidate in the list.");
        }
    }
}
