import java.awt.*;
import java.awt.event.*;
class Event extends Frame implements ActionListener{
    TextField tf;
    Event(){

//create components  
        tf=new TextField();
        tf.setBounds(60,50,170,20);
        Button b=new Button("click me");
        Button b1 = new Button("DONT CLICK ME");
        b1.setBounds(100,160,100,30);
        b.setBounds(100,120,80,30);

//register listener



        b.addActionListener(this);//passing current instance
        b1.addActionListener(new ActionListener() {
            @Override
            public void actionPerformed(ActionEvent e) {
                tf.setText("ZAIL");
            }
        });


//add components and set size, layout and visibility  
        add(b);
        add(b1);
        add(tf);
        setSize(300,300);
        setLayout(null);
        setVisible(true);
    }
    public void actionPerformed(ActionEvent e){
        tf.setText("Die");
    }

    //MAIN STARTS FROM HERE!
    public static void main(String args[]){
        new Event();
    }
}  