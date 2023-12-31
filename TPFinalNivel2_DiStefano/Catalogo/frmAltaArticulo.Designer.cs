
namespace Catalogo
{
    partial class frmAltaArticulo
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
            this.pboxAgregarArticulo = new System.Windows.Forms.PictureBox();
            this.btnAgregarNuevoArticulo = new System.Windows.Forms.Button();
            this.btnCancelarArticulo = new System.Windows.Forms.Button();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblUrlImagen = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtImagenUrl = new System.Windows.Forms.TextBox();
            this.btnAgregarImagen = new System.Windows.Forms.Button();
            this.lblValidacionImagen = new System.Windows.Forms.Label();
            this.lblArchivoImagen = new System.Windows.Forms.Label();
            this.cboxCategoria = new System.Windows.Forms.ComboBox();
            this.cboxMarca = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pboxAgregarArticulo)).BeginInit();
            this.SuspendLayout();
            // 
            // pboxAgregarArticulo
            // 
            this.pboxAgregarArticulo.Location = new System.Drawing.Point(263, 16);
            this.pboxAgregarArticulo.Name = "pboxAgregarArticulo";
            this.pboxAgregarArticulo.Size = new System.Drawing.Size(216, 216);
            this.pboxAgregarArticulo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboxAgregarArticulo.TabIndex = 0;
            this.pboxAgregarArticulo.TabStop = false;
            // 
            // btnAgregarNuevoArticulo
            // 
            this.btnAgregarNuevoArticulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(48)))), ((int)(((byte)(61)))));
            this.btnAgregarNuevoArticulo.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAgregarNuevoArticulo.FlatAppearance.BorderSize = 2;
            this.btnAgregarNuevoArticulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarNuevoArticulo.ForeColor = System.Drawing.Color.White;
            this.btnAgregarNuevoArticulo.Location = new System.Drawing.Point(148, 248);
            this.btnAgregarNuevoArticulo.Name = "btnAgregarNuevoArticulo";
            this.btnAgregarNuevoArticulo.Size = new System.Drawing.Size(75, 28);
            this.btnAgregarNuevoArticulo.TabIndex = 8;
            this.btnAgregarNuevoArticulo.Text = "Agregar";
            this.btnAgregarNuevoArticulo.UseVisualStyleBackColor = false;
            this.btnAgregarNuevoArticulo.Click += new System.EventHandler(this.btnAgregarNuevoArticulo_Click);
            // 
            // btnCancelarArticulo
            // 
            this.btnCancelarArticulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(48)))), ((int)(((byte)(61)))));
            this.btnCancelarArticulo.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnCancelarArticulo.FlatAppearance.BorderSize = 2;
            this.btnCancelarArticulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarArticulo.ForeColor = System.Drawing.Color.White;
            this.btnCancelarArticulo.Location = new System.Drawing.Point(260, 248);
            this.btnCancelarArticulo.Name = "btnCancelarArticulo";
            this.btnCancelarArticulo.Size = new System.Drawing.Size(75, 28);
            this.btnCancelarArticulo.TabIndex = 9;
            this.btnCancelarArticulo.Text = "Cancelar";
            this.btnCancelarArticulo.UseVisualStyleBackColor = false;
            this.btnCancelarArticulo.Click += new System.EventHandler(this.btnCancelarArticulo_Click);
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(82)))));
            this.lblCodigo.ForeColor = System.Drawing.Color.White;
            this.lblCodigo.Location = new System.Drawing.Point(16, 19);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(43, 13);
            this.lblCodigo.TabIndex = 3;
            this.lblCodigo.Text = "Código:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(82)))));
            this.lblNombre.ForeColor = System.Drawing.Color.White;
            this.lblNombre.Location = new System.Drawing.Point(16, 46);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 13);
            this.lblNombre.TabIndex = 4;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(82)))));
            this.lblDescripcion.ForeColor = System.Drawing.Color.White;
            this.lblDescripcion.Location = new System.Drawing.Point(16, 72);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(63, 13);
            this.lblDescripcion.TabIndex = 5;
            this.lblDescripcion.Text = "Descripción";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(82)))));
            this.lblPrecio.ForeColor = System.Drawing.Color.White;
            this.lblPrecio.Location = new System.Drawing.Point(16, 99);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(37, 13);
            this.lblPrecio.TabIndex = 6;
            this.lblPrecio.Text = "Precio";
            // 
            // lblUrlImagen
            // 
            this.lblUrlImagen.AutoSize = true;
            this.lblUrlImagen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(82)))));
            this.lblUrlImagen.ForeColor = System.Drawing.Color.White;
            this.lblUrlImagen.Location = new System.Drawing.Point(16, 126);
            this.lblUrlImagen.Name = "lblUrlImagen";
            this.lblUrlImagen.Size = new System.Drawing.Size(73, 13);
            this.lblUrlImagen.TabIndex = 7;
            this.lblUrlImagen.Text = "Url de Imagen";
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(82)))));
            this.lblCategoria.ForeColor = System.Drawing.Color.White;
            this.lblCategoria.Location = new System.Drawing.Point(16, 184);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(54, 13);
            this.lblCategoria.TabIndex = 8;
            this.lblCategoria.Text = "Categoría";
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(82)))));
            this.lblMarca.ForeColor = System.Drawing.Color.White;
            this.lblMarca.Location = new System.Drawing.Point(16, 214);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(37, 13);
            this.lblMarca.TabIndex = 9;
            this.lblMarca.Text = "Marca";
            // 
            // txtCodigo
            // 
            this.txtCodigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCodigo.Location = new System.Drawing.Point(114, 16);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(140, 20);
            this.txtCodigo.TabIndex = 0;
            // 
            // txtNombre
            // 
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombre.Location = new System.Drawing.Point(114, 43);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(140, 20);
            this.txtNombre.TabIndex = 1;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDescripcion.Location = new System.Drawing.Point(114, 69);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(140, 20);
            this.txtDescripcion.TabIndex = 2;
            // 
            // txtPrecio
            // 
            this.txtPrecio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPrecio.Location = new System.Drawing.Point(114, 96);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(140, 20);
            this.txtPrecio.TabIndex = 3;
            // 
            // txtImagenUrl
            // 
            this.txtImagenUrl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtImagenUrl.Location = new System.Drawing.Point(114, 123);
            this.txtImagenUrl.Name = "txtImagenUrl";
            this.txtImagenUrl.Size = new System.Drawing.Size(140, 20);
            this.txtImagenUrl.TabIndex = 4;
            // 
            // btnAgregarImagen
            // 
            this.btnAgregarImagen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(48)))), ((int)(((byte)(61)))));
            this.btnAgregarImagen.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAgregarImagen.FlatAppearance.BorderSize = 2;
            this.btnAgregarImagen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarImagen.ForeColor = System.Drawing.Color.White;
            this.btnAgregarImagen.Location = new System.Drawing.Point(114, 149);
            this.btnAgregarImagen.Name = "btnAgregarImagen";
            this.btnAgregarImagen.Size = new System.Drawing.Size(140, 25);
            this.btnAgregarImagen.TabIndex = 5;
            this.btnAgregarImagen.Text = "Cargar imagen";
            this.btnAgregarImagen.UseVisualStyleBackColor = false;
            this.btnAgregarImagen.Click += new System.EventHandler(this.btnAgregarImagen_Click);
            // 
            // lblValidacionImagen
            // 
            this.lblValidacionImagen.AutoSize = true;
            this.lblValidacionImagen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(82)))));
            this.lblValidacionImagen.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValidacionImagen.ForeColor = System.Drawing.Color.White;
            this.lblValidacionImagen.Location = new System.Drawing.Point(17, 162);
            this.lblValidacionImagen.Name = "lblValidacionImagen";
            this.lblValidacionImagen.Size = new System.Drawing.Size(68, 12);
            this.lblValidacionImagen.TabIndex = 16;
            this.lblValidacionImagen.Text = ".png, .jpg, .jpeg";
            // 
            // lblArchivoImagen
            // 
            this.lblArchivoImagen.AutoSize = true;
            this.lblArchivoImagen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(82)))));
            this.lblArchivoImagen.ForeColor = System.Drawing.Color.White;
            this.lblArchivoImagen.Location = new System.Drawing.Point(16, 149);
            this.lblArchivoImagen.Name = "lblArchivoImagen";
            this.lblArchivoImagen.Size = new System.Drawing.Size(96, 13);
            this.lblArchivoImagen.TabIndex = 17;
            this.lblArchivoImagen.Text = "Archivo de Imagen";
            // 
            // cboxCategoria
            // 
            this.cboxCategoria.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cboxCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboxCategoria.FormattingEnabled = true;
            this.cboxCategoria.Location = new System.Drawing.Point(114, 180);
            this.cboxCategoria.Name = "cboxCategoria";
            this.cboxCategoria.Size = new System.Drawing.Size(140, 21);
            this.cboxCategoria.TabIndex = 6;
            // 
            // cboxMarca
            // 
            this.cboxMarca.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cboxMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxMarca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboxMarca.FormattingEnabled = true;
            this.cboxMarca.Location = new System.Drawing.Point(114, 211);
            this.cboxMarca.Name = "cboxMarca";
            this.cboxMarca.Size = new System.Drawing.Size(140, 21);
            this.cboxMarca.TabIndex = 7;
            // 
            // frmAltaArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(496, 292);
            this.Controls.Add(this.cboxMarca);
            this.Controls.Add(this.cboxCategoria);
            this.Controls.Add(this.lblArchivoImagen);
            this.Controls.Add(this.lblValidacionImagen);
            this.Controls.Add(this.btnAgregarImagen);
            this.Controls.Add(this.txtImagenUrl);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.lblUrlImagen);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.btnCancelarArticulo);
            this.Controls.Add(this.btnAgregarNuevoArticulo);
            this.Controls.Add(this.pboxAgregarArticulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAltaArticulo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Url de Imagen";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Load += new System.EventHandler(this.frmAltaArticulo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pboxAgregarArticulo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pboxAgregarArticulo;
        private System.Windows.Forms.Button btnAgregarNuevoArticulo;
        private System.Windows.Forms.Button btnCancelarArticulo;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblUrlImagen;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox txtImagenUrl;
        private System.Windows.Forms.Button btnAgregarImagen;
        private System.Windows.Forms.Label lblValidacionImagen;
        private System.Windows.Forms.Label lblArchivoImagen;
        private System.Windows.Forms.ComboBox cboxCategoria;
        private System.Windows.Forms.ComboBox cboxMarca;
    }
}