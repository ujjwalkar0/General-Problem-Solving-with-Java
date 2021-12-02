import java.util.List;
import java.util.Scanner;
import java.util.stream.Collectors;
import java.util.Arrays;

class Utility {    
	public static void checkWordForChars(String word) {
		int n=word.length();
        if (n==1){
            System.out.print(Integer.parseInt(word)*Integer.parseInt(word));
        }
		else {
		    char c=word.charAt(1);
            int i=c-48;
            if (i%4==0){
                System.out.print("24");
            }
            else if(i%2==0){
                System.out.print("2");    
            }
            else if(i%2!=0){
                System.out.print("1");    
            }
		}
	}
}


class Tester {
    public static void main(String[] arr){
		Scanner in = new Scanner(System.in);
		String inputString = in.nextLine();
		List<String> inputData = Arrays.stream(inputString.split(",")).collect(Collectors.toList());
		Utility.checkWordForChars(inputData.get(0));
        in.close();
    }
}