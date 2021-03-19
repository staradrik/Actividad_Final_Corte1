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
            

                String Palabra; //Variable String - CADENA DE CARACTERES
                Palabra = txtPalabra.Text;

            //CICLO FOR QUE RECORRE LA CADENA - LENGTH DETERMMINA EL TAMAÑO DE LA CADENA 
            for (int x = Palabra.Length - 1; x >= 0; x--) { 

                String Resul;  //Variable String - CADENA RESULTANTE DE CARACTERES
                Resul = txtResultado.Text;
                //SE AGREGA CARACTER POR CARACTER AL RESULTADO, INCIANDO DESDE EL ULTIMO CARACTER
                Resul += Palabra[x];
                //ASIGNA EL RESULTADO
                txtResultado.Text = (Resul);


            }
            
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            //Limpiar cajas de texto
            txtPalabra.Clear();
            txtResultado.Clear();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            //Regresar
             ContenidoModulos CModulos = new ContenidoModulos();
              this.Hide();
            CModulos.Show();
        }

        private void modulo4_Load(object sender, EventArgs e)
        {

        }
    }
}
