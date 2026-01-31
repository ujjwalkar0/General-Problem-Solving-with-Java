import java.util.*;
import java.util.stream.Collectors;

class Tester{
    public static void main(String args[]){
        Scanner sc = new Scanner(System.in);
        String inputStr = sc.nextLine();
        List<Integer> num = Arrays.stream(inputStr.split(","))
                .map(Integer::parseInt)
                .collect(Collectors.toList());
        int n1 = num.get(0);
        int n2 = num.get(1);
        int n3 = num.get(2);
        int max;
        if (n1>=n2 && n1>=n3){
            max = n1;
        }
        else if(n2>=n3){
            max = n2;
        }
        else{
            max = n3;
        }
        
        System.out.println(max);
        sc.close();
    }
}