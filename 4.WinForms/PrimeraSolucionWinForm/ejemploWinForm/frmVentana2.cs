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
    public partial class frmVentana2 : Form
    {
        public frmVentana2()
        {
            InitializeComponent();
        }

        private void frmVentana2_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Buenos días ");

            cboColorFavorito.Items.Add("Rojo");
            cboColorFavorito.Items.Add("Verde");
            cboColorFavorito.Items.Add("Negro");
            cboColorFavorito.Items.Add("Blanco");
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string elem = txtNombre.Text;
            lwElementos.Items.Add(elem);
        }

        private void btnVerPerfil_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            DateTime fecha = dtpFechaNacimiento.Value;
            //operador ternario
            string chocolate = ckbChocolate.Checked == true ? " Le gusta el chocolate " : "no le gusta el chocolate ";
            string tipoChoco;
            if(rbtChocoBlanco.Checked)
                tipoChoco = "Blanco";
            else if (rbtChocoAmargo.Checked)
                tipoChoco = "Amargo";
            else
                tipoChoco = "Negro";

            string colorFavorito = cboColorFavorito.SelectedItem.ToString();
            string numeroFavorito = numNumeroFavorito.Value.ToString();

            string mensaje = nombre + " fecha : " + fecha + " , su color el : " + colorFavorito + " ,es : " + tipoChoco + ", su numero favorito es : " + numeroFavorito;
            MessageBox.Show(mensaje);

        }
    }
}
