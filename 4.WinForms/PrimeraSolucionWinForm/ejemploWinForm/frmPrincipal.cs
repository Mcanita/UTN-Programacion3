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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void perfilPersonaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (var item in Application.OpenForms) //para validar que la ventana se abra una sola vez
            {
                if (item.GetType() == typeof(frmPrincipal))
                    MessageBox.Show("ya existe esta ventana abierta, termine de trabajar alli ... ");
                    return;
            }
            frmVentana2 ventana = new frmVentana2(); //con esto creo la ventana y la muestro
            ventana.MdiParent = this;
            ventana.Show();
        }

        private void tsbPerfilPersona_Click(object sender, EventArgs e)
        {
            frmVentana2 ventana = new frmVentana2(); //con esto creo la ventana y la muestro
            ventana.ShowDialog();
        }
    }
}
