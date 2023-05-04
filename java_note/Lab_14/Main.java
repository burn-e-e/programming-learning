package Lab_14;

import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import javax.swing.JButton;
import javax.swing.JFrame;
// import java.lang.ClassNotFoundException;

public class Main {
     public static void main(String[] args) {
          JFrame frame = new JFrame();
          JButton button = new JButton("Click");
          button.addActionListener(new MyActionListener());
          frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
          frame.add(button);
          frame.pack();
          frame.setVisible(true);
     }
}
