using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Actividad_Final_Corte1
{
    public partial class Modulo1 : Form
    {
        public Modulo1()
        {
            InitializeComponent();
        }

        private void btnComparar_Click(object sender, EventArgs e)
        {
            //Declaracion de variables

            int Num1;
            int Num2;
            int NumMayor;
            //---Leer dos numeros
            Num1 = Convert.ToInt32(txtN1.Text);
            Num2 = Convert.ToInt32(txtN2.Text);
            //---- Determinar el numero mayor
            if (Num1 >= Num2)
            {
                NumMayor = Num1;
                txtNM.Text = NumMayor.ToString();
            }
            else {
                NumMayor = Num2;
                txtNM.Text = NumMayor.ToString();
            }
        }

        private void btn_Limpiar_Click(object sender, EventArgs e)
        {
            txtN1.Clear();
            txtN2.Clear();
            txtNM.Clear();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            ContenidoModulos Contemd = new ContenidoModulos();
            this.Hide();
            Contemd.Show();
        }

        private void txtN2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Modulo1_Load(object sender, EventArgs e)
        {

        }
    }
}
