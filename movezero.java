import java.util.Arrays;
import java.util.Scanner;

class Utility {
    public  static void moveZeroes(int[] nums) {
        int[] arr = new int[nums.length];
        int k=0,i;

        for (i=0;i<nums.length;i++){
            if (nums[i]!=0){
                arr[k]=nums[i];
                k++;
            }            
        }
        for (i=k;i<nums.length-k;i++){
            arr[k]=0;
            k++;
        }

    }
    
}

class Tester {
    public static void main(String[] args) {
        Scanner in = new Scanner(System.in);
        String inputString = in.nextLine();
        int[] numbers = Arrays.stream(inputString.split(",")).mapToInt(Integer::parseInt).toArray();
        Utility.moveZeroes(numbers);
        System.out.println(Arrays.toString(numbers));
        in.close();
    }
}