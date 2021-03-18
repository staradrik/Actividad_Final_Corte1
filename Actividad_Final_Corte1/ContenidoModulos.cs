using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Actividad_Final_Corte1
{
    public partial class ContenidoModulos : Form
    {
        public ContenidoModulos()
        {
            InitializeComponent();
        }

        private void bt_m1_Click(object sender, EventArgs e)
        {
            Modulo1 m1 = new Modulo1();
            this.Hide();
            m1.Show();
        }

        private void btn_m2_Click(object sender, EventArgs e)
        {
            Modulo2 m2 = new Modulo2();
            this.Hide();
            m2.Show();
        }

        private void btn_m3_Click(object sender, EventArgs e)
        {
            Modulo3 m3 = new Modulo3();
            this.Hide();
            m3.Show();
        }

        private void btn_m4_Click(object sender, EventArgs e)
        {
            modulo4 m4 = new modulo4();
            this.Hide();
            m4.Show();
        }

        private void btn_m5_Click(object sender, EventArgs e)
        {
            Modulo5 m5 = new Modulo5();
            this.Hide();
            m5.Show();
        }

        private void btn_m6_Click(object sender, EventArgs e)
        {
            modulo6 m6 = new modulo6();
            this.Hide();
            m6.Show();
        }
    }
}
