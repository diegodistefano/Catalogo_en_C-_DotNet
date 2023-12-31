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
            
            cboxCampo.Items.Add("Codigo");
            cboxCampo.Items.Add("Nombre");
            cboxCampo.Items.Add("Precio");
            cboxCampo.Items.Add("Categoria");
            cboxCampo.Items.Add("Marca");
        }

        private void dgvCatalogo_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvCatalogo.CurrentRow != null)
            {
                Articulos seleccionado = (Articulos)dgvCatalogo.CurrentRow.DataBoundItem;
                cargarImagen(seleccionado.ImagenUrl);

                lblDetalleCodigo.Text = seleccionado.Codigo;
                lblDetalleNombre.Text = seleccionado.Nombre;
                lblDetalleDescripcion.Text = seleccionado.Descripcion;
                lblDetallePrecio.Text = seleccionado.Precio.ToString();
                lblDetalleCategoria.Text = seleccionado.Categoria.ToString();
                lblDetalleMarca.Text = seleccionado.Marca.ToString();

            }
        }

        private void cargar()
        {
            ArticulosNegocio negocio = new ArticulosNegocio();
            try
            {
                listaArticulos = negocio.listar();
                dgvCatalogo.DataSource = listaArticulos;
                ocultarColumnas();
                cargarImagen(listaArticulos[0].ImagenUrl);
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

        private bool validarFiltro()
        {
            if (cboxCampo.SelectedIndex < 0)
            {
                MessageBox.Show("Seleccione un campo");
                return true;
            }
            if (cboxCriterio.SelectedIndex < 0)
            {
                MessageBox.Show("Seleccione un criterio");
                return true;
            }

            if (cboxCampo.SelectedItem.ToString() == "Precio")
            {
                if (string.IsNullOrEmpty(txtFiltro.Text))
                {
                    MessageBox.Show("Ingrese un valor numerico de este ejemplo: 99.99");
                    return true;
                }
                if (!(soloPlata(txtFiltro.Text)))
                {
                    MessageBox.Show("Ingrese un valor numerico de este ejemplo: 99.99");
                    return true;
                }
            }

            return false;
        }

        private bool soloPlata(string cadena)
        {
            foreach (char caracter in cadena)
            {
                if (!(char.IsNumber(caracter)))
                {
                    return false;
                }
            }
            return true;
        }


        private void btnAgregarArticulo_Click(object sender, EventArgs e)
        {
            frmAltaArticulo alta = new frmAltaArticulo();
            alta.ShowDialog();
            cargar();
        }

        private void btnModificarArticulo_Click(object sender, EventArgs e)
        {
            {
                Articulos seleccionado;

                seleccionado = (Articulos)dgvCatalogo.CurrentRow.DataBoundItem;

                frmAltaArticulo modificarArticulo = new frmAltaArticulo(seleccionado);
                modificarArticulo.ShowDialog();
                cargar();
            }
        }

        private void btnEliminarArticulo_Click(object sender, EventArgs e)
        {
            ArticulosNegocio negocio = new ArticulosNegocio();
            Articulos seleccionado;

            try
            {
                DialogResult respuesta = MessageBox.Show("Esta seguro que desea eliminar este artículo? (Esta opción no puede deshacerse)", "Eliminando", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (respuesta == DialogResult.Yes)
                {
                    seleccionado = (Articulos)dgvCatalogo.CurrentRow.DataBoundItem;
                    negocio.eliminar(seleccionado.Id);

                    cargar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                cargar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }


        private void btnBuscar_Click(object sender, EventArgs e)
        {
            ArticulosNegocio negocio = new ArticulosNegocio();

            try
            {
                validarFiltro();
                string campo = cboxCampo.SelectedItem.ToString();
                string criterio = cboxCriterio.SelectedItem.ToString();
                string filtro = txtFiltro.Text;
                dgvCatalogo.DataSource = negocio.filtrar(campo, criterio, filtro);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            List<Articulos> listaFiltrada;
            string filtro = txtFiltro.Text;

            if (filtro != "")
            {
                listaFiltrada = listaArticulos.FindAll(x => x.Nombre.ToUpper().Contains(filtro.ToUpper()) || x.Codigo.ToUpper().Contains(filtro.ToUpper()) || x.Descripcion.ToUpper().Contains(filtro.ToUpper()));
            }
            else
            {
                listaFiltrada = listaArticulos;
            }

            dgvCatalogo.DataSource = null;
            dgvCatalogo.DataSource = listaFiltrada;

            ocultarColumnas();
        }

        private void cboxCampo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string opcion = cboxCampo.SelectedItem.ToString();

            if (opcion == "Precio")
            {
                cboxCriterio.Items.Clear();
                cboxCriterio.Items.Add("Mayor a:");
                cboxCriterio.Items.Add("Menor a:");
                cboxCriterio.Items.Add("Igual a:");
            }
            else
            {
                cboxCriterio.Items.Clear();
                cboxCriterio.Items.Add("Comienza con:");
                cboxCriterio.Items.Add("Termina con:");
                cboxCriterio.Items.Add("Contiene:");
            }
        }

    }
}
