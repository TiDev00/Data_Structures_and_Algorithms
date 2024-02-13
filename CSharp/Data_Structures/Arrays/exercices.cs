namespace CSharp.Data_Structures.Arrays;

public class exercices
{
    public static String ReverseString(String word)
    {
        String reversedWord = "";
        for (int i = word.Length - 1; i >= 0; i--)
        {
            reversedWord += word[i];
        }
        return reversedWord;
    }

    public static int[] MergeSortedArrays(int[] tab1, int[]tab2)
    {
        if (tab1.Length == 0) {
            return tab2;
        }
        if (tab2.Length == 0) {
            return tab1;
        }

        int[] finalArray = new int[tab1.Length + tab2.Length];
        int ptr1 = 0;
        int ptr2 = 0;
        int ptrf = 0;

        while(ptr1 < tab1.Length && ptr2 < tab2.Length){
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

        while(ptr1 < tab1.Length){
            finalArray[ptrf] = tab1[ptr1];
            ptr1++;
            ptrf++;
        }

        while(ptr2 < tab2.Length){
            finalArray[ptrf] = tab2[ptr2];
            ptr2++;
            ptrf++;
        }
        return finalArray;
    }
    
    public static void main(String[] args) {
        Console.WriteLine(ReverseString("1234"));
        
        foreach(int elt in MergeSortedArrays(new int[] { 1, 2, 3 }, new int[] { 2, 4, 4, 15, 17 })){
            Console.Write(elt + " ");
        }
    }
}