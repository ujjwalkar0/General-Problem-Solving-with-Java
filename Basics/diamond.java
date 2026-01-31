class Utility {
	public static void displayPattern() {
		
		//Write your code here'
		for (int i=1;i<=5;i++){
		    for(int j=0;j<i;j++){
		        System.out.print('*');
		    }
		    System.out.println();
		}
		
	
		
	}
}
class Tester {
    public static void main(String[] arr){
    	
		Utility.displayPattern();
		
        
    }
}
