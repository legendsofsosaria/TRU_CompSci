
/**
 * Elizabeth House
 * 02/14/2024
 * Creates a class of student with string name and cumulative GPA of student. 
 * Implements comparable so that students can be compared according to cumulative GPA.
 */
public class Student implements Comparable<Student>
{
    private double cGPA;
    private String name;
    
    /* Construct the student with default */
    public Student()
    {
        this.name = null;
        this.cGPA = 0;
    }
    
    /* Parameterized constructor */
    public Student(double cGPA, String name)
    {
        this.name = name;
        this.cGPA = cGPA;
    }
    
    /* Get the name of the student */
    public String getName()
    {
        return name;
    }
    
    /* Set the name of the student */
    public void setName(String name)
    {
        this.name = name;
    }
    
    /* Get the student's GPA */
    public double getGPA()
    {
        return cGPA;
    }
    
    /* Set the student's GPA */
    public void setGPA(double cGPA)
    {
        this.cGPA = cGPA;
    }
    
    /* Compares the student's GPAs */
    public int compareTo(Student otherStudent)
    {
        return Double.compare(this.getGPA(), otherStudent.getGPA());
    }
    
    /* Converts name and GPA to string */
    public String toString() 
    {
        return "Name: " + name + "; Cumulative GPA: " + cGPA;
    }
}
