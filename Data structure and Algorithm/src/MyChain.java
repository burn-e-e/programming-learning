import java.util.Scanner;
public class MyChain extends Chain {
    public static void main(String[] args) {

        Scanner sc = new Scanner(System.in);

        MyChain chain1 = new MyChain();
        MyChain chain2 = new MyChain();
        while(true) {
            System.out.println("1. Add an element to chain 1");
            System.out.println("2. Add an element to chain 2");
            System.out.println("3. addRange elements to chain 1");
            System.out.println("4. addRange elements to chain 2");
            System.out.println("5. Union of chain 1 & chain 2");
            System.out.println("6. Intersection of chain 1 & chain 2");
            System.out.println("7. Exit");

            System.out.println("Enter your choice");

            int choice = sc.nextInt();
            switch(choice) {
                case 1:
                    String input = sc.next();
                    chain1.add(chain1.size(), input);
                    System.out.println("chain1:" +chain1+ " ");
                    break;
                case 2:
                    String input1 = sc.next();
                    chain2.add(chain2.size(), input1);
                    System.out.println("chain2:" +chain2+ " ");
                    break;
                case 3:
                    System.out.println("Enter number of integers that you want to add");
                    int size = sc.nextInt();
                    Object[] obj = new Object[size];
                    for (int i = 0; i < size; i++) {
                        System.out.println("Enter value for index " + i + ":");
                        obj[i] = sc.next();
                    }
                    chain1.addRange(obj);
                    System.out.println(chain1);
                    break;
                case 4:

                    break;
                case 5:
                    MyChain unionResult = chain1.union(chain2);
                    System.out.println("Union: " + unionResult);
                    break;
                case 6:
                    MyChain intersectionResult = chain1.intersection(chain2);
                    System.out.println("Intersection: " + intersectionResult);
                    break;
                case 7:
                    sc.close();
                    System.exit(0);
                default:
                    System.out.println("Wrong input!");
            }
        }
    }
}
