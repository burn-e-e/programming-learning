import javax.swing.*;
import java.awt.*;

public class Main {
     public static void main(String[] args) {
          // JFrame form = new JFrame("Java Form");
          // form.setVisible(true);

          // form.setBackground(Color.black);
          // form.add(form, form, 0);
          JFrame f = new JFrame("Button Example");
          f.setSize(400, 400);
          f.setLocation(500, 150);

          // Container contentPane = ();
          // contentPane.setBackground(Color.BLUE);
          JRadioButton r1 = new JRadioButton("Month Rate", true);
          JRadioButton r2 = new JRadioButton("Annual Rate", false);
          ButtonGroup bg = new ButtonGroup();
          bg.add(r1);
          bg.add(r2);
          f.add(r1);
          f.add(r2);
          f.setVisible(true);

          // Button/////////////////////////////
          JButton b = new JButton("Ok");
          JButton b1 = new JButton("Delete");
          // b.setBounds(50, 100, 100, 40);
          b.setLocation(50, 300);
          f.setLayout(new GridLayout(6, 2));
          f.add(b);
          f.add(b1);
          f.setVisible(true);
     }

}