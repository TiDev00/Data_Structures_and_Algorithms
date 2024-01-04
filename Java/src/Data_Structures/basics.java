package Data_Structures;

import java.util.*;

public class basics {
    public static void main(String[] args) {

        char carac = 'a';
        boolean test = true;
        String chaine = "12345";
        String chaine2 = "test mot2";
        int numb = 1;
        // Utlisation de la conversion explicite si conversion entre type numeric et parsing pour les string
        long conv2 = Long.parseLong(chaine);
        float numb3 = (float)(numb);
        long grand = 5;
        String numb1 = "1";
        double conv = Double.parseDouble(numb1);
        float virgule = 1.0f;
        double virgule_big = 244.5;

        // char and String methods
        System.out.println(Character.toLowerCase('A')); // Converts 'A' to lowercase and prints 'a'
        System.out.println(Character.toUpperCase('x')); // Converts 'x' to uppercase and prints 'X'
        System.out.println(Character.isDigit('w')); // Checks if 'w' is a digit (prints 'false')
        System.out.println(Character.isLetter('2')); // Checks if '2' is a letter (prints 'false')
        System.out.println(Character.isUpperCase('q')); // Checks if 'q' is uppercase (prints 'false')
        System.out.println(Character.isLowerCase('W')); // Checks if 'W' is lowercase (prints 'false')

        System.out.println(chaine2.length()); // Prints the length of the string 'chaine2'
        System.out.println(chaine2.contains("u")); // Checks if 'chaine2' contains 'u' (prints 'true' or 'false')
        System.out.println(chaine2.endsWith("a")); // Checks if 'chaine2' ends with 'a' (prints 'true' or 'false')
        System.out.println(chaine2.startsWith("b")); // Checks if 'chaine2' starts with 'b' (prints 'true' or 'false')
        System.out.println(chaine2.substring(1, 3)); // Retrieves a substring from index 1 to index 2 (prints characters at indices 1 and 2)
        System.out.println(chaine2.toUpperCase()); // Converts 'chaine2' to uppercase
        System.out.println(chaine2.toLowerCase()); // Converts 'chaine2' to lowercase
        System.out.println(chaine2.charAt(3)); // Retrieves the character at index 3 in 'chaine2'
        System.out.println(chaine2.indexOf('s')); // Finds the index of 's' in 'chaine2' (prints the index or -1 if not found)
        System.out.println(chaine2.lastIndexOf('t')); // Finds the last index of 't' in 'chaine2'
        System.out.println(chaine2.replace('t', 'A')); // Replaces all occurrences of 't' with 'A' in 'chaine2'

        String[] mots = chaine2.split(" "); // Splits 'chaine2' into an array of strings using space as the delimiter
        System.out.println(chaine2.isEmpty()); // Checks if 'chaine2' is empty (prints 'true' or 'false')
        System.out.println(chaine2.isBlank()); // Checks if 'chaine2' is blank (contains only white spaces) (prints 'true' or 'false')

        char[] mot = chaine2.toCharArray(); // Converts 'chaine2' to a character array


        // ARRAY

        int[] tab = new int[3];
        char[] tab2 = {'1', '3', '2'};
        System.out.println(tab2);

        for(int entier : tab)
        {
            System.out.println(entier);
        }

        System.out.println();

        for(int index = 0; index < tab2.length; index++)
        {
            System.out.println(tab2[index]);
        }

        System.out.println();

        // Methodes speciales array

        Arrays.sort(tab2);
        System.out.println(tab2);
        char[] tab3 = Arrays.copyOf(tab2, 2);

        // LIST

        ArrayList<Character> maliste = new ArrayList<>();
        System.out.println(maliste);

        ArrayList<Integer> ml = new ArrayList<>();
        ml.add(7);
        ml.add(1);
        ml.add(5);
        for(int entier : ml)
        {
            System.out.println(entier);
        }

        // Methodes speciales list

        ml.sort(null);
        for(int var : ml)
        {
            System.out.println(var);
        }

        System.out.println(ml.contains(3));
        System.out.println(ml.size());
        System.out.println(ml.indexOf(1));
        ml.add(0, 9);
        ml.remove(1);
        System.out.println();
        for(int var : ml)
        {
            System.out.println(var);
        }
        ml.clear();
    }
}
