import java.awt.Frame;
import java.awt.Panel;
import java.awt.event.*;
import java.awt.BorderLayout;


public class Main extends Frame{
    Panel p;
    public Main(){
        p = new Panel();
        this.setLayout(new BorderLayout());
        p.setLayout(new BorderLayout());
        this.add(p,BorderLayout.CENTER);
        p.add(new Mundo());
        this.setSize(500,400);
        this.setVisible(true);
    }

    public static void main(String args[]){
        new Main().addWindowListener(new WindowAdapter(){
            public void windowClosing(WindowEvent e){
                System.exit(0);
            }
        });
    }
}
