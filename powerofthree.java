import java.util.Scanner;

class Utility {
    public static boolean isPowerOfThree(int n) {
        //Write your logic here

        int i=0,j=(int) n/3+1;

        while (i<j){
            if (i*3==n){
                return true;
            }
            i++;
        }
        return false;
    }

}

class Tester {
    public static void main(String[] args) {
        Scanner in = new Scanner(System.in);
        int inputN = in.nextInt();
        System.out.println(Utility.isPowerOfThree(inputN));
        in.close();
    }
}