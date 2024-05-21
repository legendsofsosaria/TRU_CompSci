import java.util.Random;

/**
 * Elizabeth Gress
 * 11/06/2023
 * 
 * Design and implement a recursive program that uses Euclid’s algorithm to
 * determine the greatest common divisor of two positive integers.
 * A greatest common divisor is the largest integer that divides both numbers
 * without a remainder. For example: for 40 and 24, both 2 and 4 are
 * common divisors, but 8 is the greatest common divisor; for 40 and 10 both 2
 * and 5 are common divisors, but 10 is the greatest common divisor;
 * for 17 and 51 the only common divisor is 17, hence it is the greatest.
 * 
 * Reproduce the three examples given above. Generate 30 sets of random integers
 * between 1 and 100, outputting them and their gcd.
 */
public class GCDCalc {
    /*
     * Use Euclid's algorithm to determine greatest common divisor of two positive
     * integers. Use given algorithms to determine the GCD of two numbers
     */
    public static int gcd(int m, int n) {
        if (n == 0) {
            return m;
        } else {
            return gcd(n, m % n);
        }
    }

    public static void main(String[] args) {
        int[][] numbers = { { 40, 24 }, { 40, 10 }, { 17, 51 } };

        /* Get GCD of the list of numbers in given 2 dimensional array */
        for (int i = 0; i < numbers.length; i++) {
            int m = numbers[i][0];
            int n = numbers[i][1];

            System.out.println("GCD of " + m + " and " + n + " is: " + gcd(m, n));
        }

        System.out.println("\n30 sets of random integers and their GCDs:");

        /*
         * Generate 30 random integers between 1 and 100 and get their GCD. Output
         * numbers
         */
        Random random = new Random();
        for (int i = 0; i < 30; i++) {
            int rand1 = random.nextInt(100) + 1;
            int rand2 = random.nextInt(100) + 1;

            System.out.println("Random integers: " + rand1 + " and " + rand2 + " their GCD: " + gcd(rand1, rand2));
        }
    }
}
