import java.util.List;
import java.util.Scanner;
import java.util.stream.Collectors;
import java.util.Arrays;

class Utility {
	public static String generateSeries(int x,int y, int l,int u)
	{
        int i;
        int a =(x > y)? x : y;  
        
        for(i = a ; i <= x*y ; i = i + a)  
        {  
        //returns true if both conditions are true  
        if(i % x == 0 && i % y == 0)  
            break;  
        }
        while (l<u){
            System.out.print(l);
            l+=i;
            if(l<u)
                System.out.print(",");
        }
        return null;
	}
}
class Tester {
    public static void main(String[] arr){
        Scanner s = new Scanner(System.in);
        String inputString = s.nextLine();
        List<Integer> numbers = Arrays.stream(inputString.split(","))
        .map(Integer::parseInt)
        .collect(Collectors.toList());
        // String series=
        Utility.generateSeries(numbers.get(0),numbers.get(1),numbers.get(2),numbers.get(3));
        s.close();
        // System.out.println(series);
        
    }
}