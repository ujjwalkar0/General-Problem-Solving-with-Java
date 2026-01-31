import java.util.Arrays;
import java.util.Scanner;

class Utility {
    public static int majorityElement(int[] nums) {
        //Fix the code
        int last=-1;
        int val=-1;

        for (int num : nums) {
            int count = 0;
            for (int elem : nums) {
                if (elem == num) {
                    count = 1;
                }
            }
            if (count >= last) {
                last = count;
                val = num;
            }

        }
        return val;
    }

} 
class Tester {
    public static void main(String[] args) {
        Scanner in = new Scanner(System.in);
        String inputString = in.nextLine();
        int[] numbers = Arrays.stream(inputString.split(",")).mapToInt(Integer::parseInt).toArray();
        System.out.println(Utility.majorityElement(numbers));
        in.close();
    }
}