using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eventos
{
    public partial class Form1 : Form
    {
        public bool lightmode = true;
        public Label sonder = new Label();
        public Label sonder2 = new Label();
        public Label sonder3 = new Label();
        public Random random = new Random();
        public Random random2 = new Random();
        //public Label lblSat = new Label();
        public int cont = 0;
        
        List<Color> colores = new List<Color> { Color.Red, Color.Green, Color.Blue, Color.Yellow };
        public int indiceColor = 0;

        public Form1()
        {
            InitializeComponent();
            this.Text = "LightMode";
            timer1.Interval = 3000;
            timer1.Enabled = false;
            timer2.Interval = 2000;
            timer2.Enabled = false;
            this.BackgroundImage = Image.FromFile("C:\\Users\\Saul\\source\\repos\\Eventos\\Eventos\\Imagenes\\LightMode.png");            
            Icon icono = new Icon("C:\\Users\\Saul\\source\\repos\\Eventos\\Eventos\\Imagenes\\Bunny.ico");
            this.Icon = icono;
            
            btnCerrar.Hide();

            lblSat1.Hide();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {            
            //timer1.Enabled = false;
            button2.BackColor = colores[indiceColor];
            indiceColor++;
            if (indiceColor >= colores.Count)
            {
                indiceColor = 0;
            }
            cont++;
            int fuente = 14 + 5 * cont;
            lblSat1.Font = new Font("Microsoft Sans Serif", fuente, FontStyle.Italic | FontStyle.Bold);
        }

        private void Form1_Shown_1(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer2.Enabled= true;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if(lightmode == true)
            {
                pictureBox1.Image = Image.FromFile(rutas[contador]);

                contador++;

                if (contador >= rutas.Length)
                {
                    contador = 0;
                }
            }
            else
            {
                pictureBox1.Image = Image.FromFile(rutas2[contador]);
                contador++;
                if (contador >= rutas2.Length)
                {
                    contador = 0;
                }
            }
            
        }
        private string[] rutas = { "C:\\Users\\Saul\\source\\repos\\Eventos\\Eventos\\Imagenes\\perrito1.jpg", "C:\\Users\\Saul\\source\\repos\\Eventos\\Eventos\\Imagenes\\perrito2.jpg", "C:\\Users\\Saul\\source\\repos\\Eventos\\Eventos\\Imagenes\\perrito3.jpg", "C:\\Users\\Saul\\source\\repos\\Eventos\\Eventos\\Imagenes\\perrito4.png", "C:\\Users\\Saul\\source\\repos\\Eventos\\Eventos\\Imagenes\\perrito5.jpg" };
        private string[] rutas2 = { "C:\\Users\\Saul\\source\\repos\\Eventos\\Eventos\\Imagenes\\Img1.png", "C:\\Users\\Saul\\source\\repos\\Eventos\\Eventos\\Imagenes\\Img2.png", "C:\\Users\\Saul\\source\\repos\\Eventos\\Eventos\\Imagenes\\Img3.png", "C:\\Users\\Saul\\source\\repos\\Eventos\\Eventos\\Imagenes\\Img4.png", "C:\\Users\\Saul\\source\\repos\\Eventos\\Eventos\\Imagenes\\Img5.png", "C:\\Users\\Saul\\source\\repos\\Eventos\\Eventos\\Imagenes\\Img6.png", "C:\\Users\\Saul\\source\\repos\\Eventos\\Eventos\\Imagenes\\Img7.png", "C:\\Users\\Saul\\source\\repos\\Eventos\\Eventos\\Imagenes\\Img8.png", "C:\\Users\\Saul\\source\\repos\\Eventos\\Eventos\\Imagenes\\Img9.png" };
        private int contador = 0;        

        private void button2_Click(object sender, EventArgs e)
        {
            int[] ejex = Enumerable.Range(0, 500).OrderBy(x => random.Next()).Take(3).ToArray();
            int[] ejey = Enumerable.Range(0, 300).OrderBy(x => random.Next()).Take(3).ToArray();
            sonder.AutoSize = true;
            sonder2.AutoSize = true;
            sonder3.AutoSize = true;
            if (lightmode == true)
            {
                sonder.Font = new Font("Microsoft Sans Serif", 16, FontStyle.Italic | FontStyle.Bold);
                sonder.BackColor = Color.Transparent;
                sonder.Text = "La vida es bella o triste, \nsolo depende de como la queramos ver";
                sonder.Location = new Point(ejex[0], ejey[0]);
                this.Controls.Add(sonder);
                sonder2.Font = new Font("Microsoft Sans Serif", 16, FontStyle.Italic | FontStyle.Bold);
                sonder2.BackColor = Color.Transparent;
                sonder2.Text = "No hagas lo que los demás hacen. \nHaz lo que los demás quisieran hacer y no se atreven";
                sonder2.Location = new Point(ejex[1], ejey[1]);
                this.Controls.Add(sonder2);
                sonder3.Font = new Font("Microsoft Sans Serif", 16, FontStyle.Italic | FontStyle.Bold);
                sonder3.BackColor = Color.Transparent;
                sonder3.Text = "Si no puedes dejar de pensar en algo,\n no dejes de trabajar en ello";
                sonder3.Location = new Point(ejex[2], ejey[2]);
                this.Controls.Add(sonder3);
            }
            else
            {
                sonder.Font = new Font("Microsoft Sans Serif", 30, FontStyle.Italic | FontStyle.Bold);
                sonder.BackColor = Color.Transparent;
                sonder.Text = "666";
                sonder.ForeColor = Color.Red;
                sonder.Location = new Point(ejex[0], ejey[0]);
                this.Controls.Add(sonder);
                sonder2.Font = new Font("Microsoft Sans Serif", 30, FontStyle.Italic | FontStyle.Bold);
                sonder2.BackColor = Color.Transparent;
                sonder2.Text = "SATANAS ES MI PASTOR";
                sonder.ForeColor = Color.Red;
                sonder2.Location = new Point(ejex[1], ejey[1]);
                this.Controls.Add(sonder2);
                sonder3.Font = new Font("Microsoft Sans Serif", 30, FontStyle.Italic | FontStyle.Bold);
                sonder3.BackColor = Color.Transparent;
                sonder3.Text = "696";
                sonder.ForeColor = Color.Red;
                sonder3.Location = new Point(ejex[2], ejey[2]);
                this.Controls.Add(sonder3);
            }
            
        }

        private void darkmode_CheckedChanged(object sender, EventArgs e)
        {
            lblSat1.Show();

            lightmode = false;            
            //button2.Enabled = lightmode;
            this.BackgroundImage = Image.FromFile("C:\\Users\\Saul\\source\\repos\\Eventos\\Eventos\\Imagenes\\DarkMode.jpg");
            this.BackgroundImageLayout = ImageLayout.Stretch;
            Icon icono = new Icon("C:\\Users\\Saul\\source\\repos\\Eventos\\Eventos\\Imagenes\\Sauron.ico");
            this.Icon = icono;
            sonder.Text = "666";
            sonder.ForeColor = Color.Red;            
            sonder2.Text = "SATANAS ES MI PASTOR";
            sonder2.ForeColor = Color.Red;
            sonder3.Text = "696";
            sonder3.ForeColor = Color.Red;
            this.Controls.Add(sonder);
            this.Controls.Add(sonder2);
            this.Controls.Add(sonder3);
            this.FormBorderStyle = FormBorderStyle.None;
            btnCerrar.Show();
            
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            int ejex = random.Next(0, this.ClientSize.Width - btnCerrar.Width);
            int ejey = random.Next(0, this.ClientSize.Height - btnCerrar.Height);
            btnCerrar.Location = new Point(ejex, ejey);
        }
    }
}
