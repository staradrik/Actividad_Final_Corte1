using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Actividad_Final_Corte1
{
    public partial class modulo6 : Form
    {
        public modulo6()
        {
            InitializeComponent();
        }

        private void modulo6_Load(object sender, EventArgs e)
        {

        }

        private void btnSumar_Click(object sender, EventArgs e)
        {
            Double sum = 0; //Variable Double para la suma de espacios
            String numeros; //Variable String 
            numeros = txtNumeros.Text;

            //String.Split separa una cadena en límites de palabras. 
            //También sirve para dividir las cadenas en otras cadenas o caracteres específicos.
            // StringSplitOptions especifican si un elemento contiene una cadena vacía, es decir
            //No está vacío (en realidad es un espacio en blanco )
            //RemoveEmptyEntries Borra las entradas, es decir los espacios

            string[] listanumeros = numeros.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
         
                //CICLO FOR QUE RECORRE LA CADENA - LENGTH DETERMMINA EL TAMAÑO DE LA CADENA 
                for (int i = 0; i < listanumeros.Length; i++)
                {
                    //Se agregan los limetes de cada cadena, separada por espacios y los suma
                    sum += Double.Parse(listanumeros[i]);
                }
                txtRESUL.Text = ("" + sum);
            
           
        }

        private void btnLIMPIAR_Click(object sender, EventArgs e)
        {
            //limpiar cajas de texto
            txtNumeros.Clear();
            txtRESUL.Clear();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        { 
            //Regresar
               ContenidoModulos CModulos = new ContenidoModulos();
              this.Hide();
            CModulos.Show();
        }
    }
}
