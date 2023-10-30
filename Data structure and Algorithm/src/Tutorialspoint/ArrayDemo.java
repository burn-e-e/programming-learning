package Tutorialspoint;
public class ArrayDemo {
    public static void main(String[] args){

        // Declare an array
        int intArray[];

        // Initialize an array of 8 int
        // set aside memory of 8 int
        intArray = new int[8];

        System.out.println("Array before adding data.");

        // Display elements of an array.
        display(intArray);

        // Operation : Insertion
        // Add elements in the array
        for(int i = 0; i< intArray.length; i++)
        {
            // place value of i at index i.
            System.out.println("Adding "+i+" at index "+i);
            intArray[i] = i;
        }
        System.out.println();

        System.out.println("Array after adding data.");
        display(intArray);

        // Operation : Insertion
        // Element at any location can be updated directly
        int index = 5;
        intArray[index] = 10;

        System.out.println("Array after updating element at index " + index);
        display(intArray);

        // Operation : Search using index
        // Search an element using index.
        System.out.println("Data at index " + index + ": "+ intArray[index]);

        // Operation : Search using value
        // Search an element using value.
        int value = 4;
        for(int i = 0; i< intArray.length; i++)
        {
            if(intArray[i] == value ){
                System.out.println(value + " Found at index "+i);
                break;
            }
        }
        System.out.println("Data at index " + index + ": "+ intArray[index]);
    }

    private static void display(int[] intArray){
        System.out.print("Array : [");
        for(int i = 0; i< intArray.length; i++)
        {
            // display value of element at index i.
            System.out.print(" "+intArray[i]);
        }
        System.out.println(" ]");
        System.out.println();
    }
}