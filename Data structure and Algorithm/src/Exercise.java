import java.util.Scanner;
import java.lang.String;
public class Exercise {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        System.out.println("Hicheeliin toog oruul!");
        int hicheeliintoo = sc.nextInt();
        String[] hicheel =  new String[hicheeliintoo];
        int[] hicheeliin_credit = new int[hicheeliintoo];
        double[] hicheeliin_dun= new double[hicheeliintoo];
        for (int i = 0 ; i< hicheeliintoo; i++){
            System.out.println(i+1+" hicheeliin ner bolon dun, credit oruulna uu");
            hicheel[i] = sc.nextLine();
            hicheeliin_dun[i] = sc.nextDouble();
            hicheeliin_credit[i] = sc.nextInt();
        }
        double[] point = new double[hicheeliintoo];
        int[] hour = new int[hicheeliintoo];
        for (int i = 0 ; i< hicheeliintoo; i++){
            if (hicheeliin_dun[i]>95){
               point[i]+=4;
            } else if (hicheeliin_dun[i] <= 95 && hicheeliin_dun[i] > 90) {
                point[i]+=3.75;
            }
            else if (hicheeliin_dun[i] <=90 && hicheeliin_dun[i] > 85) {
                point[i]+=3.5;
            }
            else if (hicheeliin_dun[i] <=85 && hicheeliin_dun[i] > 80) {
                point[i]+=3.25;
            }
            else if (hicheeliin_dun[i] <= 80 && hicheeliin_dun[i] > 75) {
                point[i]+=3;
            }
            else if (hicheeliin_dun[i] <= 75 && hicheeliin_dun[i] > 70) {
                point[i]+=2.75;
            }
            else if (hicheeliin_dun[i] <= 70 && hicheeliin_dun[i] > 65) {
                point[i]+=2.5;
            }
            else if (hicheeliin_dun[i] <= 65 && hicheeliin_dun[i] > 60) {
                point[i]+=2;
            }
            else {
                point[i]+=0;
            }

        }
        for (int i = 0 ; i< hicheeliintoo; i++){
            if(hicheeliin_credit[i]==3){
                point[i]=point[i]*3;
            }else if (hicheeliin_credit[i]==2){
                point[i]=point[i]*2;
            } else if (hicheeliin_credit[i]==1) {
                point[i]=point[i]*3;
            }
        }
    }
}