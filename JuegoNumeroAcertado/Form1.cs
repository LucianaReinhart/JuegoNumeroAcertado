using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JuegoNumeroAcertado
{
    public partial class Form1 : Form
    {
        private int contIntentos = 0;
        private bool control = false;
        private int numeroBuscado;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnEmpezarJuego_Click(object sender, EventArgs e)
        {
            try
            {
                int numAleatorio = 0;
                if (control == false)
                {
                    Random random = new Random();
                    numAleatorio = random.Next(1, 101);
                    numeroBuscado = numAleatorio;
                    control = true;
                }
                if(control == true)
                {
                    int numIngresado = int.Parse(tBoxNumeroIngresado.Text);
                    if(numIngresado > 0 && numIngresado <= 100)
                    {
                        if(numIngresado != numeroBuscado)
                        {
                            if (numIngresado > numeroBuscado)
                                lblPista.Text = "El número buscado es menor al " + numIngresado;
                            else
                                lblPista.Text = "El número buscado es mayor al " + numIngresado;

                            contIntentos++;
                            tBoxNumeroIngresado.Text = "";
                            lblIntentos.Text = "Intentos: " + contIntentos;
                            //MessageBox.Show("busco el "+ numeroBuscado + " intentos: "+contIntentos);
                        }
                        else
                        {
                            MessageBox.Show("Felicitaciones el número ganador es: " + numeroBuscado);
                            tBoxNumeroIngresado.Text = "";
                            lblIntentos.Text = "";
                            lblPista.Text = "";
                            contIntentos = 0;
                            control = false;

                        }
                    }
                    else
                    {
                        MessageBox.Show("Ingrese un número del 1 al 100");
                    }

                }
                

            }
            catch (Exception)
            {
                MessageBox.Show("Ingrese un número correctamente");
            }

        }

        private void lblIntentos_Click(object sender, EventArgs e)
        {

        }

        private void btnIntentar_Click(object sender, EventArgs e)
        {
            int numAleatorio = 0;
            if (control == true)
            {
                Random random = new Random();
                numAleatorio = random.Next(1, 101);
                numeroBuscado = numAleatorio;
                tBoxNumeroIngresado.Text = "";
                lblIntentos.Text = "";
                lblPista.Text = "";
                contIntentos = 0;
            }
        }
    }
}
