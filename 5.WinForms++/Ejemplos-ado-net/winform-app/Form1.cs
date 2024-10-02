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
        private List<Pokemon> listaPokemon;
        public frmPokemones()
        {
            InitializeComponent();
        }

        private void frmPokemones_Load(object sender, EventArgs e)
        {
            PokemonNegocio negocio = new PokemonNegocio();
            // dgvPokemons.DataSource = negocio.listar(); //lista los registros 
            listaPokemon = negocio.listar();
            dgvPokemons.DataSource = listaPokemon;
            pbxPokemon.Load(listaPokemon[0].UrlImagen);
           

        }
         
        private void dgvPokemons_SelectionChanged(object sender, EventArgs e)
        {
           Pokemon seleccionado =(Pokemon) dgvPokemons.CurrentRow.DataBoundItem;
            pbxPokemon.Load(seleccionado.UrlImagen);
        }
    }
}
