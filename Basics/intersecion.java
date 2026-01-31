import java.util.Arrays;
import java.util.Scanner;


class Utility {
    public static int[] intersection(int[] A,int[] B) {
       //Write your code here 
       int max=B.length,k=0;
       if (A.length > B.length){
           max=A.length;
       }
       int[] a = new int[max];
       
       for(int i=0;i<A.length;i++){
           for(int j=0;j<B.length;j++){
               if (A[i]==B[j]){
                   a[k]=A[i];
                   k++;
               }
           }
       }
       return Arrays.copyOfRange(a, 0, k);
    }
}

class Tester {
    public static void main(String[] args) {
        Scanner in = new Scanner(System.in);
        String inputString = in.nextLine();
        String[] firstSplit = inputString.split("#");
        String[] AStr = firstSplit[0].split(",");
        String[] BStr = firstSplit[1].split(",");
        int[] A = Arrays.stream(AStr).mapToInt(Integer::parseInt).toArray();
        int[] B = Arrays.stream(BStr).mapToInt(Integer::parseInt).toArray();
        System.out.println(Arrays.toString(Utility.intersection(A,B)));
        in.close();
    }
}