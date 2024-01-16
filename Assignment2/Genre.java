
/**
 * Elizabeth Gress T00738901
 * COMP 1231 Assignment 2
 * 01/13/2024
 */
public interface Genre
{
    final int UNCLASSIFIED = 0;
    final int FANTASY = 1;
    final int SCIFI = 2;
    final int ROMANCE = 3;
    
    /* Gets the genre of the book */
    public int getGenre();
    
    /* Sets the genre of the book */
    public void setGenre(int genre);
}
