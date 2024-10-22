//Laura Cristina Colorado Sánchez

using System;
using System.Windows.Forms;

namespace Graficación_en_Forms
{
    public partial class Form1 : Form
    {
        private float velocidadY = -15f; 
        private float gravedad = 0.5f;
        private float alturaInicial; 
        private int rebotes = 0; 
        private int maxRebotes = 8;

        public Form1()
        {
            InitializeComponent();
            alturaInicial = balon.Top; 
            tiempo.Interval = 20;
            tiempo.Tick += new EventHandler(tiempo_Tick); 
            tiempo.Start();
        }

        private void tiempo_Tick(object sender, EventArgs e)
        {
           
            balon.Top += (int)velocidadY;

            velocidadY += gravedad;

          
            if (balon.Top >= alturaInicial)
            {
                balon.Top = (int)alturaInicial; 
                rebotes++;

                
                velocidadY = -velocidadY * 0.7f;

              
                velocidadY *= 1.2f; 

                if (rebotes >= maxRebotes)
                {
                    velocidadY *= 0.7f; 
                    if (Math.Abs(velocidadY) < 1f) 
                    {
                        velocidadY = 0; 
                        tiempo.Stop();
                    }
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}


