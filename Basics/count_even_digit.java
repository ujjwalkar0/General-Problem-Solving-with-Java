import java.util.List;
import java.util.Scanner;
import java.util.stream.Collectors;
import java.util.Arrays;
class Utility {
	public static void generateEvenNumberFromString(String input) {
	   //write your code here
	   int flag=0;
	   for(int i=0;i<input.length();i++){
	       int n=input.charAt(i);
	       int c=input.charAt(i);
	       if (n%2==0 && n>48 && n<56){
	           System.out.print(c);
	           flag=1;
	       }
	   }
	   if (flag==0){
	      System.out.print(-1);
	   }
	}
}
class Tester {
    public static void main(String[] arr){
    	Scanner in = new Scanner(System.in);
		String inputString = in.nextLine();
		List<String> inputData = Arrays.stream(inputString.split(",")).collect(Collectors.toList());
// 		int num=
        Utility.generateEvenNumberFromString(inputData.get(0));
// 		System.out.println(num);
        in.close();        
    }
}