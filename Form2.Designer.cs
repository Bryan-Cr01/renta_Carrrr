
namespace Primera_fachada
{
    partial class Form2
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtvehiculos = new System.Windows.Forms.DataGridView();
            this.Fabricante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estilo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cilindraje = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Caja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Combustion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Capacidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtvehiculos)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Stencil", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(453, 44);
            this.label2.TabIndex = 11;
            this.label2.Text = "Seleccion de vehiculo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("NSimSun", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(502, 24);
            this.label3.TabIndex = 12;
            this.label3.Text = "Ingrese el tipo de Caja de su preferencia";
            // 
            // dtvehiculos
            // 
            this.dtvehiculos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtvehiculos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Fabricante,
            this.Estilo,
            this.Cilindraje,
            this.Caja,
            this.Combustion,
            this.Capacidad});
            this.dtvehiculos.Location = new System.Drawing.Point(12, 143);
            this.dtvehiculos.Name = "dtvehiculos";
            this.dtvehiculos.Size = new System.Drawing.Size(646, 150);
            this.dtvehiculos.TabIndex = 13;
            // 
            // Fabricante
            // 
            this.Fabricante.HeaderText = "Fabricante";
            this.Fabricante.Name = "Fabricante";
            // 
            // Estilo
            // 
            this.Estilo.HeaderText = "Estilo";
            this.Estilo.Name = "Estilo";
            // 
            // Cilindraje
            // 
            this.Cilindraje.HeaderText = "Cilindraje";
            this.Cilindraje.Name = "Cilindraje";
            // 
            // Caja
            // 
            this.Caja.HeaderText = "Tipo Caja";
            this.Caja.Name = "Caja";
            // 
            // Combustion
            // 
            this.Combustion.HeaderText = "Combustion";
            this.Combustion.Name = "Combustion";
            // 
            // Capacidad
            // 
            this.Capacidad.HeaderText = "Capacidad";
            this.Capacidad.Name = "Capacidad";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("NSimSun", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(502, 24);
            this.label1.TabIndex = 14;
            this.label1.Text = "Ingrese el tipo de Caja de su preferencia";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtvehiculos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtvehiculos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dtvehiculos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fabricante;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estilo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cilindraje;
        private System.Windows.Forms.DataGridViewTextBoxColumn Caja;
        private System.Windows.Forms.DataGridViewTextBoxColumn Combustion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Capacidad;
        private System.Windows.Forms.Label label1;
    }
}