import java.io.File;
import java.io.DataOutputStream;
import java.io.FileNotFoundException;
import java.io.*;
import java.io.ObjectOutputStream;
import java.util.Scanner;
public class Main {
    private static final String filepath="C:\\Users\\4burn\\Desktop";
    public static void main(String[] args) throws FileNotFoundException,IOException, ClassNotFoundException{
      Teacher t = new Teacher("Bold", 29,"Male",3000000.0);

        Person[] s =new Person[2];
        s[0] = new Person("Burnee", 19,"Male");
        s[1] = new Person("Burnee", 19,"Male");
        Person t;
      /*File fname = new File("a123.dat");
      FileInputStream fStream =new FileInputStream(fname);
      ObjectInputStream file=new ObjectInputStream(fStream);

        for(int i=0;i<s.length;i++){
            s[i]=(Person)file.readObject();
        }
        for(int j=0;j<s.length;j++){
            s[j].show();
        }
        file.close();

       */
        File file = new File("text.txt"); //initialize File object and passing path as argument
        boolean result = true;
        FileOutputStream fileOut = new FileOutputStream(file);
        ObjectOutputStream objectOut = new ObjectOutputStream(fileOut);
        objectOut.writeObject(s[0]);
        objectOut.close();
        try
        {
            result = file.createNewFile();  //creates a new file
            if(result)
            {
                System.out.println("file created "+file.getCanonicalPath());

            }
            else
            {
                System.out.println("File already exist at location: "+file.getCanonicalPath());
            }
        }
        catch (IOException e)
        {
            e.printStackTrace();
        }
    }
}