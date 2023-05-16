import javax.swing.*;
import java.awt.*;

public class Main {
    public static void main(String[] args) {
        MyFrame frame = new MyFrame();
        JLabel label = new JLabel();
        label.setText("Bro, do you even code?");
        ImageIcon image = new ImageIcon("icon.png");
        frame.add(label);
        label.setIcon(image);
        label.setHorizontalTextPosition(JLabel.CENTER);
        label.setVerticalTextPosition(JLabel.TOP);
        label.setBounds(0,0,250,250);

    }
}