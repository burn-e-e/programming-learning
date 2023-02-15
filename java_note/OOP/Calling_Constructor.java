package OOP;
class Date {

     private int day;
     private int month;
     private int year;
     private String event;
   
   
     public Date() {
       this.day = 0;
       this.month = 0;
       this.year = 0;
       this.event = "No event";
     }
   
     public Date(int d, int m, int y){
       this.day = d;
       this.month = m;
       this.year = y;
     }
     
     public Date(int day, int month, int year, String event){
       this(day, month, year);
       this.event = event;
     }
   

     public void printDate(){ 
       System.out.println("Date: " + day + "/" + month + "/" + year + "  --> " + event);
     }
     
   }
   
   class Calling_Constructor {
     
     public static void main(String args[]) {
       Date date = new Date(13, 2, 2019); 
       date.printDate();
     }
     
   }