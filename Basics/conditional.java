import java.util.*;
import java.util.stream.Collectors;

class Tester{
    public static void main(String args[]){
        Scanner sc = new Scanner(System.in);
        String inputStr = sc.nextLine();
        List<Integer> num = Arrays.stream(inputStr.split(","))
                .map(Integer::parseInt)
                .collect(Collectors.toList());
        int B = num.get(0);
        int T = num.get(1);
        int H = num.get(2);
        int G = B+T+H;
        float N;
        
        if (G > 55000){
            N = G-(G*8.2f/100.0f);
        }
        else{
            N = G;
        }
        System.out.println(N);
        sc.close();
    }
}