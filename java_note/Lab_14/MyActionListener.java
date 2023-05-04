package Lab_14;
import java.awt.event.ActionListener;
import javax.swing.JButton;
import javax.swing.JFrame;
import java.awt.event.ActionEvent;

class MyActionListener implements ActionListener {
     public void actionPerformed(ActionEvent e) {
          System.out.println("Command: " + e.getActionCommand());
          Object source = e.getSource();
          if (source instanceof JButton) {
               JButton jb = (JButton) source;
               System.out.println("JButton: " + jb.getText());
          }
     }
}
