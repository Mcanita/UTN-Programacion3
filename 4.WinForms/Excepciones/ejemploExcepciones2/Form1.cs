using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejemploExcepciones2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int resultado;
            try
            {
                resultado = calcular();

            }
            catch (Exception ex )
            {

                MessageBox.Show("error no reconocido... contactar a tu dev ...");
            }
            finally // se ejecuta siempre con o sin excepciones 
            {

            }
        }

        private int calcular()
        {
            int a, b, r;
            try
            {
                a = int.Parse(txtPrimero.Text);
                b = int.Parse(txtSegundo.Text);
                r = a + b;
                lblCalcular.Text = "= " + r;
                return 1;
            }
            catch (Exception ex )
            {

                throw ex; //devuelve una excepción
            }
        }
    }
}
