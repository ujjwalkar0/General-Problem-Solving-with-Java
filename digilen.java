import java.util.*;

class Tester{
    public static void main(String args[]){
        Scanner sc = new Scanner(System.in);
        int n = sc.nextInt();
        int m = (int)(Math.log10(n)+1);

        System.out.println(m);
        sc.close();
    }
}