import java.util.*;

class Utility {

	public static String isEligible(int n) {
		if (n>=40000){
		    return "Eligible";
		}
		return "Non-Eligible";
	}

}

class Tester {

	private static Scanner in;

	public static void main(String[] args) {
		in = new Scanner(System.in); 
		int n = in.nextInt();
		String loan = Utility.isEligible(n);
		System.out.println(loan);
	}

}