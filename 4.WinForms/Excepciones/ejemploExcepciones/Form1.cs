using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejemploExcepciones
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int a, b, r;
            try
            {
                a = int.Parse(txtPrimero.Text);
                b = int.Parse(txtSeguando.Text);
                r = a + b;
                lblResultado.Text = "= " + r;

            }
            catch (FormatException ex)
            {
                MessageBox.Show("por favor cargar solo números ..."); //excepción de formato
            }
            catch(DivideByZeroException ex) //excepción por dividir por cero
            {
                MessageBox.Show("no se puede dividir por cero ");
            }
            catch(OverflowException ex ) // puse un número mas grande de lo que admite un entero
            {
                MessageBox.Show("el número ingresado supera la capacidad de un entero");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());// puedo ver de que tipo es la excepción
            }

        }
    }
}
