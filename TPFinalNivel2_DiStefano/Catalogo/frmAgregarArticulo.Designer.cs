
namespace Catalogo
{
    partial class frmAgregarArticulo
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
            this.btnAceptarAgregarArticulo = new System.Windows.Forms.Button();
            this.btnCancelarArticulo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pboxAgregarArticulo)).BeginInit();
            this.SuspendLayout();
            // 
            // pboxAgregarArticulo
            // 
            this.pboxAgregarArticulo.Location = new System.Drawing.Point(302, 41);
            this.pboxAgregarArticulo.Name = "pboxAgregarArticulo";
            this.pboxAgregarArticulo.Size = new System.Drawing.Size(200, 200);
            this.pboxAgregarArticulo.TabIndex = 0;
            this.pboxAgregarArticulo.TabStop = false;
            // 
            // btnAceptarAgregarArticulo
            // 
            this.btnAceptarAgregarArticulo.Location = new System.Drawing.Point(39, 276);
            this.btnAceptarAgregarArticulo.Name = "btnAceptarAgregarArticulo";
            this.btnAceptarAgregarArticulo.Size = new System.Drawing.Size(75, 23);
            this.btnAceptarAgregarArticulo.TabIndex = 1;
            this.btnAceptarAgregarArticulo.Text = "Aceptar";
            this.btnAceptarAgregarArticulo.UseVisualStyleBackColor = true;
            // 
            // btnCancelarArticulo
            // 
            this.btnCancelarArticulo.Location = new System.Drawing.Point(145, 276);
            this.btnCancelarArticulo.Name = "btnCancelarArticulo";
            this.btnCancelarArticulo.Size = new System.Drawing.Size(75, 23);
            this.btnCancelarArticulo.TabIndex = 2;
            this.btnCancelarArticulo.Text = "Cancelar";
            this.btnCancelarArticulo.UseVisualStyleBackColor = true;
            // 
            // frmAgregarArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 329);
            this.Controls.Add(this.btnCancelarArticulo);
            this.Controls.Add(this.btnAceptarAgregarArticulo);
            this.Controls.Add(this.pboxAgregarArticulo);
            this.Name = "frmAgregarArticulo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar artículo";
            ((System.ComponentModel.ISupportInitialize)(this.pboxAgregarArticulo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pboxAgregarArticulo;
        private System.Windows.Forms.Button btnAceptarAgregarArticulo;
        private System.Windows.Forms.Button btnCancelarArticulo;
    }
}