import java.util.Arrays;
import java.util.Scanner;

class Utility {
    public static int lastStoneWeight(int[] stones) {
        int x=stones[0], y=stones[1], rem=x-y;
        if (rem <0){
            return -1*rem;
        }
        else{
            return rem;
        }
    }

}

class Tester {
    public static void main(String[] args) {
        Scanner in = new Scanner(System.in);
        String inputString = in.nextLine();
        int[] stones = Arrays.stream(inputString.split(",")).mapToInt(Integer::parseInt).toArray();
        System.out.println(Utility.lastStoneWeight(stones));
        in.close();
    }
}