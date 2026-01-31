import java.util.List;
import java.util.Scanner;
import java.util.stream.Collectors;
import java.util.Arrays;

class Utility {
	public static double claculateBillAmount(int N, int P) {
	    //Write your code here
	    if (N>50 && N<=100){
	        N-=10;
	    }
	    if (N>101 && N<=200){
	        N-=20;
	    }
	    if (N>=201){
	        N-=30;
	    }
	    double total = N*P;
	    
	    if (total>0 && total<=1000){
	        total = total*0.9;
        }
	    if (total>1000 && total<=10000){
	        total = total*0.85;
	    }
	    if (total>10000){
	        total = total*0.8;
	    }

		return total;
		
	}
}


class Tester {
    public static void main(String[] arr){
        Scanner s = new Scanner(System.in);
        String inputString = s.nextLine();
        List<Integer> numbers = Arrays.stream(inputString.split(","))
        .map(Integer::parseInt)
        .collect(Collectors.toList());
        double amount=Utility.claculateBillAmount(numbers.get(0),numbers.get(1));
        System.out.println(amount);
        s.close();
        
    }
}