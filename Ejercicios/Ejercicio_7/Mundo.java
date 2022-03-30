import java.awt.Canvas;
import java.awt.Color;
import java.awt.Graphics;

public class Mundo extends Canvas{
    int x, y;
    int w, h;

    public Mundo(){
        x = 20;
        y = 28;
        w = h = 100;
    }
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
    public void paint(Graphics g){
        g.setColor(Color.BLACK);
        g.drawRect(x, y, w, h);
        g.fillOval(x, y, w, h);
        g.setColor(Color.WHITE);
        g.drawString("Hola Mundo!!!", x, y + h/2);

    }

    
}
