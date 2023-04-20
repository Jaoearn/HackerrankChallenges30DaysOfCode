package day;
import java.util.*;

public class day1 {
	 public static void main(String[] args) {
	        int i = 4;
	        double d = 4.0;
	        String s = "HackerRank ";
	      
	        Scanner scan = new Scanner(System.in);
	        int value1 = scan.nextInt();
	        double value2 = scan.nextDouble();
	        scan.nextLine();
	        String value3 = scan.nextLine();
	       
	        System.out.println(i + value1);
	        System.out.println(d + value2);
	        System.out.println(s + value3);
	        
	        scan.close();
	    }
}
