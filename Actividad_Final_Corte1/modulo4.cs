using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Actividad_Final_Corte1
{
    public partial class modulo4 : Form
    {
        public modulo4()
        {
            InitializeComponent();
        }

        private void btnInvertir_Click(object sender, EventArgs e)
        {
            

                String Palabra;
                Palabra = txtPalabra.Text;
            for (int x = Palabra.Length - 1; x >= 0; x--) {
                String Resul;
                Resul = txtResultado.Text;
                Resul += Palabra[x];

                txtResultado.Text = (Resul);


            }
            
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtPalabra.Clear();
            txtResultado.Clear();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
             ContenidoModulos CModulos = new ContenidoModulos();
              this.Hide();
            CModulos.Show();
        }

        private void modulo4_Load(object sender, EventArgs e)
        {

        }
    }
}
