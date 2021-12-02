import java.util.Scanner;

class Utility {
    public static String reverseOnlyLetters(String S) {
        //Fix the code
        int j = S.length();
        for (int i = 0; i < S.length()-1; i++) {
            if (Character.isLetter(S.charAt(i))) {
                char temp=S.charAt(j-i-1);
                S.charAt(j-i-1);
                
            }

    }
    return "null";

    }
}
class Tester {
    public static void main(String[] args) {
        Scanner in = new Scanner(System.in);
        String inputString = in.nextLine();
        System.out.println(Utility.reverseOnlyLetters(inputString));
        in.close();
    }
}