
namespace Batlleship
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.puntajeJugador = new System.Windows.Forms.Label();
            this.puntajeEnemigo = new System.Windows.Forms.Label();
            this.movEnemigo = new System.Windows.Forms.Label();
            this.textRondas = new System.Windows.Forms.Label();
            this.txtAyuda = new System.Windows.Forms.Label();
            this.locEnemigo = new System.Windows.Forms.ComboBox();
            this.btnAtaque = new System.Windows.Forms.Button();
            this.w1 = new System.Windows.Forms.Button();
            this.w2 = new System.Windows.Forms.Button();
            this.w3 = new System.Windows.Forms.Button();
            this.w4 = new System.Windows.Forms.Button();
            this.x4 = new System.Windows.Forms.Button();
            this.x3 = new System.Windows.Forms.Button();
            this.x2 = new System.Windows.Forms.Button();
            this.x1 = new System.Windows.Forms.Button();
            this.y4 = new System.Windows.Forms.Button();
            this.y3 = new System.Windows.Forms.Button();
            this.y2 = new System.Windows.Forms.Button();
            this.y1 = new System.Windows.Forms.Button();
            this.z4 = new System.Windows.Forms.Button();
            this.z3 = new System.Windows.Forms.Button();
            this.z2 = new System.Windows.Forms.Button();
            this.z1 = new System.Windows.Forms.Button();
            this.d4 = new System.Windows.Forms.Button();
            this.d3 = new System.Windows.Forms.Button();
            this.d2 = new System.Windows.Forms.Button();
            this.d1 = new System.Windows.Forms.Button();
            this.c4 = new System.Windows.Forms.Button();
            this.c3 = new System.Windows.Forms.Button();
            this.c2 = new System.Windows.Forms.Button();
            this.c1 = new System.Windows.Forms.Button();
            this.b4 = new System.Windows.Forms.Button();
            this.b3 = new System.Windows.Forms.Button();
            this.b2 = new System.Windows.Forms.Button();
            this.b1 = new System.Windows.Forms.Button();
            this.a4 = new System.Windows.Forms.Button();
            this.a3 = new System.Windows.Forms.Button();
            this.a2 = new System.Windows.Forms.Button();
            this.a1 = new System.Windows.Forms.Button();
            this.tempEnemigo = new System.Windows.Forms.Timer(this.components);
            this.posEnemigo = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // puntajeJugador
            // 
            this.puntajeJugador.AutoSize = true;
            this.puntajeJugador.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.puntajeJugador.Location = new System.Drawing.Point(359, 101);
            this.puntajeJugador.Name = "puntajeJugador";
            this.puntajeJugador.Size = new System.Drawing.Size(49, 32);
            this.puntajeJugador.TabIndex = 0;
            this.puntajeJugador.Text = "00";
            // 
            // puntajeEnemigo
            // 
            this.puntajeEnemigo.AutoSize = true;
            this.puntajeEnemigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.puntajeEnemigo.Location = new System.Drawing.Point(904, 101);
            this.puntajeEnemigo.Name = "puntajeEnemigo";
            this.puntajeEnemigo.Size = new System.Drawing.Size(49, 32);
            this.puntajeEnemigo.TabIndex = 1;
            this.puntajeEnemigo.Text = "00";
            // 
            // movEnemigo
            // 
            this.movEnemigo.AutoSize = true;
            this.movEnemigo.BackColor = System.Drawing.Color.Transparent;
            this.movEnemigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.movEnemigo.ForeColor = System.Drawing.Color.White;
            this.movEnemigo.Location = new System.Drawing.Point(898, 31);
            this.movEnemigo.Name = "movEnemigo";
            this.movEnemigo.Size = new System.Drawing.Size(52, 32);
            this.movEnemigo.TabIndex = 2;
            this.movEnemigo.Text = "A1";
            // 
            // textRondas
            // 
            this.textRondas.AutoSize = true;
            this.textRondas.BackColor = System.Drawing.Color.Transparent;
            this.textRondas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textRondas.ForeColor = System.Drawing.Color.White;
            this.textRondas.Location = new System.Drawing.Point(490, 157);
            this.textRondas.Name = "textRondas";
            this.textRondas.Size = new System.Drawing.Size(85, 25);
            this.textRondas.TabIndex = 3;
            this.textRondas.Text = "Rondas";
            // 
            // txtAyuda
            // 
            this.txtAyuda.AutoSize = true;
            this.txtAyuda.BackColor = System.Drawing.Color.Transparent;
            this.txtAyuda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAyuda.ForeColor = System.Drawing.Color.Lime;
            this.txtAyuda.Location = new System.Drawing.Point(90, 543);
            this.txtAyuda.Name = "txtAyuda";
            this.txtAyuda.Size = new System.Drawing.Size(495, 18);
            this.txtAyuda.TabIndex = 4;
            this.txtAyuda.Text = "1) Haz click en tres botones en el lado del jugador para empezar";
            // 
            // locEnemigo
            // 
            this.locEnemigo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.locEnemigo.DropDownWidth = 95;
            this.locEnemigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.locEnemigo.FormattingEnabled = true;
            this.locEnemigo.Location = new System.Drawing.Point(181, 27);
            this.locEnemigo.Name = "locEnemigo";
            this.locEnemigo.Size = new System.Drawing.Size(97, 33);
            this.locEnemigo.TabIndex = 5;
            // 
            // btnAtaque
            // 
            this.btnAtaque.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtaque.ForeColor = System.Drawing.Color.Red;
            this.btnAtaque.Location = new System.Drawing.Point(433, 98);
            this.btnAtaque.Name = "btnAtaque";
            this.btnAtaque.Size = new System.Drawing.Size(93, 40);
            this.btnAtaque.TabIndex = 6;
            this.btnAtaque.Text = "ATACAR";
            this.btnAtaque.UseVisualStyleBackColor = true;
            this.btnAtaque.Click += new System.EventHandler(this.atacEnemigo);
            // 
            // w1
            // 
            this.w1.Location = new System.Drawing.Point(106, 228);
            this.w1.Name = "w1";
            this.w1.Size = new System.Drawing.Size(75, 55);
            this.w1.TabIndex = 7;
            this.w1.Text = "W1";
            this.w1.UseVisualStyleBackColor = true;
            this.w1.Click += new System.EventHandler(this.posJugador);
            // 
            // w2
            // 
            this.w2.Location = new System.Drawing.Point(197, 228);
            this.w2.Name = "w2";
            this.w2.Size = new System.Drawing.Size(75, 55);
            this.w2.TabIndex = 8;
            this.w2.Text = "W2";
            this.w2.UseVisualStyleBackColor = true;
            this.w2.Click += new System.EventHandler(this.posJugador);
            // 
            // w3
            // 
            this.w3.Location = new System.Drawing.Point(290, 228);
            this.w3.Name = "w3";
            this.w3.Size = new System.Drawing.Size(75, 55);
            this.w3.TabIndex = 9;
            this.w3.Text = "W3";
            this.w3.UseVisualStyleBackColor = true;
            this.w3.Click += new System.EventHandler(this.posJugador);
            // 
            // w4
            // 
            this.w4.Location = new System.Drawing.Point(382, 228);
            this.w4.Name = "w4";
            this.w4.Size = new System.Drawing.Size(75, 55);
            this.w4.TabIndex = 10;
            this.w4.Text = "W4";
            this.w4.UseVisualStyleBackColor = true;
            this.w4.Click += new System.EventHandler(this.posJugador);
            // 
            // x4
            // 
            this.x4.Location = new System.Drawing.Point(381, 303);
            this.x4.Name = "x4";
            this.x4.Size = new System.Drawing.Size(75, 55);
            this.x4.TabIndex = 14;
            this.x4.Text = "X4";
            this.x4.UseVisualStyleBackColor = true;
            this.x4.Click += new System.EventHandler(this.posJugador);
            // 
            // x3
            // 
            this.x3.Location = new System.Drawing.Point(289, 303);
            this.x3.Name = "x3";
            this.x3.Size = new System.Drawing.Size(75, 55);
            this.x3.TabIndex = 13;
            this.x3.Text = "X3";
            this.x3.UseVisualStyleBackColor = true;
            this.x3.Click += new System.EventHandler(this.posJugador);
            // 
            // x2
            // 
            this.x2.Location = new System.Drawing.Point(196, 303);
            this.x2.Name = "x2";
            this.x2.Size = new System.Drawing.Size(75, 55);
            this.x2.TabIndex = 12;
            this.x2.Text = "X2";
            this.x2.UseVisualStyleBackColor = true;
            this.x2.Click += new System.EventHandler(this.posJugador);
            // 
            // x1
            // 
            this.x1.Location = new System.Drawing.Point(105, 303);
            this.x1.Name = "x1";
            this.x1.Size = new System.Drawing.Size(75, 55);
            this.x1.TabIndex = 11;
            this.x1.Text = "X1";
            this.x1.UseVisualStyleBackColor = true;
            this.x1.Click += new System.EventHandler(this.posJugador);
            // 
            // y4
            // 
            this.y4.Location = new System.Drawing.Point(383, 379);
            this.y4.Name = "y4";
            this.y4.Size = new System.Drawing.Size(75, 55);
            this.y4.TabIndex = 18;
            this.y4.Text = "Y4";
            this.y4.UseVisualStyleBackColor = true;
            this.y4.Click += new System.EventHandler(this.posJugador);
            // 
            // y3
            // 
            this.y3.Location = new System.Drawing.Point(291, 379);
            this.y3.Name = "y3";
            this.y3.Size = new System.Drawing.Size(75, 55);
            this.y3.TabIndex = 17;
            this.y3.Text = "Y3";
            this.y3.UseVisualStyleBackColor = true;
            this.y3.Click += new System.EventHandler(this.posJugador);
            // 
            // y2
            // 
            this.y2.Location = new System.Drawing.Point(198, 379);
            this.y2.Name = "y2";
            this.y2.Size = new System.Drawing.Size(75, 55);
            this.y2.TabIndex = 16;
            this.y2.Text = "Y2";
            this.y2.UseVisualStyleBackColor = true;
            this.y2.Click += new System.EventHandler(this.posJugador);
            // 
            // y1
            // 
            this.y1.Location = new System.Drawing.Point(107, 379);
            this.y1.Name = "y1";
            this.y1.Size = new System.Drawing.Size(75, 55);
            this.y1.TabIndex = 15;
            this.y1.Text = "Y1";
            this.y1.UseVisualStyleBackColor = true;
            this.y1.Click += new System.EventHandler(this.posJugador);
            // 
            // z4
            // 
            this.z4.Location = new System.Drawing.Point(381, 455);
            this.z4.Name = "z4";
            this.z4.Size = new System.Drawing.Size(75, 55);
            this.z4.TabIndex = 22;
            this.z4.Text = "Z4";
            this.z4.UseVisualStyleBackColor = true;
            this.z4.Click += new System.EventHandler(this.posJugador);
            // 
            // z3
            // 
            this.z3.Location = new System.Drawing.Point(289, 455);
            this.z3.Name = "z3";
            this.z3.Size = new System.Drawing.Size(75, 55);
            this.z3.TabIndex = 21;
            this.z3.Text = "Z3";
            this.z3.UseVisualStyleBackColor = true;
            this.z3.Click += new System.EventHandler(this.posJugador);
            // 
            // z2
            // 
            this.z2.Location = new System.Drawing.Point(196, 455);
            this.z2.Name = "z2";
            this.z2.Size = new System.Drawing.Size(75, 55);
            this.z2.TabIndex = 20;
            this.z2.Text = "Z2";
            this.z2.UseVisualStyleBackColor = true;
            this.z2.Click += new System.EventHandler(this.posJugador);
            // 
            // z1
            // 
            this.z1.Location = new System.Drawing.Point(105, 455);
            this.z1.Name = "z1";
            this.z1.Size = new System.Drawing.Size(75, 55);
            this.z1.TabIndex = 19;
            this.z1.Text = "Z1";
            this.z1.UseVisualStyleBackColor = true;
            this.z1.Click += new System.EventHandler(this.posJugador);
            // 
            // d4
            // 
            this.d4.Location = new System.Drawing.Point(880, 455);
            this.d4.Name = "d4";
            this.d4.Size = new System.Drawing.Size(75, 55);
            this.d4.TabIndex = 38;
            this.d4.Text = "D4";
            this.d4.UseVisualStyleBackColor = true;
            // 
            // d3
            // 
            this.d3.Location = new System.Drawing.Point(786, 455);
            this.d3.Name = "d3";
            this.d3.Size = new System.Drawing.Size(75, 55);
            this.d3.TabIndex = 37;
            this.d3.Text = "D3";
            this.d3.UseVisualStyleBackColor = true;
            // 
            // d2
            // 
            this.d2.Location = new System.Drawing.Point(695, 455);
            this.d2.Name = "d2";
            this.d2.Size = new System.Drawing.Size(75, 55);
            this.d2.TabIndex = 36;
            this.d2.Text = "D2";
            this.d2.UseVisualStyleBackColor = true;
            // 
            // d1
            // 
            this.d1.Location = new System.Drawing.Point(603, 455);
            this.d1.Name = "d1";
            this.d1.Size = new System.Drawing.Size(75, 55);
            this.d1.TabIndex = 35;
            this.d1.Text = "D1";
            this.d1.UseVisualStyleBackColor = true;
            // 
            // c4
            // 
            this.c4.Location = new System.Drawing.Point(882, 379);
            this.c4.Name = "c4";
            this.c4.Size = new System.Drawing.Size(75, 55);
            this.c4.TabIndex = 34;
            this.c4.Text = "C4";
            this.c4.UseVisualStyleBackColor = true;
            // 
            // c3
            // 
            this.c3.Location = new System.Drawing.Point(788, 379);
            this.c3.Name = "c3";
            this.c3.Size = new System.Drawing.Size(75, 55);
            this.c3.TabIndex = 33;
            this.c3.Text = "C3";
            this.c3.UseVisualStyleBackColor = true;
            // 
            // c2
            // 
            this.c2.Location = new System.Drawing.Point(697, 379);
            this.c2.Name = "c2";
            this.c2.Size = new System.Drawing.Size(75, 55);
            this.c2.TabIndex = 32;
            this.c2.Text = "C2";
            this.c2.UseVisualStyleBackColor = true;
            // 
            // c1
            // 
            this.c1.Location = new System.Drawing.Point(605, 379);
            this.c1.Name = "c1";
            this.c1.Size = new System.Drawing.Size(75, 55);
            this.c1.TabIndex = 31;
            this.c1.Text = "C1";
            this.c1.UseVisualStyleBackColor = true;
            // 
            // b4
            // 
            this.b4.Location = new System.Drawing.Point(880, 303);
            this.b4.Name = "b4";
            this.b4.Size = new System.Drawing.Size(75, 55);
            this.b4.TabIndex = 30;
            this.b4.Text = "B4";
            this.b4.UseVisualStyleBackColor = true;
            // 
            // b3
            // 
            this.b3.Location = new System.Drawing.Point(786, 303);
            this.b3.Name = "b3";
            this.b3.Size = new System.Drawing.Size(75, 55);
            this.b3.TabIndex = 29;
            this.b3.Text = "B3";
            this.b3.UseVisualStyleBackColor = true;
            // 
            // b2
            // 
            this.b2.Location = new System.Drawing.Point(695, 303);
            this.b2.Name = "b2";
            this.b2.Size = new System.Drawing.Size(75, 55);
            this.b2.TabIndex = 28;
            this.b2.Text = "B2";
            this.b2.UseVisualStyleBackColor = true;
            // 
            // b1
            // 
            this.b1.Location = new System.Drawing.Point(603, 303);
            this.b1.Name = "b1";
            this.b1.Size = new System.Drawing.Size(75, 55);
            this.b1.TabIndex = 27;
            this.b1.Text = "B1";
            this.b1.UseVisualStyleBackColor = true;
            // 
            // a4
            // 
            this.a4.Location = new System.Drawing.Point(881, 228);
            this.a4.Name = "a4";
            this.a4.Size = new System.Drawing.Size(75, 55);
            this.a4.TabIndex = 26;
            this.a4.Text = "A4";
            this.a4.UseVisualStyleBackColor = true;
            // 
            // a3
            // 
            this.a3.Location = new System.Drawing.Point(787, 228);
            this.a3.Name = "a3";
            this.a3.Size = new System.Drawing.Size(75, 55);
            this.a3.TabIndex = 25;
            this.a3.Text = "A3";
            this.a3.UseVisualStyleBackColor = true;
            // 
            // a2
            // 
            this.a2.Location = new System.Drawing.Point(696, 228);
            this.a2.Name = "a2";
            this.a2.Size = new System.Drawing.Size(75, 55);
            this.a2.TabIndex = 24;
            this.a2.Text = "A2";
            this.a2.UseVisualStyleBackColor = true;
            // 
            // a1
            // 
            this.a1.Location = new System.Drawing.Point(604, 228);
            this.a1.Name = "a1";
            this.a1.Size = new System.Drawing.Size(75, 55);
            this.a1.TabIndex = 23;
            this.a1.Text = "A1";
            this.a1.UseVisualStyleBackColor = true;
            // 
            // tempEnemigo
            // 
            this.tempEnemigo.Interval = 1000;
            this.tempEnemigo.Tick += new System.EventHandler(this.ataqueEnemigo);
            // 
            // posEnemigo
            // 
            this.posEnemigo.Enabled = true;
            this.posEnemigo.Tick += new System.EventHandler(this.posicionEnemigo);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Batlleship.Properties.Resources.fondo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1063, 577);
            this.Controls.Add(this.d4);
            this.Controls.Add(this.d3);
            this.Controls.Add(this.d2);
            this.Controls.Add(this.d1);
            this.Controls.Add(this.c4);
            this.Controls.Add(this.c3);
            this.Controls.Add(this.c2);
            this.Controls.Add(this.c1);
            this.Controls.Add(this.b4);
            this.Controls.Add(this.b3);
            this.Controls.Add(this.b2);
            this.Controls.Add(this.b1);
            this.Controls.Add(this.a4);
            this.Controls.Add(this.a3);
            this.Controls.Add(this.a2);
            this.Controls.Add(this.a1);
            this.Controls.Add(this.z4);
            this.Controls.Add(this.z3);
            this.Controls.Add(this.z2);
            this.Controls.Add(this.z1);
            this.Controls.Add(this.y4);
            this.Controls.Add(this.y3);
            this.Controls.Add(this.y2);
            this.Controls.Add(this.y1);
            this.Controls.Add(this.x4);
            this.Controls.Add(this.x3);
            this.Controls.Add(this.x2);
            this.Controls.Add(this.x1);
            this.Controls.Add(this.w4);
            this.Controls.Add(this.w3);
            this.Controls.Add(this.w2);
            this.Controls.Add(this.w1);
            this.Controls.Add(this.btnAtaque);
            this.Controls.Add(this.locEnemigo);
            this.Controls.Add(this.txtAyuda);
            this.Controls.Add(this.textRondas);
            this.Controls.Add(this.movEnemigo);
            this.Controls.Add(this.puntajeEnemigo);
            this.Controls.Add(this.puntajeJugador);
            this.Name = "Form1";
            this.Text = "Battleship";
            this.TransparencyKey = System.Drawing.Color.Transparent;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label puntajeJugador;
        private System.Windows.Forms.Label puntajeEnemigo;
        private System.Windows.Forms.Label movEnemigo;
        private System.Windows.Forms.Label textRondas;
        private System.Windows.Forms.Label txtAyuda;
        private System.Windows.Forms.ComboBox locEnemigo;
        private System.Windows.Forms.Button btnAtaque;
        private System.Windows.Forms.Button w1;
        private System.Windows.Forms.Button w2;
        private System.Windows.Forms.Button w3;
        private System.Windows.Forms.Button w4;
        private System.Windows.Forms.Button x4;
        private System.Windows.Forms.Button x3;
        private System.Windows.Forms.Button x2;
        private System.Windows.Forms.Button x1;
        private System.Windows.Forms.Button y4;
        private System.Windows.Forms.Button y3;
        private System.Windows.Forms.Button y2;
        private System.Windows.Forms.Button y1;
        private System.Windows.Forms.Button z4;
        private System.Windows.Forms.Button z3;
        private System.Windows.Forms.Button z2;
        private System.Windows.Forms.Button z1;
        private System.Windows.Forms.Button d4;
        private System.Windows.Forms.Button d3;
        private System.Windows.Forms.Button d2;
        private System.Windows.Forms.Button d1;
        private System.Windows.Forms.Button c4;
        private System.Windows.Forms.Button c3;
        private System.Windows.Forms.Button c2;
        private System.Windows.Forms.Button c1;
        private System.Windows.Forms.Button b4;
        private System.Windows.Forms.Button b3;
        private System.Windows.Forms.Button b2;
        private System.Windows.Forms.Button b1;
        private System.Windows.Forms.Button a4;
        private System.Windows.Forms.Button a3;
        private System.Windows.Forms.Button a2;
        private System.Windows.Forms.Button a1;
        private System.Windows.Forms.Timer tempEnemigo;
        private System.Windows.Forms.Timer posEnemigo;
    }
}

