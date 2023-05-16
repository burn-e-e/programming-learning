import javax.swing.*;
import java.awt.*;

public class MyFrame extends JFrame {
    MyFrame(){
        int size = 500;
        this.setTitle("Java GUI");
        this.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        this.setResizable(true);
        this.setSize(size,size);
        this.setVisible(true);
        ImageIcon icon = new ImageIcon("icon.png");
        this.setIconImage(icon.getImage());
        this.getContentPane().setBackground(Color.LIGHT_GRAY);
    }
}
