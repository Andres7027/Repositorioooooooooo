
import java.awt.*;
//Canvas que permite el dibujo de figuras.
public class P2_Contenedor extends Canvas{
    /**
     *
     */
    private static final long serialVersionUID = 1L;
    private int x, y;//Servirán para poder arrstrar el objeto.
    private int w, h;
    private boolean click;

    public P2_Contenedor() {
        x = 250;//Datos donde se dibuja el objeto arrastrable.
        y = 270;
        w = 300;
        h = 220;
        click = false;
    }
    //Método para pintar las figuras.
    public void paint(Graphics gr) {
        //Cuadrado
        gr.setColor(Color.RED);
        gr.fillRect(10, 100, 200, 300);
        gr.setColor(Color.gray);
        gr.drawRect(10,100,200,300);
        //Rombo
        gr.setColor(Color.white);
        gr.drawRect(220, 100, 200, 300);
        gr.setColor(Color.BLACK);
        gr.drawRect(220, 100, 200, 300);
        //Círculo 1
        gr.setColor(Color.GRAY);
        gr.drawArc(200, 0, 80, 80,0,360);
        gr.setColor(Color.green);
        gr.fillArc(200, 0, 80, 80,0,360);
        //Objeto arrastrable
        gr.setColor(Color.GRAY);
        gr.drawArc(x, y, 80, 80,0,360);
        gr.setColor(Color.black);
        gr.fillArc(x, y, 80, 80,0,360);
        //Texto
        gr.drawString("Figura\n",224,44);
    }
    //Métodos para definir y retornar la posición del objeto arrastrable.
    public int getX() {
        return x;
    }

    public void setX(int x) {
        this.x = x;
    }

    public int getY() {
        return y;
    }

    public void setY(int y) {
        this.y = y;
    }

    public int getW() {
        return w;
    }

    public void setW(int w) {
        this.w = w;
    }

    public int getH() {
        return h;
    }

    public void setH(int h) {
        this.h = h;
    }
    //Determina la el click sobre la figura.
    public boolean click() {
        return click;
    }

    public void setClick() {
        this.click = !this.click;
    }
}
