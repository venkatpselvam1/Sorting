package PatientSort;

import Utils.Utils;

import java.util.LinkedList;

public class App {
    public static void main(String args[])
    {
        int[] arr = new int[]{ 12, 14, 1, 6, 21, 19,91, 1, 31, 27, 63, 24};
        Utils.printArr(arr);
        PatientSort patientSort = new PatientSort();
        int[] ans = patientSort.sort(arr);
        Utils.printArr(ans);
    }

    public static class PatientSort
    {
        public int[] sort(int[] arr)
        {
            int len = arr.length;
            int[] ans = new int[len];
            //make the piles
            LinkedList<LinkedList<Integer>> piles = new LinkedList<>();
            for(int item: arr)
            {
                boolean found = false;
                if(!piles.isEmpty())
                {
                    for(LinkedList<Integer> pile: piles)
                    {
                        if(pile.peekLast() >= item)
                        {
                            pile.add(item);
                            found = true;
                            break;
                        }
                    }
                }
                if(!found)
                {
                    LinkedList<Integer> temp =new LinkedList<>();
                    temp.add(item);
                    piles.add(temp);
                }
            }

            //remove from pile
            for(int j = 0; j < len; j++)
            {
                int minInd = 0;
                int minVal = piles.get(0).peekLast();
                for(int i = 1; i < piles.size(); i++)
                {
                    int newVal= piles.get(i).peekLast();
                    if(newVal <  minVal)
                    {
                        minVal = newVal;
                        minInd = i;
                    }
                }
                piles.get(minInd).removeLast();
                if(piles.get(minInd).isEmpty())
                {
                    piles.remove(minInd);
                }
                ans[j] = minVal;
            }
            return ans;
        }
    }
}
