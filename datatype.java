import java.util.*;
import java.util.stream.Collectors;

class Tester{
    public static void main(String[] args){
        Scanner sc = new Scanner(System.in);
        String inputStr = sc.nextLine();
        List<String> arr = Arrays.stream(inputStr.split(","))
                .collect(Collectors.toList());
        String name = arr.get(0);
        Long number = Long.parseLong(arr.get(1));
        String address = arr.get(2);
        int items = Integer.parseInt(arr.get(3));
        float cost = Float.parseFloat(arr.get(4));

        System.out.println("Name :  "+name+  ", Mobile :  "+number+ ", Address :  "+address+ ", Items :  "+items+ ", Bill Amount :  $"+(items*cost));		

        sc.close();
    }
}