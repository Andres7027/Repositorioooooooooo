using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace PingPong
{
    public partial class PingPongGame : Form
    {

        int velocidad = 10;
        int cont = 0;
        int puntaje = 0;
        bool arriba;
        bool izquierda;

        public PingPongGame()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (pelota.Left > raqueta.Left)
            {
                timer1.Enabled = false;

                MessageBox.Show("Puntaje: " + puntaje.ToString() + " veces!");

                puntaje = 0;

                velocidad = 10;

                cont = 0;
            }

            if (pelota.Left + pelota.Width >= raqueta.Left &&
                pelota.Left + pelota.Width <= raqueta.Left + raqueta.Width &&
                pelota.Top + pelota.Height >= raqueta.Top &&
                pelota.Top + pelota.Height <= raqueta.Top + raqueta.Height)
            {
                izquierda = false;

                puntaje += 1;

                this.Text = "Puntuación: " + puntaje.ToString() + "";

                cont += 1;

                if (cont > 5)
                {
                    velocidad += 1;

                    cont = 0;
                }

            }

            if (izquierda)
            {
                pelota.Left += velocidad;
            }
            else
            {
                pelota.Left -= velocidad;
            }

            if (arriba)
            {
                pelota.Top += velocidad;
            }
            else
            {
                pelota.Top -= velocidad;
            }
            if(pelota.Top >= this.Height-50)
            {
                arriba = false;
            }
            if(pelota.Top <= 0)
            {
                arriba = true;
            }
            if(pelota.Left <= 0)
            {
                izquierda = true;
            }
            
        }

        private void juego_Closing(object sender, FormClosingEventArgs e)
        {
            this.Owner.Show();        
        }

        private void PingPongGame_MouseMove(object sender, MouseEventArgs e)
        {
            raqueta.Top = e.Y;
        }

        private void PingPongGame_Load(object sender, EventArgs e)
        {
            this.Text = "Puntaje: 0";

            Random aleatorio = new Random();

            pelota.Location = new Point(0, aleatorio.Next(this.Height));

            arriba = true;

            izquierda = true;

            timer1.Enabled = true;

            puntaje = 0;
        }
    }
}
