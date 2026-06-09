using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoDAE_Ciclo2
{
    public partial class Form1_LogIn : Form
    {
        public Form1_LogIn()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.ShowDialog();

            this.Close();

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form2_OlvidarContraseña form2 = new Form2_OlvidarContraseña();
            form2.ShowDialog();

            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
