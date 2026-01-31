import java.util.List;
import java.util.Scanner;
import java.util.stream.Collectors;
import java.util.Arrays;

class Utility {    
	public static String checkWordForChars(String word) {
		int n=word.length();
		if (n>=3){
		    char c=word.charAt(1);
            if ((c=='a') || (c=='e') || (c=='i') || (c=='o') || (c=='u')){
                System.out.println("vowel");
            }
            else if((c >= 'a' && c <= 'z') || (c >= 'A' && c <= 'Z')){
                System.out.println("consonant");
            }
            else if(c >= '0' && c <= '9') {
                System.out.println("digit");
            }
            else{
                System.out.println("other");
            }
    
		    
		   
		}
		else{
		    System.out.print("Invalid");
		}
	     return null;	
	}
}


class Tester {
    public static void main(String[] arr){
		Scanner in = new Scanner(System.in);
		String inputString = in.nextLine();
		List<String> inputData = Arrays.stream(inputString.split(",")).collect(Collectors.toList());
		String output=Utility.checkWordForChars(inputData.get(0));
		System.out.println(output);
        in.close();
    }
}