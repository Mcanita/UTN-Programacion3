using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winform_app
{
    public partial class frmPokemones : Form
    {
        public frmPokemones()
        {
            InitializeComponent();
        }

        private void frmPokemones_Load(object sender, EventArgs e)
        {
            PokemonNegocio negocio = new PokemonNegocio();
            dgvPokemons.DataSource = negocio.listar(); //lista los registros 

        }
    }
}
