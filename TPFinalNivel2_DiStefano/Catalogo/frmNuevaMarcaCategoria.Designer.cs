
namespace Catalogo
{
    partial class frmNuevaMarcaCategoria
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
            this.lblNuevaMarca = new System.Windows.Forms.Label();
            this.lblNuevaCategoria = new System.Windows.Forms.Label();
            this.txtNuevaMarca = new System.Windows.Forms.TextBox();
            this.txtNuevaCategoria = new System.Windows.Forms.TextBox();
            this.btnAceptarMarCat = new System.Windows.Forms.Button();
            this.btnCancelarMarCat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNuevaMarca
            // 
            this.lblNuevaMarca.AutoSize = true;
            this.lblNuevaMarca.Location = new System.Drawing.Point(16, 17);
            this.lblNuevaMarca.Name = "lblNuevaMarca";
            this.lblNuevaMarca.Size = new System.Drawing.Size(72, 13);
            this.lblNuevaMarca.TabIndex = 0;
            this.lblNuevaMarca.Text = "Nueva Marca";
            // 
            // lblNuevaCategoria
            // 
            this.lblNuevaCategoria.AutoSize = true;
            this.lblNuevaCategoria.Location = new System.Drawing.Point(16, 46);
            this.lblNuevaCategoria.Name = "lblNuevaCategoria";
            this.lblNuevaCategoria.Size = new System.Drawing.Size(87, 13);
            this.lblNuevaCategoria.TabIndex = 1;
            this.lblNuevaCategoria.Text = "Nueva Categoria";
            // 
            // txtNuevaMarca
            // 
            this.txtNuevaMarca.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNuevaMarca.Location = new System.Drawing.Point(113, 14);
            this.txtNuevaMarca.Name = "txtNuevaMarca";
            this.txtNuevaMarca.Size = new System.Drawing.Size(100, 20);
            this.txtNuevaMarca.TabIndex = 2;
            // 
            // txtNuevaCategoria
            // 
            this.txtNuevaCategoria.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNuevaCategoria.Location = new System.Drawing.Point(113, 43);
            this.txtNuevaCategoria.Name = "txtNuevaCategoria";
            this.txtNuevaCategoria.Size = new System.Drawing.Size(100, 20);
            this.txtNuevaCategoria.TabIndex = 3;
            // 
            // btnAceptarMarCat
            // 
            this.btnAceptarMarCat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(48)))), ((int)(((byte)(61)))));
            this.btnAceptarMarCat.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAceptarMarCat.FlatAppearance.BorderSize = 2;
            this.btnAceptarMarCat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptarMarCat.Location = new System.Drawing.Point(19, 84);
            this.btnAceptarMarCat.Name = "btnAceptarMarCat";
            this.btnAceptarMarCat.Size = new System.Drawing.Size(75, 25);
            this.btnAceptarMarCat.TabIndex = 4;
            this.btnAceptarMarCat.Text = "Aceptar";
            this.btnAceptarMarCat.UseVisualStyleBackColor = false;
            this.btnAceptarMarCat.Click += new System.EventHandler(this.btnAceptarMarCat_Click);
            // 
            // btnCancelarMarCat
            // 
            this.btnCancelarMarCat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(48)))), ((int)(((byte)(61)))));
            this.btnCancelarMarCat.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnCancelarMarCat.FlatAppearance.BorderSize = 2;
            this.btnCancelarMarCat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarMarCat.Location = new System.Drawing.Point(138, 84);
            this.btnCancelarMarCat.Name = "btnCancelarMarCat";
            this.btnCancelarMarCat.Size = new System.Drawing.Size(75, 25);
            this.btnCancelarMarCat.TabIndex = 5;
            this.btnCancelarMarCat.Text = "Cancelar";
            this.btnCancelarMarCat.UseVisualStyleBackColor = false;
            this.btnCancelarMarCat.Click += new System.EventHandler(this.btnCancelarMarCat_Click);
            // 
            // frmNuevaMarcaCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(90)))), ((int)(((byte)(122)))));
            this.ClientSize = new System.Drawing.Size(226, 125);
            this.Controls.Add(this.btnCancelarMarCat);
            this.Controls.Add(this.btnAceptarMarCat);
            this.Controls.Add(this.txtNuevaCategoria);
            this.Controls.Add(this.txtNuevaMarca);
            this.Controls.Add(this.lblNuevaCategoria);
            this.Controls.Add(this.lblNuevaMarca);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmNuevaMarcaCategoria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmNuevaMarcaCategoria";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNuevaMarca;
        private System.Windows.Forms.Label lblNuevaCategoria;
        private System.Windows.Forms.TextBox txtNuevaMarca;
        private System.Windows.Forms.TextBox txtNuevaCategoria;
        private System.Windows.Forms.Button btnAceptarMarCat;
        private System.Windows.Forms.Button btnCancelarMarCat;
    }
}