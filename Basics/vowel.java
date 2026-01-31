import java.util.Scanner;

class Tester {

	public static void main(String[] args) {
		Scanner in = new Scanner(System.in);
		System.out.println("Enter an alphabet:  ");
		char c= in.next().charAt(0);	
		String alphabet = "NOT a vowel";
        if (c=='a' || c=='e' || c=='i' || c=='o' || c=='u'){
            alphabet = "Vowel";
        }
		System.out.println(alphabet);
        in.close();
	}

}