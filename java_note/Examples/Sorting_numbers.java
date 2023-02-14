package Examples;
import java.util.Scanner;
import java.util.Random;
public class Sorting_numbers 
{
    public static void main(String[] args) 
    {
    	int count, temp;
    	Random rd = new Random();
    	//User inputs the array size
        Scanner scan = new Scanner(System.in);
        System.out.print("Enter number of elements you want in the array: ");
        count = scan.nextInt();
    
        int num[] = new int[count];
        int upperbound = 25;
        System.out.println("Array elemets will be generated automatically");
        for (int i = 0; i < count; i++) 
        {
            num[i] = rd.nextInt(upperbound);
        }
        scan.close();
        for (int i = 0; i < count; i++) 
        {
            for (int j = i + 1; j < count; j++) { 
                if (num[i] > num[j]) 
                {
                    temp = num[i];
                    num[i] = num[j];
                    num[j] = temp;
                }
            }
        }
        System.out.print("Array Elements in Ascending Order: ");
        for (int i = 0; i < count - 1; i++) 
        {
            System.out.print(num[i] + ", ");
        }
        System.out.print(num[count - 1]);
    }
}
