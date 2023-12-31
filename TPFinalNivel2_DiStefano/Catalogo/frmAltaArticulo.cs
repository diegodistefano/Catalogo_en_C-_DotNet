using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dominio;
using negocio;
using System.IO;
using System.Configuration;

namespace Catalogo
{
    public partial class frmAltaArticulo : Form
    {
        private Articulos nuevoArticulo = null;
        
        private OpenFileDialog archivo = null;

        public frmAltaArticulo()
        {
            InitializeComponent();
        }
     
        public frmAltaArticulo(Articulos seleccionado)
        {
            InitializeComponent();
            nuevoArticulo = seleccionado;
            Text = "Modificar articulo";
            btnAgregarNuevoArticulo.Text = "Modificar";
        }
        
        private void btnCancelarArticulo_Click(object sender, EventArgs e)
        {
            Close();
        }
        
        private void btnAgregarNuevoArticulo_Click(object sender, EventArgs e)
        {
            ArticulosNegocio negocio = new ArticulosNegocio();

            try
            {
                if (nuevoArticulo == null)
                    nuevoArticulo = new Articulos();

                nuevoArticulo.Codigo = txtCodigo.Text;
                nuevoArticulo.Nombre = txtNombre.Text;
                nuevoArticulo.Descripcion = txtDescripcion.Text;
                nuevoArticulo.ImagenUrl = txtImagenUrl.Text;
                nuevoArticulo.Precio = decimal.Parse(txtPrecio.Text);
                nuevoArticulo.Categoria = (Categorias)cboxCategoria.SelectedItem;
                nuevoArticulo.Marca = (Marcas)cboxMarca.SelectedItem;

                if (nuevoArticulo.Id != 0)
                {
                    negocio.modificar(nuevoArticulo);
                    MessageBox.Show("Artículo modificado");
                }
                else
                {
                    negocio.agregar(nuevoArticulo);
                    MessageBox.Show("Nuevo artículo agregado");
                }

                if (archivo != null && !(txtImagenUrl.Text.ToUpper().Contains("HTTP")))
                {
                    if (txtImagenUrl.Text.ToUpper().Contains("C:"))
                        //guarga la imagen
                        File.Copy(archivo.FileName, ConfigurationManager.AppSettings["catalogo"] + archivo.SafeFileName);
                    else if (string.IsNullOrEmpty(txtImagenUrl.Text))
                        MessageBox.Show("La imagen no fue ingresada");
                }
                else if (string.IsNullOrEmpty(txtImagenUrl.Text))
                    MessageBox.Show("La imagen no fue ingresada");

                Close();
                
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void txtImagenUrl_Leave(object sender, EventArgs e)
        {
            cargarImagen(txtImagenUrl.Text);
        }

        private void cargarImagen(string imagen)
        {
            try
            {
                pboxAgregarArticulo.Load(imagen);
            }
            catch (Exception ex)
            {
                pboxAgregarArticulo.Load("https://efectocolibri.com/wp-content/uploads/2021/01/placeholder.png");
            }
        }

        private void btnAgregarImagen_Click(object sender, EventArgs e)
        {
            archivo = new OpenFileDialog();
            archivo.Filter = "png|*.png|jpeg|*.jpeg|jpg|*.jpg";
            if (archivo.ShowDialog() == DialogResult.OK)
            {
                txtImagenUrl.Text = archivo.FileName;
                cargarImagen(archivo.FileName);
            }
        }
        
        private void frmAltaArticulo_Load(object sender, EventArgs e)
        {
            CategoriasNegocio cateNegocio = new CategoriasNegocio();
            MarcasNegocio marNegocio = new MarcasNegocio();

            try
            {
                cboxCategoria.DataSource = cateNegocio.listar();
                cboxCategoria.ValueMember = "Id";
                cboxCategoria.DisplayMember = "Descripcion";

                cboxMarca.DataSource = marNegocio.listar();
                cboxMarca.ValueMember = "Id";
                cboxMarca.DisplayMember = "Descripcion";

                if (nuevoArticulo != null)
                {
                    txtCodigo.Text = nuevoArticulo.Codigo;
                    txtNombre.Text = nuevoArticulo.Nombre;
                    txtDescripcion.Text = nuevoArticulo.Descripcion;
                    txtImagenUrl.Text = nuevoArticulo.ImagenUrl;
                    txtPrecio.Text = nuevoArticulo.Precio.ToString();
                    cboxCategoria.SelectedValue = nuevoArticulo.Categoria.Id;
                    cboxMarca.SelectedValue = nuevoArticulo.Marca.Id;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnMarcaCategoria_Click(object sender, EventArgs e)
        {
            frmNuevaMarcaCategoria nuevaMarCat = new frmNuevaMarcaCategoria();
            nuevaMarCat.ShowDialog();
        }
    }
}
