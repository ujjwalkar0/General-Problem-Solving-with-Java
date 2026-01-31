import java.util.Scanner;

class Utility {
    public static int firstUniqueChar(String s) {
        int r=-1;
        for(int i=0;i<s.length();i++){
            for(int j=0;j<s.length();j++){
                if (s.charAt(i)==s.charAt(j)){
                    r=-1;
                }
                else{
                    r=i;
                }
            }
            if (r!=-1){
                return r;
            }
        }
        return -1;
    }

}
class Tester {
    public static void main(String[] args) {
        Scanner in = new Scanner(System.in);
        String inputString = in.nextLine();
        System.out.println(Utility.firstUniqueChar(inputString));
        in.close();
    }
}