import java.util.List;
import java.util.Scanner;
import java.util.stream.Collectors;
import java.util.Arrays;

class Utility {
	public static String generatePassword(String name) {
		int nameLength=name.length();
        String le=String.valueOf(nameLength);
		String password="";
        char lc=name.charAt(nameLength-1);
        char fc=name.charAt(0);
        
        if (nameLength%2==0){
            System.out.print(lc+le+"@"+fc+"654"+lc);
        }
        else{
            System.out.print(lc+le+"!"+fc+"432"+lc);
        }
         
 		return password;
		
	}
}
class Tester {
    public static void main(String[] arr){
		Scanner in = new Scanner(System.in);
		String inputString = in.nextLine();
		List<String> inputData = Arrays.stream(inputString.split(",")).collect(Collectors.toList());
		String passWord=Utility.generatePassword(inputData.get(0));
		System.out.println(passWord);
        in.close();
        
    }
}