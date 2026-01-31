import java.util.Scanner;

class Utility {
    public static boolean checkRecord(String s) {
        int a=0,l=-1,i=0,n=s.length();
        while(n>0){
            if (s.charAt(i)=='A'){
                a++;
            }
            else{
                if (s.charAt(i)=='L'){
                    l++;
                    if (s.charAt(i)=='L'){
                        l--;
                        return false;
                    }
                }
            }
            if (a>1){
                return false;
            }
            i++;
        }
        return false;
    }
}

class Tester {
    public static void main(String[] args) {
        Scanner in = new Scanner(System.in);
        String inputString = in.nextLine();
        System.out.println(Utility.checkRecord(inputString));
        in.close();
    }
}