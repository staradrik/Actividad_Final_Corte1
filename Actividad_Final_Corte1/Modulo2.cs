using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Actividad_Final_Corte1
{
    public partial class Modulo2 : Form
    {
        public Modulo2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //variables
            Double Base;
            Double Altura;
            Double Resultado;

            //Convertir
            Base = Convert.ToDouble(txtbase.Text);
            Altura = Convert.ToDouble(txtAltura.Text);
           //Operacion para obtener el área de un cuadrado
            Resultado = Base * Altura;
            txtArea.Text = Convert.ToString(Resultado);

        }
        
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            //Limpiar cajas de texto
            txtbase.Clear();
            txtAltura.Clear();
            txtArea.Clear();

        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            //Regresar
          ContenidoModulos CModulos = new ContenidoModulos();
            this.Hide();
           CModulos.Show();
        }

        private void Modulo2_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
