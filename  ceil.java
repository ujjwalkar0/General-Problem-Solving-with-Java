import java.util.*;

class Tester{
    public static void main(String[] args) {
        Scanner in = new Scanner(System.in);
        double num = in.nextDouble();
        long ceilnum = 0;

        if ((num - (int)num)>0){
            ceilnum = (int)num +1;
        }
        else{
            ceilnum = (int)num;
        }

        System.out.println(ceilnum);
        in.close();

    }        
}
