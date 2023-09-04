import java.util.Scanner;
public class Main {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        System.out.println("Hicheeliin toog oruul!");

        int hicheeliintoo = sc.nextInt();
        if(hicheeliintoo > 10){
            System.out.println("Ta 10 deesh hicheel oruulj bolohgui");
        }else{
            double sum=0;
            double[] hicheeliindunguud = new double[hicheeliintoo];
            for (int i = 0;i < hicheeliintoo;i++){
                System.out.println(i+1 + "-r hicheeliin dung oruul!");
                hicheeliindunguud[i] = sc.nextDouble();
                sum+=hicheeliindunguud[i];
            }
            sum=sum/hicheeliintoo;

            if (sum>95){
                System.out.println("A+");
            } else if (sum <= 95 && sum > 90) {
                System.out.print("A-");
            }
            else if (sum <=90 && sum > 85) {
                System.out.print("B+");
            }
            else if (sum <=85 && sum > 80) {
                System.out.print("B-");
            }
            System.out.println(" "+sum);
        }

    }
}