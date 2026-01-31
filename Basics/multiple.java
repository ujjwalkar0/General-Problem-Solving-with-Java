import java.util.*;
import java.util.stream.Collectors;

class Tester{
    public static void main(String[] args){
        Scanner in = new Scanner(System.in);
        String inputStr = in.nextLine();
        List<Integer> arr = Arrays.stream(inputStr.split(","))
            .map(Integer::parseInt)
            .collect(Collectors.toList());
        
        int M = arr.get(0);
        int N = arr.get(1);

        if (N%M == 0){
            System.out.print("Is a multiple\n");
        }

        in.close();
    }
}