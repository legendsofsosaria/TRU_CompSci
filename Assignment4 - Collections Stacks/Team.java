import java.util.*;

/**
 * Elizabeth House
 * 02/14/2024
 * Create a generic class team with type parameter T. Implements adding members to team, removing members from team,
 * returning the size of the team, checking if the team does not have members, outputs members to string, and gets list of members.
 */
public class Team<T>
{
    private ArrayList<T> aList;
    
    /* Construct the array list */
    public Team()
    {
        aList = new ArrayList<>();
    }
    
    /* Add a member to the team */
    public void addToTeam(T member)
    {
        aList.add(member);
    }
    
    /* Remove a team member from the list */
    public T removeFromTeam() 
    {
        if (!aList.isEmpty()) 
        {
            return aList.remove(aList.size() - 1);
        } 
        else 
        {
            System.out.println("No candidate in the list.\n");
                return null;
        }
    }
    
    /* Returns the size of the team */
    public int getNumberOfMembers()
    {
        return aList.size();
    }
    
    /* Check if the team has no members */
    public boolean hasNoMember()
    {
        return aList.isEmpty();
    }
    
    /* outputs all members in array list to String. Each member is displayed on a separate line */
    public String toString()
    {
        StringBuilder stringBuilder = new StringBuilder();
        
        for (T member : aList)
        {
            stringBuilder.append(member.toString()).append("\n");
        }
        
        return stringBuilder.toString();
    }
    
    /* Used to get the list of members */
    public ArrayList<T> getMemberList() 
    {
        return aList;
    }
    
}
