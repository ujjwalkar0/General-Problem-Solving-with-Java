import java.util.List;
import java.util.Scanner;
import java.util.stream.Collectors;
import java.util.Arrays;


class Utility {
	public static String reverseString(String input) {
		//write your logic here
		String s="";
		for(int i=input.length()-1;i>=0;i--){
		    s+=input.charAt(i);
		}
         return s;
	}
}

class Tester {
    public static void main(String[] arr){
    	Scanner in = new Scanner(System.in);
		String inputString = in.nextLine();
		List<String> inputData = Arrays.stream(inputString.split(",")).collect(Collectors.toList());
		String input1=Utility.reverseString(inputData.get(0));
		System.out.println(input1);
        in.close();
        
    }
}