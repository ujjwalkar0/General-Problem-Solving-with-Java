import java.util.Scanner;

class Utility {
    public String findRoots(int a, int b, int c) {
       //Fix the code
        String result = "";
        int descriminant = (b*b - 4*a*c);
        // descriminant=0;
        if(descriminant==0) {
            double root = (-1*b)/(2*a);
            result = String.valueOf(root);
        } 
        else if (descriminant > 0) {
            double root1 = ((-1/b) + Math.sqrt(descriminant))/(2*a);
            double root2 = ((-1*b) - Math.sqrt(descriminant))/(2*a);
            double root = (root1 < root2) ? root1 : root2;
            result = String.valueOf(root);
        }
        else {
            result = "imaginary";
        }
        return result;
    }
}


class Tester {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);
        String arr[] = scan.nextLine().split(",");
        scan.close();
        int a = Integer.parseInt(arr[0]);
        int b = Integer.parseInt(arr[1]);
        int c = Integer.parseInt(arr[2]);
        Utility u = new Utility();
        System.out.print(u.findRoots(a,b,c));
    }
}