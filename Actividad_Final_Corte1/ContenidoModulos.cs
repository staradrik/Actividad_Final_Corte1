using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Actividad_Final_Corte1
{
    public partial class ContenidoModulos : Form
    {
        public ContenidoModulos()
        {
            InitializeComponent();
        }

        private void btn_modulo1_Click(object sender, EventArgs e)
        {
            Modulo1 md1 = new Modulo1();
            this.Hide();
            md1.Show();
        }

        private void btn_modulo3_Click(object sender, EventArgs e)
        {
            Modulo3 md3 = new Modulo3();
            this.Hide();
            md3.Show();
        }
    }
    }
}
