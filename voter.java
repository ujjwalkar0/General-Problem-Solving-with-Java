import java.util.*;


class Utility {

	public static String eligibleVoter(int a) {
		if (a>=18){
            return "Eligible";
        }
		return "Non-Eligible";
	}

}

class Tester {

	private static Scanner in;

	public static void main(String[] args) {
		in = new Scanner(System.in); 
		int a = in.nextInt();
		String voter = Utility.eligibleVoter(a);
		System.out.println(voter);
	}
}