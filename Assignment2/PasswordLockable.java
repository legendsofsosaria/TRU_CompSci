
/**
 * Elizabeth Gress T00738901
 * COMP 1231 Assignment 2
 * 01/13/2024
 */
public interface PasswordLockable
{
    /* Sets up a password */
    public void setPassword(String password);
    
    /* Unlocks book record with correct password */
    public void unlock(String password);
    
    /* Locks book record with correct password */
    public void lock(String password);
    
    /* Checks if book record is locked */
    public boolean isLocked();
}
