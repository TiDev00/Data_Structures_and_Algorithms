package Data_Structures.Hashtables;

import java.util.HashMap;
import java.util.Map;

public class exercices {
    static int firstRecurringCharacter(int[] tab){
        Map<Integer, Integer> myMap = new HashMap<>();
        int index = 0;
        for(int val : tab){
            if(myMap.containsKey(val)){
                return val;
            }
            myMap.put(val, index);
            index++;
        }
        return -1;
    }

    public static void main(String[] args) {
        System.out.println(firstRecurringCharacter(new int[]{1,2,3,5}));
    }
}
