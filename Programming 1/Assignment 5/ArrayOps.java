import java.util.Random;

/**
 * Elizabeth Gress
 * 11/06/2023
 * design and implement a class called ArrayOps, which has a character array.
 * The constructor receives a parameter, which is the size of the array to
 * be dynamically allocated in the constructor, then populates that array with
 * random characters from the range ‘a’ through ‘z’.
 * Methods are required that return the lowest value and highest value, as well
 * as a String representation of the array values.
 */
public class ArrayOps {
    private char[] characterArray;

    /* Constructor for ArrayOps to create an array of random characters */
    public ArrayOps(int size) {
        characterArray = new char[size];
        Random rnd = new Random();
        for (int i = 0; i < size; i++) {
            characterArray[i] = (char) ('a' + rnd.nextInt(26));
        }
    }

    /*
     * Gets the lowest value of the array. Set min to the index 0. Check if the
     * character is less than the min. If so, make it the min.
     */
    public char getLowestValue() {
        char min = characterArray[0];

        for (char c : characterArray) {
            if (c < min) {
                min = c;
            }
        }
        return min;
    }

    /*
     * Gets the highest value of the array. Set max to the index 0. Check if the
     * character is more than the max. If so, make it the max.
     */
    public char getHighestValue() {
        char max = characterArray[0];

        for (char c : characterArray) {
            if (c > max) {
                max = c;
            }
        }
        return max;
    }

    /* Represent the array of characters as a String */
    public String toString() {
        return new String(characterArray);
    }
}
