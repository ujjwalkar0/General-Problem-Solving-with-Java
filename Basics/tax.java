import java.util.*;
import java.util.stream.Collectors;

class Tester{
    public static void main(String[] args){
        Scanner sc = new Scanner(System.in);
        String inputStr = sc.nextLine();
        List<Integer> num = Arrays.stream(inputStr.split(","))
                .map(Integer::parseInt)
                .collect(Collectors.toList());
        int B = num.get(0);
        int T = num.get(1);
        int H = num.get(2);
        double G = B+T+H;
        double tax;         
        /* Float gives error. Why ??
        float tax;

        main.java:18: error: incompatible types: possible lossy conversion from double to float
                    tax = 8.2/100;
                            ^
        1 error        
        
        
        */

        if (G>55000){
            tax = 0.082;
        }
        else{
            tax = 0.04;
        }
        double N = G - (G*tax);
        System.out.println(N);
        sc.close();
    }
}