using dominio;
using negocio;
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
    public partial class frmNuevaMarcaCategoria : Form
    {
        private Marcas nuevaMarca = null;
        private Categorias nuevaCategoria = null;

        public frmNuevaMarcaCategoria()
        {
            InitializeComponent();
        }

        private void btnCancelarMarCat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAceptarMarCat_Click(object sender, EventArgs e)
        {
            MarcasNegocio marca = new MarcasNegocio();
            CategoriasNegocio categoria = new CategoriasNegocio();

            try
            {
                if (nuevaMarca == null)
                    nuevaMarca = new Marcas();

                if (nuevaCategoria == null)
                    nuevaCategoria = new Categorias();

                nuevaMarca.Descripcion = txtNuevaMarca.Text;
                nuevaCategoria.Descripcion = txtNuevaCategoria.Text;

                if (!(string.IsNullOrEmpty(txtNuevaMarca.Text)))
                    marca.agregarMarca(nuevaMarca);

                if (!(string.IsNullOrEmpty(txtNuevaCategoria.Text)))
                    categoria.agregarCategoria(nuevaCategoria);


                MessageBox.Show("Ingrese nuevamente el articulo");

                Close();

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

    }
}
