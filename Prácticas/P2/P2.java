
import java.awt.Frame;
import java.awt.event.*;
//Creación de la parte visual.
public class P2 extends Frame implements MouseListener, MouseMotionListener, KeyListener{
    
    private static final long serialVersionUID = 1L;
    private P2_Contenedor obP;//Objeto de la clase contenedor.
    int maxX, maxY, minX, minY;//Bordes del contendor.
    
    public P2() {
        initComponents();
        maxX=maxY=400;//Se inicia con las medidas totales de la ventana.
        minX=minY=0;
    }
    //Inicialización de los componentes.
    public void initComponents() {
        this.addWindowListener(new WindowAdapter() {
            public void windowClosing(WindowEvent e) {
                System.exit(0);
            }
        });
        obP = new P2_Contenedor();
        obP.addMouseListener(this);
        obP.addMouseMotionListener(this);
        obP.addKeyListener(this);
        this.addKeyListener(this);
        this.add(obP);
        this.setSize(450,450);
        this.setVisible(true);
    }

    public static void main(String args[]) {
        P2 p = new P2();//Main.
    }
    private void collisionChek()
    {//Si el objeto entra al area del contendor, asigna como maximo las medidas de este.
        if(obP.getX() <= 130 && obP.getY() <= 320){
            maxX=130;
            maxY=320;
        }//Hace que el objeto no pueda pasar por el maximo.
        if(obP.getX() >= maxX)
        {
            obP.setX(maxX);
        }
        if(obP.getY() >= maxY)
        {
            obP.setY(maxY);
        }//Realiza lo mismo pero con los mínimos.
        if(obP.getX() >= 10 && obP.getY() >= 100){
            minX=10;
            minY=100;
        }//Hace que el objeto no pueda salir del área.
        if(obP.getX() <= minX)
        {
            obP.setX(minX);
        }
        if(obP.getY() <= minY)
        {
            obP.setY(minY);
        }
    }
    //Si se hace clic sobre el botón, manda al objeto arrastrable a su pos original.
    @Override//Y hace que los maximos y minimos sean de toda la ventana.
    public void mouseClicked(MouseEvent arg0) {
        System.out.println("Click");
        if (obP.click()) {
            obP.setW(arg0.getX());
            obP.setH(arg0.getY());
            obP.repaint();
        } else {
            obP.setX(250);
            obP.setY(270);
            maxX=maxY=400;
            minX=minY=0;
        }
        obP.setClick();
    }

    @Override
    public void mouseEntered(MouseEvent arg0) {
        System.out.println("Inside");
    }

    @Override
    public void mouseExited(MouseEvent arg0) {
        System.out.println("Exit");
    }

    @Override
    public void mousePressed(MouseEvent arg0) {
        System.out.println("Pressed");
    }

    @Override
    public void mouseReleased(MouseEvent arg0) {
        System.out.println("Released");
    }
    //Método para arrastrar el objeto.
    @Override
    public void mouseDragged(MouseEvent arg0) {
        if(!obP.click()) {
            obP.setX(arg0.getX());
            obP.setY(arg0.getY());
            collisionChek();
            obP.repaint();
        }
        
    }

    @Override
    public void mouseMoved(MouseEvent arg0) {
        System.out.println("Move");
    }
    //Si presiona la letra "d" del teclado hace lo mismo que el botón.
    @Override
    public void keyPressed(KeyEvent arg0) {
        // TODO Auto-generated method stub
        System.out.println("Pressed" + arg0.getKeyChar());
        if (!obP.click()) {
            switch(arg0.getKeyChar()) {
                case 'd':
                case 'D':
                    obP.setX(250);
                    obP.setY(270);
                    maxX=maxY=400;
                    minX=minY=0;
            }//Manda al objeto a su posición original y pone max y min toda la ventana.
            obP.repaint();
        }
    }

    @Override
    public void keyReleased(KeyEvent arg0) {
        // TODO Auto-generated method stub
        System.out.println("Released" + arg0.getKeyChar());
    }

    @Override
    public void keyTyped(KeyEvent arg0) {
        // TODO Auto-generated method stub
        System.out.println("t: " + arg0.getKeyChar());
    }
}
