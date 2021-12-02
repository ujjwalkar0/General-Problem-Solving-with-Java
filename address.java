import java.util.*;
import java.util.stream.Collectors;

class Tester{
    public static void main(String[] args){
        Scanner sc = new Scanner(System.in);
        String inputStr = sc.nextLine();
        List<String> num = Arrays.stream(inputStr.split(","))
                .collect(Collectors.toList());
        String H = num.get(0);
        String S = num.get(1);
        String C = num.get(2);
        System.out.println("House Number: "+H+"\nStreet Name: "+S+ "\nCity: "+C);
        sc.close();
    }
}