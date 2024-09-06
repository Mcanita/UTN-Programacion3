using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejemploWinForm
{
    public partial class frmVentana1 : Form // PARTIAL ME PERMITE SEPARAR UNA CLASE EN VARIAS PARTES 
    {
        public frmVentana1()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e) //evento por defecto
        {
            //MessageBox.Show("HOLA MUNDO");
            string texto = txtNombre.Text;
            lblAceptar.Text = "hola " + texto;
        }

        private void frmVentana1_Load(object sender, EventArgs e)// se ejecuta cuando carga el formulario
        {
            MessageBox.Show("Bienvenido...");
        }

        private void frmVentana1_FormClosing(object sender, FormClosingEventArgs e) //se ejecuta al cerrar
        {
            MessageBox.Show("Gracias por usar la app...");
        }
    }
}
