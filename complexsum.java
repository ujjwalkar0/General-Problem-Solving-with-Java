import java.util.*;
import java.util.stream.Collectors;

class Tester{
    public static void main(String args[]){
        Scanner sc = new Scanner(System.in);
        String inputStr = sc.nextLine();
        List<Float> num = Arrays.stream(inputStr.split(","))
        .map(Float::parseFloat)
        .collect(Collectors.toList());
        float r1 = num.get(0);
        float r2 = num.get(2);
        float i1 = num.get(1);
        float i2 = num.get(3);
        String real = Float.toString(r1+r2);
        String img = Float.toString(i1+i2);

        System.out.println(real+'+'+img+'i');
        sc.close();
    }
}