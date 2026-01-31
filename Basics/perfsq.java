import java.util.Scanner;
import java.lang.Math;

class Utility {
    public static int numSquares(int n) {

        //Write the code here

        int r=(int)Math.log(n);
        return r;
    }

}

class Tester {
    public static void main(String[] args) {
        Scanner in = new Scanner(System.in);
        int inputN = in.nextInt();
        System.out.println(Utility.numSquares(inputN));
        in.close();
    }
}