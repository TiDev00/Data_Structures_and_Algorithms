package Data_Structures;

import java.util.*;

public class basics {
    public static void main(String[] args) {

        char carac = 'a';
        boolean test = true;
        String chaine = "12345";
        String chaine2 = "test mot2";
        int numb = 1;
        long conv2 = Long.parseLong(chaine);
        float numb3 = (float)(numb);
        long grand = 5;
        String numb1 = "1";
        double conv = Double.parseDouble(numb1);
        float virgule = 1.0f;
        double virgule_big = 244.5;

        System.out.println(Character.toLowerCase('A')); // Converts 'A' to lowercase and prints 'a'
        System.out.println(Character.toUpperCase('x')); // Converts 'x' to uppercase and prints 'X'
        System.out.println(Character.isDigit('w')); // Checks if 'w' is a digit (prints 'false')
        System.out.println(Character.isLetter('2')); // Checks if '2' is a letter (prints 'false')
        System.out.println(Character.isUpperCase('q')); // Checks if 'q' is uppercase (prints 'false')
        System.out.println(Character.isLowerCase('W')); // Checks if 'W' is lowercase (prints 'false')

        System.out.println(chaine2.charAt(3)); // Retrieves the character at index 3 in 'chaine2'
        System.out.println(chaine2.length()); // Prints the length of the string 'chaine2'
        System.out.println(chaine2.toUpperCase()); // Converts 'chaine2' to uppercase
        System.out.println(chaine2.toLowerCase()); // Converts 'chaine2' to lowercase

        String[] mots = chaine2.split(" "); // Splits 'chaine2' into an array of strings using space as the delimiter
        char[] mot = chaine2.toCharArray(); // Converts 'chaine2' to a character array
        String[] letters = chaine2.split("");

        // LINEAR DATA STRUCTURES

        Integer[] nbTab = new Integer[6];
        int j = 0;
        for (int i = 15; i <= 20; i++){
            nbTab[j] = i;
            j++;
        }
        Integer[] tab3 = Arrays.copyOf(nbTab, 2);

        ArrayList<Integer> arrlist0 = new ArrayList<>(List.of(1,2,3));
        ArrayList<Integer> arrlist = new ArrayList<>(Arrays.asList(nbTab));
        arrlist.add(1);
        int t0 = arrlist.size();
        arrlist.remove(0);
        boolean c0 = arrlist.contains(2);
        int r0 = arrlist.get(2);
        arrlist.set(0, 10);
        System.out.println(arrlist.isEmpty());
        System.out.println(arrlist);

        LinkedList<Integer> ll = new LinkedList<>(Arrays.asList(nbTab));
        ll.add(45);
        int t1 = arrlist.size();
        arrlist.remove(0);
        boolean c1 = arrlist.contains(2);
        int r1 = arrlist.get(2);
        arrlist.set(0, 10);
        System.out.println(ll.getFirst());
        System.out.println(ll.getLast());
        System.out.println(ll.isEmpty());
        System.out.println(ll);

        Set<Integer> s = new HashSet<>(ll);
        ll.add(4);
        int t2 = arrlist.size();
        arrlist.remove(0);
        boolean c2 = arrlist.contains(2);
        int r2 = arrlist.get(2);
        arrlist.set(0, 10);
        System.out.println(s.isEmpty());
        System.out.println(s);

        Stack<Character> st = new Stack<>();
        st.push('a');
        st.push('b');
        st.push('c');
        System.out.println(st.peek());
        System.out.println(st.contains('a'));
        System.out.println(st.pop());
        System.out.println(st.isEmpty());
        System.out.println(st);
        st.clear();

        Queue<Integer> q = new ArrayDeque<>();
        q.add(1);
        q.add(2);
        q.add(3);
        System.out.println(q.peek());
        System.out.println(q.poll());
        System.out.println(q.contains(1));
        System.out.println(q.isEmpty());
        System.out.println(q);

        // NON LINEAR DATA STRUCTURES

        // Dictionary
        Map<Integer, String> m0 = new HashMap<>(Map.of(1,"v1",2,"v2",3,"v3"));
        Map<Integer, String> m = new HashMap<>(m0);
        m.put(50, "v50");
        m.replace(75, "Nothing");
        int t3 = m.size();
        m.remove(3);
        boolean ck = m.containsKey(2);
        boolean cv = m.containsValue("George");
        String val = m.get(50);
        System.out.println(m);

        for (int key : m.keySet()){
            int k = key;
        }

        for (String value : m.values()){
            String v = value;
        }

        for(Map.Entry<Integer, String> entry : m.entrySet()){
            Integer keys = entry.getKey();
            String values = entry.getValue();
        }
        m.clear();
    }
}
