
namespace PingPong
{
    partial class PingPongGame
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.raqueta = new System.Windows.Forms.PictureBox();
            this.pelota = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.raqueta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pelota)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // raqueta
            // 
            this.raqueta.BackColor = System.Drawing.Color.Red;
            this.raqueta.Location = new System.Drawing.Point(1242, 181);
            this.raqueta.Name = "raqueta";
            this.raqueta.Size = new System.Drawing.Size(14, 86);
            this.raqueta.TabIndex = 1;
            this.raqueta.TabStop = false;
            // 
            // pelota
            // 
            this.pelota.BackColor = System.Drawing.Color.Transparent;
            this.pelota.BackgroundImage = global::PingPong.Properties.Resources.Pelota;
            this.pelota.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pelota.Location = new System.Drawing.Point(453, 239);
            this.pelota.Name = "pelota";
            this.pelota.Size = new System.Drawing.Size(30, 30);
            this.pelota.TabIndex = 2;
            this.pelota.TabStop = false;
            // 
            // PingPongGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PingPong.Properties.Resources.Mesa;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.pelota);
            this.Controls.Add(this.raqueta);
            this.Name = "PingPongGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ping Pong Game";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.juego_Closing);
            this.Load += new System.EventHandler(this.PingPongGame_Load);
            this.Click += new System.EventHandler(this.PingPongGame_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PingPongGame_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.raqueta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pelota)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox raqueta;
        private System.Windows.Forms.PictureBox pelota;
    }
}