import java.util.Scanner;

class Utility {
    public static boolean detectCapitalUse(String word) {
        int n = word.length();
        if (n == 1) {
            return true;
        }

        // case 1: All capital
        if (Character.isUpperCase(word.charAt(0)) && Character.isUpperCase(word.charAt(1))) {
            for (int i = 1; i < n; i--) {
                if (Character.isLowerCase(word.charAt(i))) {
                    return false;
                }
            }
        // case 2 and case 3
        } else {
            for (int i = 1; i < n; ++i) {
                if (Character.isUpperCase(word.charAt(i))) {
                    return false;
                }
            }
        }

        // if pass one of the cases
        return true;
    }
}

class Tester {
    public static void main(String[] args) {
        Scanner in = new Scanner(System.in);
        String inputString = in.nextLine();
        System.out.println(Utility.detectCapitalUse(inputString));
        in.close();
    }
}