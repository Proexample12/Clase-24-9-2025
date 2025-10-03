namespace Productos.Formularios
{
    partial class FrmArreglo
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
            this.gbEdades = new System.Windows.Forms.GroupBox();
            this.LblPromedio = new System.Windows.Forms.Label();
            this.lbEdades = new System.Windows.Forms.ListBox();
            this.tbEdad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.gbEdades.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbEdades
            // 
            this.gbEdades.Controls.Add(this.btnAgregar);
            this.gbEdades.Controls.Add(this.LblPromedio);
            this.gbEdades.Controls.Add(this.lbEdades);
            this.gbEdades.Controls.Add(this.tbEdad);
            this.gbEdades.Controls.Add(this.label1);
            this.gbEdades.Location = new System.Drawing.Point(12, 12);
            this.gbEdades.Name = "gbEdades";
            this.gbEdades.Size = new System.Drawing.Size(203, 321);
            this.gbEdades.TabIndex = 0;
            this.gbEdades.TabStop = false;
            this.gbEdades.Text = "Edades";
            // 
            // LblPromedio
            // 
            this.LblPromedio.AutoSize = true;
            this.LblPromedio.Location = new System.Drawing.Point(0, 302);
            this.LblPromedio.Name = "LblPromedio";
            this.LblPromedio.Size = new System.Drawing.Size(82, 16);
            this.LblPromedio.TabIndex = 3;
            this.LblPromedio.Text = "Promedio : 0";
            this.LblPromedio.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.LblPromedio.Click += new System.EventHandler(this.LblPromedio_Click);
            // 
            // lbEdades
            // 
            this.lbEdades.FormattingEnabled = true;
            this.lbEdades.ItemHeight = 16;
            this.lbEdades.Location = new System.Drawing.Point(6, 103);
            this.lbEdades.Name = "lbEdades";
            this.lbEdades.Size = new System.Drawing.Size(147, 196);
            this.lbEdades.TabIndex = 2;
            // 
            // tbEdad
            // 
            this.tbEdad.Location = new System.Drawing.Point(57, 39);
            this.tbEdad.Name = "tbEdad";
            this.tbEdad.Size = new System.Drawing.Size(100, 22);
            this.tbEdad.TabIndex = 1;
            this.tbEdad.TextChanged += new System.EventHandler(this.tbEdad_TextChanged);
            this.tbEdad.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbEdad_KeyDown);
            this.tbEdad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbEdad_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Edad:";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(78, 67);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 4;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // FrmArreglo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 475);
            this.Controls.Add(this.gbEdades);
            this.Name = "FrmArreglo";
            this.Text = "Arreglo";
            this.Load += new System.EventHandler(this.FrmArreglo_Load);
            this.gbEdades.ResumeLayout(false);
            this.gbEdades.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbEdades;
        private System.Windows.Forms.TextBox tbEdad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblPromedio;
        private System.Windows.Forms.ListBox lbEdades;
        private System.Windows.Forms.Button btnAgregar;
    }
}