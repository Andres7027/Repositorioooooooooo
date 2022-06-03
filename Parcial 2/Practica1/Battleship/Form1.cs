using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Diagnostics;

namespace Batlleship
{
    public partial class Form1 : Form
    {

        List<Button> posicionJugador;
        List<Button> posicionEnemi;
        Random rand = new Random();
        int totalNaves = 3;
        int totalNEnemigo = 3;
        int rondas = 10;
        int punTotJug = 0;
        int puntTotEne = 0;

        public Form1()
        {
            InitializeComponent();
            InitializeComponent();
            cargarBotones();
            btnAtaque.Enabled = false;
            locEnemigo.Text = null;
        }

        private void posJugador(object sender, EventArgs e)
        {
            if (totalNaves > 0)
            {
                var button = (Button)sender;
                
                button.Enabled = false;
               
                button.Tag = "naveJugador";
                
                button.BackColor = System.Drawing.Color.Blue;
                
                totalNaves--;
            }
            if (totalNaves == 0)
            {
               
                btnAtaque.Enabled = true;
               
                btnAtaque.BackColor = System.Drawing.Color.Red;
                
                txtAyuda.Top = 55;
                
                txtAyuda.Left = 230;
                
                txtAyuda.Text = "2) Ahora escoge la posición del enemigo a atacar de la lista desplegable";
                
            }
        }

        private void atacEnemigo(object sender, EventArgs e)
        {
            
            if (locEnemigo.Text != "")
            {
                
                var posAtaque = locEnemigo.Text;
               
                posAtaque = posAtaque.ToLower();

                int index = posicionEnemi.FindIndex(a => a.Name == posAtaque);

                if (posicionEnemi[index].Enabled && rondas > 0)
                {

                    rondas--;
                    
                    textRondas.Text = "Rondas" + rondas;
                   

                    if (posicionEnemi[index].Tag == "naveEnemiga")
                    {
                        posicionEnemi[index].Enabled = false;
                        
                        posicionEnemi[index].BackgroundImage = Properties.Resources.iconofuego;
                        
                        posicionEnemi[index].BackColor = System.Drawing.Color.DarkBlue;
                      
                        punTotJug++;
                        
                        puntajeJugador.Text = "" + punTotJug;
                        
                        tempEnemigo.Start();
                        
                    }
                    else
                    { 
                        posicionEnemi[index].Enabled = false;
                        
                        posicionEnemi[index].BackgroundImage = Properties.Resources.fallasteIcono;
                        
                        posicionEnemi[index].BackColor = System.Drawing.Color.DarkBlue;
                        
                        tempEnemigo.Start();
                    }
                }
            }
            else
            {
                MessageBox.Show("Escoge una localizacipon de la lista. ");
            }
        }

        private void ataqueEnemigo(object sender, EventArgs e)
        {
            if (posicionJugador.Count > 0 && rondas > 0)
            {

                rondas--; 
                textRondas.Text = "Rondas " + rondas; 

                int index = rand.Next(posicionJugador.Count);

                if (posicionJugador[index].Tag == "naveJugador")
                {
                    posicionJugador[index].BackgroundImage = Properties.Resources.iconofuego;

                    movEnemigo.Text = "" + posicionJugador[index].Text;
                    
                    posicionJugador[index].Enabled = false;
                    
                    posicionJugador[index].BackColor = System.Drawing.Color.DarkBlue;
                    
                    posicionJugador.RemoveAt(index);
                    
                    puntTotEne++;
                    
                    puntajeEnemigo.Text = "" + puntTotEne;
                    
                    tempEnemigo.Stop();
                    
                }
                else
                {
                    posicionJugador[index].BackgroundImage = Properties.Resources.fallasteIcono;
                    
                    movEnemigo.Text = "" + posicionJugador[index].Text;
                    
                    posicionJugador[index].Enabled = false;
                    
                    posicionJugador[index].BackColor = System.Drawing.Color.DarkBlue;
                    
                    posicionJugador.RemoveAt(index);
                    
                    tempEnemigo.Stop();
                   
                }

            }

            if (rondas < 1 || punTotJug > 2 || puntTotEne > 2)
            {
                if (punTotJug > puntTotEne)
                {
                    MessageBox.Show("Ganaste", "Ganador");
                }
                if (punTotJug == puntTotEne)
                {
                    MessageBox.Show("Nadie ganó", "Empate");
                }
                if (puntTotEne > punTotJug)
                {
                    MessageBox.Show("Haha! Hundí todas tus naves", "Perdedor");
                }
            }
        }
        private void posicionEnemigo(object sender, EventArgs e)
        {

            int index = rand.Next(posicionEnemi.Count);

            if (posicionEnemi[index].Enabled == true && posicionEnemi[index].Tag == null)
            {
                posicionEnemi[index].Tag = "naveEnemiga";
                
                totalNEnemigo--;

                Debug.WriteLine("posición Enemiga  " + posicionEnemi[index].Text);
               
            }
            else
            {
                index = rand.Next(posicionEnemi.Count);
            }
            if (totalNEnemigo < 1)
            {
                posEnemigo.Stop();
            }
        }

        private void cargarBotones()
        {
            posicionJugador = new List<Button> { w1, w2, w3, w4, x1, x2, x3, x4, y1, y2, y3, y4, z1, z2, z3, z4 };
            posicionEnemi = new List<Button> { a1, a2, a3, a4, b1, b2, b3, b4, c1, c2, c3, c4, d1, d2, d3, d4 };

            for (int i = 0; i < posicionEnemi.Count; i++)
            {
                posicionEnemi[i].Tag = null;
                locEnemigo.Items.Add(posicionEnemi[i].Text);
            }
        }
    }
}
