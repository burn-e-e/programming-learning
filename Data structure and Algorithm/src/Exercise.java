import java.util.Scanner;
import java.lang.String;
public class Exercise {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        System.out.println("Сайн байна уу? Та хичээлийн тоог оруулна уу");
        int hicheeliintoo= sc.nextInt();
        while (hicheeliintoo>12){
            System.out.println("Уучлаарай та хэтэрхий их тоо оруулсан байна");
            hicheeliintoo = sc.nextInt();
        }
        String[] hicheel =  new String[hicheeliintoo];
        int[] hicheeliin_credit = new int[hicheeliintoo];
        double[] hicheeliin_dun= new double[hicheeliintoo];
        for (int i = 0 ; i< hicheeliintoo; i++){
            System.out.println("---"+(i+1)+"р хичээлийн нэрийг оруулна уу"+"---");
            hicheel[i] = sc.next();
            System.out.println(hicheel[i]+" ийн кредитийг оруулна уу");
            hicheeliin_credit[i] = sc.nextInt();
            while (hicheeliin_credit[i]>6){
                System.out.println("Уучлаарай та хэтэрхий их тоо оруулсан байна");
                hicheeliin_credit[i]= sc.nextInt();
            }
            System.out.println(hicheeliin_credit[i]+" кредит "+hicheel[i]+" хичээлийн оноог оруулна уу");
            hicheeliin_dun[i] = sc.nextDouble();
            while (hicheeliin_dun[i]>100 || hicheeliin_dun[i]<0){
                System.out.println("Уучлаарай та буруу дүн оруулсан байна");
                hicheeliin_dun[i]= sc.nextDouble();
            }

        }
        double[] point = new double[hicheeliintoo];
        for (int i = 0 ; i< hicheeliintoo; i++){
            if (hicheeliin_dun[i]>95){
               point[i]+=4;
            } else if (hicheeliin_dun[i] <= 95 && hicheeliin_dun[i] > 90) {
                point[i]+=3.7;
            }
            else if (hicheeliin_dun[i] <=90 && hicheeliin_dun[i] > 87) {
                point[i]+=3.4;
            }
            else if (hicheeliin_dun[i] <=87 && hicheeliin_dun[i] > 83) {
                point[i]+=3.0;
            }
            else if (hicheeliin_dun[i] <= 83 && hicheeliin_dun[i] > 80) {
                point[i]+=2.7;
            }
            else if (hicheeliin_dun[i] <= 80 && hicheeliin_dun[i] > 77) {
                point[i]+=2.4;
            }
            else if (hicheeliin_dun[i] <= 77 && hicheeliin_dun[i] > 73) {
                point[i]+=2;
            }
            else if (hicheeliin_dun[i] <= 73 && hicheeliin_dun[i] > 70) {
                point[i]+=1.7;
            }
            else if (hicheeliin_dun[i] <= 70 && hicheeliin_dun[i] > 67) {
                point[i]+=1.3;
            }
            else if (hicheeliin_dun[i] <= 67 && hicheeliin_dun[i] > 63) {
                point[i]+=1.0;
            }
            else if (hicheeliin_dun[i] <= 63 && hicheeliin_dun[i] > 59) {
                point[i]+=0.7;
            }
            else if (hicheeliin_dun[i] <= 59 && hicheeliin_dun[i] > 29) {
                point[i]+=0;
            }
            else {
                point[i]+=0;
            }
        }
        double sum_point=0;
        double temp;
        double sum_credit=0;
        for (int i = 0 ; i<hicheeliintoo;i++){
            temp = point[i]*hicheeliin_credit[i];
            sum_point+=temp;
            sum_credit += hicheeliin_credit[i];
        }
        double gpa = sum_point / sum_credit;
        System.out.println("Таны үнэлгээний голч дүн: "+gpa);
    }
}