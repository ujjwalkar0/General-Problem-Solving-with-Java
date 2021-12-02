import java.util.*;
import java.util.stream.Collectors;

class Tester{
    public static String swap(int a, int b){
        /*
        a = 10
        b = 20

        b = b+a = 20 + 10
        a = b - a = 30 - 10 = 20
        b = b - a = 30 - 20 = 10
        */
        b = b + a;
        a = b - a;
        b = b - a;
        String res = Integer.toString(a)+','+Integer.toString(b);
        return res;
    }
    public static void main(String args[]){
        Scanner sc = new Scanner(System.in);
        String inputStr = sc.nextLine();
        List<Integer> num = Arrays.stream(inputStr.split(","))
                .map(Integer::parseInt)
                .collect(Collectors.toList());
        int a = num.get(0);
        int b = num.get(1);

        System.out.println(swap(a, b));
        sc.close();
    }
}