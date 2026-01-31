import java.util.*;
import java.util.stream.Collectors;

class Tester{
    public static void main(String[] args){
        Scanner sc = new Scanner(System.in);
        String inputStr = sc.nextLine();
        List<Integer> num = Arrays.stream(inputStr.split(","))
                .map(Integer::parseInt)
                .collect(Collectors.toList());
        int n1 = num.get(0);
        int n2 = num.get(1);
        int sum = n1+n2;
        int diff = n1-n2;
        int pdt = n1*n2;
        int qtn = n1/n2;
        System.out.print(sum+" "+diff+" "+pdt+" "+" "+qtn);
        sc.close();
    }
}