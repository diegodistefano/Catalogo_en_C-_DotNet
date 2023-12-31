
namespace Catalogo
{
    partial class frmCatalogo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvCatalogo = new System.Windows.Forms.DataGridView();
            this.pboxCatalogo = new System.Windows.Forms.PictureBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnAgregarArticulo = new System.Windows.Forms.Button();
            this.btnEliminarArticulo = new System.Windows.Forms.Button();
            this.cboxCampo = new System.Windows.Forms.ComboBox();
            this.cboxCriterio = new System.Windows.Forms.ComboBox();
            this.lblFiltrarArticulos = new System.Windows.Forms.Label();
            this.lblCampo = new System.Windows.Forms.Label();
            this.lblCriterio = new System.Windows.Forms.Label();
            this.lblFiltro = new System.Windows.Forms.Label();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.btnModificarArticulo = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblDetalleCodigo = new System.Windows.Forms.Label();
            this.lblDetalleMarca = new System.Windows.Forms.Label();
            this.lblDetalleCategoria = new System.Windows.Forms.Label();
            this.lblDetallePrecio = new System.Windows.Forms.Label();
            this.lblDetalleDescripcion = new System.Windows.Forms.Label();
            this.lblDetalleNombre = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCatalogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxCatalogo)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCatalogo
            // 
            this.dgvCatalogo.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(102)))));
            this.dgvCatalogo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCatalogo.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvCatalogo.Location = new System.Drawing.Point(15, 99);
            this.dgvCatalogo.MultiSelect = false;
            this.dgvCatalogo.Name = "dgvCatalogo";
            this.dgvCatalogo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCatalogo.Size = new System.Drawing.Size(660, 420);
            this.dgvCatalogo.TabIndex = 0;
            this.dgvCatalogo.SelectionChanged += new System.EventHandler(this.dgvCatalogo_SelectionChanged);
            // 
            // pboxCatalogo
            // 
            this.pboxCatalogo.Location = new System.Drawing.Point(684, 99);
            this.pboxCatalogo.Name = "pboxCatalogo";
            this.pboxCatalogo.Size = new System.Drawing.Size(213, 257);
            this.pboxCatalogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboxCatalogo.TabIndex = 1;
            this.pboxCatalogo.TabStop = false;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(102)))));
            this.btnBuscar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnBuscar.FlatAppearance.BorderSize = 2;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Location = new System.Drawing.Point(682, 32);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(215, 25);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.Text = "Buscar articulo";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnAgregarArticulo
            // 
            this.btnAgregarArticulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(102)))));
            this.btnAgregarArticulo.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAgregarArticulo.FlatAppearance.BorderSize = 2;
            this.btnAgregarArticulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarArticulo.ForeColor = System.Drawing.Color.White;
            this.btnAgregarArticulo.Location = new System.Drawing.Point(15, 68);
            this.btnAgregarArticulo.Name = "btnAgregarArticulo";
            this.btnAgregarArticulo.Size = new System.Drawing.Size(215, 25);
            this.btnAgregarArticulo.TabIndex = 4;
            this.btnAgregarArticulo.Text = "Agregar artículo";
            this.btnAgregarArticulo.UseVisualStyleBackColor = false;
            this.btnAgregarArticulo.Click += new System.EventHandler(this.btnAgregarArticulo_Click);
            // 
            // btnEliminarArticulo
            // 
            this.btnEliminarArticulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(102)))));
            this.btnEliminarArticulo.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlText;
            this.btnEliminarArticulo.FlatAppearance.BorderSize = 2;
            this.btnEliminarArticulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarArticulo.ForeColor = System.Drawing.Color.White;
            this.btnEliminarArticulo.Location = new System.Drawing.Point(460, 68);
            this.btnEliminarArticulo.Name = "btnEliminarArticulo";
            this.btnEliminarArticulo.Size = new System.Drawing.Size(215, 25);
            this.btnEliminarArticulo.TabIndex = 6;
            this.btnEliminarArticulo.Text = "Eliminar artículo";
            this.btnEliminarArticulo.UseVisualStyleBackColor = false;
            this.btnEliminarArticulo.Click += new System.EventHandler(this.btnEliminarArticulo_Click);
            // 
            // cboxCampo
            // 
            this.cboxCampo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cboxCampo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxCampo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboxCampo.FormattingEnabled = true;
            this.cboxCampo.Location = new System.Drawing.Point(63, 34);
            this.cboxCampo.Name = "cboxCampo";
            this.cboxCampo.Size = new System.Drawing.Size(150, 21);
            this.cboxCampo.TabIndex = 0;
            this.cboxCampo.SelectedIndexChanged += new System.EventHandler(this.cboxCampo_SelectedIndexChanged);
            // 
            // cboxCriterio
            // 
            this.cboxCriterio.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cboxCriterio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxCriterio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboxCriterio.FormattingEnabled = true;
            this.cboxCriterio.Location = new System.Drawing.Point(280, 34);
            this.cboxCriterio.Name = "cboxCriterio";
            this.cboxCriterio.Size = new System.Drawing.Size(150, 21);
            this.cboxCriterio.TabIndex = 1;
            // 
            // lblFiltrarArticulos
            // 
            this.lblFiltrarArticulos.AutoSize = true;
            this.lblFiltrarArticulos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(22)))), ((int)(((byte)(31)))));
            this.lblFiltrarArticulos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiltrarArticulos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblFiltrarArticulos.Location = new System.Drawing.Point(14, 11);
            this.lblFiltrarArticulos.Name = "lblFiltrarArticulos";
            this.lblFiltrarArticulos.Size = new System.Drawing.Size(93, 13);
            this.lblFiltrarArticulos.TabIndex = 13;
            this.lblFiltrarArticulos.Text = "Filtrar artículos";
            // 
            // lblCampo
            // 
            this.lblCampo.AutoSize = true;
            this.lblCampo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(22)))), ((int)(((byte)(31)))));
            this.lblCampo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblCampo.Location = new System.Drawing.Point(18, 37);
            this.lblCampo.Name = "lblCampo";
            this.lblCampo.Size = new System.Drawing.Size(43, 13);
            this.lblCampo.TabIndex = 14;
            this.lblCampo.Text = "Campo:";
            // 
            // lblCriterio
            // 
            this.lblCriterio.AutoSize = true;
            this.lblCriterio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(22)))), ((int)(((byte)(31)))));
            this.lblCriterio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblCriterio.Location = new System.Drawing.Point(235, 37);
            this.lblCriterio.Name = "lblCriterio";
            this.lblCriterio.Size = new System.Drawing.Size(42, 13);
            this.lblCriterio.TabIndex = 15;
            this.lblCriterio.Text = "Criterio:";
            // 
            // lblFiltro
            // 
            this.lblFiltro.AutoSize = true;
            this.lblFiltro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(22)))), ((int)(((byte)(31)))));
            this.lblFiltro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblFiltro.Location = new System.Drawing.Point(456, 38);
            this.lblFiltro.Name = "lblFiltro";
            this.lblFiltro.Size = new System.Drawing.Size(32, 13);
            this.lblFiltro.TabIndex = 16;
            this.lblFiltro.Text = "Filtro:";
            // 
            // txtFiltro
            // 
            this.txtFiltro.BackColor = System.Drawing.Color.White;
            this.txtFiltro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFiltro.ForeColor = System.Drawing.Color.Black;
            this.txtFiltro.Location = new System.Drawing.Point(489, 35);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(150, 20);
            this.txtFiltro.TabIndex = 2;
            // 
            // btnModificarArticulo
            // 
            this.btnModificarArticulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(102)))));
            this.btnModificarArticulo.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlText;
            this.btnModificarArticulo.FlatAppearance.BorderSize = 2;
            this.btnModificarArticulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarArticulo.ForeColor = System.Drawing.Color.White;
            this.btnModificarArticulo.Location = new System.Drawing.Point(238, 68);
            this.btnModificarArticulo.Name = "btnModificarArticulo";
            this.btnModificarArticulo.Size = new System.Drawing.Size(215, 25);
            this.btnModificarArticulo.TabIndex = 17;
            this.btnModificarArticulo.Text = "Modificar artículo";
            this.btnModificarArticulo.UseVisualStyleBackColor = false;
            this.btnModificarArticulo.Click += new System.EventHandler(this.btnModificarArticulo_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(102)))));
            this.btnActualizar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlText;
            this.btnActualizar.FlatAppearance.BorderSize = 2;
            this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizar.ForeColor = System.Drawing.Color.White;
            this.btnActualizar.Location = new System.Drawing.Point(682, 68);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(215, 25);
            this.btnActualizar.TabIndex = 18;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(22)))), ((int)(((byte)(31)))));
            this.lblMarca.ForeColor = System.Drawing.Color.White;
            this.lblMarca.Location = new System.Drawing.Point(681, 479);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(37, 13);
            this.lblMarca.TabIndex = 25;
            this.lblMarca.Text = "Marca";
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(22)))), ((int)(((byte)(31)))));
            this.lblCategoria.ForeColor = System.Drawing.Color.White;
            this.lblCategoria.Location = new System.Drawing.Point(681, 462);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(54, 13);
            this.lblCategoria.TabIndex = 24;
            this.lblCategoria.Text = "Categoría";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(22)))), ((int)(((byte)(31)))));
            this.lblPrecio.ForeColor = System.Drawing.Color.White;
            this.lblPrecio.Location = new System.Drawing.Point(681, 444);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(37, 13);
            this.lblPrecio.TabIndex = 23;
            this.lblPrecio.Text = "Precio";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(22)))), ((int)(((byte)(31)))));
            this.lblDescripcion.ForeColor = System.Drawing.Color.White;
            this.lblDescripcion.Location = new System.Drawing.Point(681, 427);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(63, 13);
            this.lblDescripcion.TabIndex = 22;
            this.lblDescripcion.Text = "Descripción";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(22)))), ((int)(((byte)(31)))));
            this.lblNombre.ForeColor = System.Drawing.Color.White;
            this.lblNombre.Location = new System.Drawing.Point(681, 410);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 13);
            this.lblNombre.TabIndex = 21;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(22)))), ((int)(((byte)(31)))));
            this.lblCodigo.ForeColor = System.Drawing.Color.White;
            this.lblCodigo.Location = new System.Drawing.Point(681, 393);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(43, 13);
            this.lblCodigo.TabIndex = 20;
            this.lblCodigo.Text = "Código:";
            // 
            // lblDetalleCodigo
            // 
            this.lblDetalleCodigo.AutoSize = true;
            this.lblDetalleCodigo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(22)))), ((int)(((byte)(31)))));
            this.lblDetalleCodigo.ForeColor = System.Drawing.Color.White;
            this.lblDetalleCodigo.Location = new System.Drawing.Point(756, 393);
            this.lblDetalleCodigo.Name = "lblDetalleCodigo";
            this.lblDetalleCodigo.Size = new System.Drawing.Size(43, 13);
            this.lblDetalleCodigo.TabIndex = 26;
            this.lblDetalleCodigo.Text = "Código:";
            // 
            // lblDetalleMarca
            // 
            this.lblDetalleMarca.AutoSize = true;
            this.lblDetalleMarca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(22)))), ((int)(((byte)(31)))));
            this.lblDetalleMarca.ForeColor = System.Drawing.Color.White;
            this.lblDetalleMarca.Location = new System.Drawing.Point(756, 479);
            this.lblDetalleMarca.Name = "lblDetalleMarca";
            this.lblDetalleMarca.Size = new System.Drawing.Size(37, 13);
            this.lblDetalleMarca.TabIndex = 31;
            this.lblDetalleMarca.Text = "Marca";
            // 
            // lblDetalleCategoria
            // 
            this.lblDetalleCategoria.AutoSize = true;
            this.lblDetalleCategoria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(22)))), ((int)(((byte)(31)))));
            this.lblDetalleCategoria.ForeColor = System.Drawing.Color.White;
            this.lblDetalleCategoria.Location = new System.Drawing.Point(756, 462);
            this.lblDetalleCategoria.Name = "lblDetalleCategoria";
            this.lblDetalleCategoria.Size = new System.Drawing.Size(54, 13);
            this.lblDetalleCategoria.TabIndex = 30;
            this.lblDetalleCategoria.Text = "Categoría";
            // 
            // lblDetallePrecio
            // 
            this.lblDetallePrecio.AutoSize = true;
            this.lblDetallePrecio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(22)))), ((int)(((byte)(31)))));
            this.lblDetallePrecio.ForeColor = System.Drawing.Color.White;
            this.lblDetallePrecio.Location = new System.Drawing.Point(756, 444);
            this.lblDetallePrecio.Name = "lblDetallePrecio";
            this.lblDetallePrecio.Size = new System.Drawing.Size(37, 13);
            this.lblDetallePrecio.TabIndex = 29;
            this.lblDetallePrecio.Text = "Precio";
            // 
            // lblDetalleDescripcion
            // 
            this.lblDetalleDescripcion.AutoSize = true;
            this.lblDetalleDescripcion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(22)))), ((int)(((byte)(31)))));
            this.lblDetalleDescripcion.ForeColor = System.Drawing.Color.White;
            this.lblDetalleDescripcion.Location = new System.Drawing.Point(756, 427);
            this.lblDetalleDescripcion.Name = "lblDetalleDescripcion";
            this.lblDetalleDescripcion.Size = new System.Drawing.Size(63, 13);
            this.lblDetalleDescripcion.TabIndex = 28;
            this.lblDetalleDescripcion.Text = "Descripción";
            // 
            // lblDetalleNombre
            // 
            this.lblDetalleNombre.AutoSize = true;
            this.lblDetalleNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(22)))), ((int)(((byte)(31)))));
            this.lblDetalleNombre.ForeColor = System.Drawing.Color.White;
            this.lblDetalleNombre.Location = new System.Drawing.Point(756, 410);
            this.lblDetalleNombre.Name = "lblDetalleNombre";
            this.lblDetalleNombre.Size = new System.Drawing.Size(47, 13);
            this.lblDetalleNombre.TabIndex = 27;
            this.lblDetalleNombre.Text = "Nombre:";
            // 
            // frmCatalogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(22)))), ((int)(((byte)(31)))));
            this.ClientSize = new System.Drawing.Size(918, 537);
            this.Controls.Add(this.lblDetalleMarca);
            this.Controls.Add(this.lblDetalleCategoria);
            this.Controls.Add(this.lblDetallePrecio);
            this.Controls.Add(this.lblDetalleDescripcion);
            this.Controls.Add(this.lblDetalleNombre);
            this.Controls.Add(this.lblDetalleCodigo);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnModificarArticulo);
            this.Controls.Add(this.txtFiltro);
            this.Controls.Add(this.lblFiltro);
            this.Controls.Add(this.lblCriterio);
            this.Controls.Add(this.lblCampo);
            this.Controls.Add(this.lblFiltrarArticulos);
            this.Controls.Add(this.cboxCriterio);
            this.Controls.Add(this.cboxCampo);
            this.Controls.Add(this.btnEliminarArticulo);
            this.Controls.Add(this.btnAgregarArticulo);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.pboxCatalogo);
            this.Controls.Add(this.dgvCatalogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmCatalogo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Catálogo";
            this.TransparencyKey = System.Drawing.Color.Maroon;
            this.Load += new System.EventHandler(this.frmCatalogo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCatalogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxCatalogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCatalogo;
        private System.Windows.Forms.PictureBox pboxCatalogo;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnAgregarArticulo;
        private System.Windows.Forms.Button btnEliminarArticulo;
        private System.Windows.Forms.ComboBox cboxCampo;
        private System.Windows.Forms.ComboBox cboxCriterio;
        private System.Windows.Forms.Label lblFiltrarArticulos;
        private System.Windows.Forms.Label lblCampo;
        private System.Windows.Forms.Label lblCriterio;
        private System.Windows.Forms.Label lblFiltro;
        private System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.Button btnModificarArticulo;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblDetalleCodigo;
        private System.Windows.Forms.Label lblDetalleMarca;
        private System.Windows.Forms.Label lblDetalleCategoria;
        private System.Windows.Forms.Label lblDetallePrecio;
        private System.Windows.Forms.Label lblDetalleDescripcion;
        private System.Windows.Forms.Label lblDetalleNombre;
    }
}

