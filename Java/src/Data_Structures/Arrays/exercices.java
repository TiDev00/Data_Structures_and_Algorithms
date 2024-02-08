package Data_Structures.Arrays;

public class exercices {

    public static String reverseString(String word){
        String reversedWord = "";
        for(int i = word.length() - 1; i >= 0; i--){
            reversedWord += word.charAt(i);
        }
        return reversedWord;
    }

    public static int[] mergeSortedArrays(int[] tab1, int[]tab2){

        if (tab1.length == 0) {
            return tab2;
        }
        if (tab2.length == 0) {
            return tab1;
        }

        int[] finalArray = new int[tab1.length + tab2.length];
        int ptr1 = 0;
        int ptr2 = 0;
        int ptrf = 0;

        while(ptr1 < tab1.length && ptr2 < tab2.length){
            if(tab1[ptr1] < tab2[ptr2]){
                finalArray[ptrf] = tab1[ptr1];
                ptr1++;
            }
            else {
                finalArray[ptrf] = tab2[ptr2];
                ptr2++;
            }
            ptrf++;
        }

        while(ptr1 < tab1.length){
            finalArray[ptrf] = tab1[ptr1];
            ptr1++;
            ptrf++;
        }

        while(ptr2 < tab2.length){
            finalArray[ptrf] = tab2[ptr2];
            ptr2++;
            ptrf++;
        }

        return finalArray;
    }

    public static void main(String[] args) {
        System.out.println(reverseString("1234"));

        for(int elt : mergeSortedArrays(new int[]{1,2,3}, new int[]{2,4,4,15,17})){
            System.out.print(elt + " ");
        }
    }
}
