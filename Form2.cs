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
    public partial class pnlFunciones : Form
    {
        public pnlFunciones()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnContar_Click(object sender, EventArgs e)
        {
            int espacios = 0;
            string fr;

            for (int i = 0; i < txtFunciones.Text.Length; i++)
            {
                fr = txtFunciones.Text[i].ToString();
                //char fr = txtFunciones.Text[i]; 
                //int f = char.ToLower(fr);

                if (fr == " ")
                {
                    espacios++;
                }
                else
                {
                    MessageBox.Show("No hay espacios o el campo puede estar vacio!");
                    limpiar();
                }
                MessageBox.Show("Cantidad de espacios en la frase: " + espacios.ToString());
                limpiar();
            }
        }

        private void btnConvertir_Click(object sender, EventArgs e)
        {
            float g = float.Parse(this.txtFunciones.Text);
            float resultado = (g * 9 / 5) + 32;
            
            MessageBox.Show("La conversión es: "+ resultado.ToString());
            limpiar();
        }

        private void limpiar()
        {
            txtFunciones.Text = " ";
        }
    }
}
