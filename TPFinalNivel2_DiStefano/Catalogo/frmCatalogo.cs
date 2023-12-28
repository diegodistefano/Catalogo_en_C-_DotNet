using negocio;
using dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Catalogo
{
    public partial class frmCatalogo : Form
    {
        private List<Articulos> listaArticulos;
        public frmCatalogo()
        {
            InitializeComponent();
        }

        private void frmCatalogo_Load(object sender, EventArgs e)
        {
            cargar();
            ocultarColumnas();
            cargarImagen(listaArticulos[0].ImagenUrl);
        }

        private void cargar()
        {
            ArticulosNegocio negocio = new ArticulosNegocio();
            try
            {
                listaArticulos = negocio.listar();
                dgvCatalogo.DataSource = listaArticulos;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void ocultarColumnas()
        {
            try
            {
                dgvCatalogo.Columns["ImagenUrl"].Visible = false;
                dgvCatalogo.Columns["Id"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void cargarImagen(string imagen)
        {
            try
            {
                pboxCatalogo.Load(imagen);
            }
            catch (Exception ex)
            {
                pboxCatalogo.Load("https://efectocolibri.com/wp-content/uploads/2021/01/placeholder.png");
            }
        }

        private void pboxCatalogo_Click(object sender, EventArgs e)
        {

        }

        private void dgvCatalogo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
