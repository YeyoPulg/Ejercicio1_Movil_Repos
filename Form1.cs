using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio1_Móvil
{
    public partial class pnlLogin : Form
    {
        public pnlLogin()
        {
            InitializeComponent();
        }

        private void pnlLogin_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if ((txtUser.Text=="yeyo") && (txtPass.Text=="1234"))
            {
                MessageBox.Show("Sesión iniciada correctamente!!");
                limpiar();
                pnlFunciones funciones = new pnlFunciones();
                funciones.Show();
                this.Hide();
                //Close();
            }
            else
            {
                MessageBox.Show("No se pudo iniciar sesión :(");
                limpiar();
            }
        }

        private void limpiar()
        {
            txtUser.Text = "";
            txtPass.Text = "";
        }
    }
}
