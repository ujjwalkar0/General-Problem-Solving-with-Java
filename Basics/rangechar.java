
import java.util.List;
import java.util.Scanner;
import java.util.stream.Collectors;
import java.util.Arrays;

class Utility {
	public static String getSubString(String word,int firstIndex, int lastIndex) {
		//write your code here
		String s="";
		while (firstIndex<lastIndex && lastIndex<word.length()){
		    s+=word.charAt(firstIndex);
		    firstIndex++;
		}
		return s;
	}
}

class Tester {
    public static void main(String[] arr){
		Scanner in = new Scanner(System.in);
		String inputString = in.nextLine();
		List<String> inputData = Arrays.stream(inputString.split(",")).collect(Collectors.toList());
		String output=Utility.getSubString(inputData.get(0), Integer.parseInt(inputData.get(1)), Integer.parseInt(inputData.get(2)));
		System.out.println(output);
        in.close();
    }
}