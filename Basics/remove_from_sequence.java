import java.util.List;
import java.util.Scanner;
import java.util.stream.Collectors;
import java.util.Arrays;

class Utility {
	public static String modifyDataWithSeries(String input) {
		int maxLength=input.length();
		int x=2;
		String s="";
		//Write your code here
		for(int i=0;i<maxLength;i++){
		    if (i!=x){
		        s+=input.charAt(i);
		    }
		    else{
		        x=x*2;
		    }
		    
		}
	    return s;
	}
}
class Tester {
    public static void main(String[] arr){
    	Scanner in = new Scanner(System.in);
		String inputString = in.nextLine();
		List<String> inputData = Arrays.stream(inputString.split(",")).collect(Collectors.toList());
		String data=Utility.modifyDataWithSeries(inputData.get(0));
		System.out.println(data);
		in.close();
        
    }
}
