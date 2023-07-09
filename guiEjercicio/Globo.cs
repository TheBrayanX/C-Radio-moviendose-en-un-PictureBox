using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Data;
using System.Windows.Forms;

namespace guiEjercicio
{
    public class Globo
    {
        private int x = 50;
        private int y = 50;
        private int radio = 10;
        private int yIntervalo = 20;
        private int xIntervalo = 20;
        SolidBrush red = new SolidBrush(Color.Red);

        public void MoverArriba()
        {
            y = y - yIntervalo;
        } 

        public void MoverAbajo()
        {
            y = y + yIntervalo;   
        }
        public void MoverIzquierda()
        {
            x = x - xIntervalo; 
        }
        public void MoverDerecha()
        {
            x = x + xIntervalo;
        }
        
        public void Mostrar(Graphics areaDibujo)
        {
            Mostrar(areaDibujo, red);
        }
        public void Mostrar(Graphics areaDibujo, Brush lapiz)
        {
            Image clear = Image.FromFile("C:\\Users\\braya\\OneDrive\\Pictures\\image1.jpg");
            int ximage = 0;
            int yimage = 0;
            int width = 531;
            int height = 316;
            areaDibujo.DrawImage(clear, ximage, yimage, width, height);
            areaDibujo.FillEllipse(red, x, y, radio * 2, radio * 2);
        }

        public int Radio
        {
            get { return radio; }
            set { radio = value; }
        }

    }
}