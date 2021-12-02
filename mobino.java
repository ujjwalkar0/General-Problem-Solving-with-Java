import java.util.*;

class Utility {

	public static boolean validMobile(double n) {
		boolean mobileNo = false;
		
        int m = (int)(Math.log10(n)+1);
        if (m==10){
            return true;
        }
        
		
		return mobileNo;
	}

}

class Tester {

	private static Scanner in;

	public static void main(String[] args) {
		in = new Scanner(System.in); 
		double n = in.nextDouble();
		boolean mobile = Utility.validMobile(n);
		System.out.println(mobile);
	}

}