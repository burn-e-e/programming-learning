package Lab_9_2;
public class JavaBook extends SoftwareBook{
     private String author;
     void set(String n, int p1, int p2, String v, String a){
          set(n,p1,p2,v);
          author = a;
     }
     protected void show(){
          super.show();
          System.out.println(author);
     }
}
