using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MathGame
{
    public partial class Juego : Form
    {
        int tr;
        Random rnd = new Random();
        int valor;
        int valor2;
        int resultado;
       

        public Juego()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            tr = tr - 1;

            Temporizador.Text = tr.ToString();
          
            if (tr == 0)
            {
                tr = 10;

                NumerosNuevos();

            }

        }

        private void Juego_Load(object sender, EventArgs e)
        {
            tr = 10;
            NumerosNuevos();
        }
        void NumerosNuevos()
        {
            valor = rnd.Next(1,200);
            string valorstring = valor.ToString();
            Numero1.Text = valorstring;

            valor2 = rnd.Next(1,200);
            string valor2string = valor2.ToString();
            Numero2.Text = valor2string;
            
        }

        private void Resultado_TextChanged(object sender, EventArgs e)
        {
            if (Resultado.Text != "") {
                resultado = Convert.ToInt32(Resultado.Text);
                    }
            if(valor + valor2 == resultado)
            {
                CorrectLabel.Text = "Correct!";
            }
        }
    }
}
