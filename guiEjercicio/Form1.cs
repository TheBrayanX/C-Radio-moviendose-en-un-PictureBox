using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace guiEjercicio
{
    public partial class Form1 : Form
    {
        private Globo globo;
        private Graphics areaDibujo;
        public Form1()
        {
            InitializeComponent();
            globo = new Globo();
            areaDibujo = pictureBox1.CreateGraphics();
            lbRadio.Text = "Tamaño del Lienzo: ";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            globo.MoverArriba();
            Dibujar();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            globo.MoverAbajo();
            Dibujar();
        }

        private void Dibujar()
        {
            lbRadio.Text = Convert.ToString(globo.Radio);
            globo.Mostrar(areaDibujo);
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            globo.Radio = trackBar1.Value;
            Dibujar();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            globo.MoverIzquierda();
            Dibujar();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            globo.MoverDerecha();
            Dibujar();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile("C:\\Users\\braya\\OneDrive\\Pictures\\image1.jpg");
        }
    }
}
