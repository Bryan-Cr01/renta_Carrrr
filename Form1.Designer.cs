
namespace Primera_fachada
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnbusqueda = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.btnsalir = new System.Windows.Forms.Button();
            this.txtdireccion = new System.Windows.Forms.TextBox();
            this.txttelefono = new System.Windows.Forms.TextBox();
            this.txtcorreo = new System.Windows.Forms.TextBox();
            this.txttarjeta = new System.Windows.Forms.TextBox();
            this.btntarjeta = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblnombre = new System.Windows.Forms.Label();
            this.lbltelefono = new System.Windows.Forms.Label();
            this.lbldireccion = new System.Windows.Forms.Label();
            this.lblcorreo = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txttarjeta1 = new System.Windows.Forms.TextBox();
            this.btntarjeta1 = new System.Windows.Forms.Button();
            this.pic1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnbusqueda
            // 
            this.btnbusqueda.Font = new System.Drawing.Font("MS Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbusqueda.Location = new System.Drawing.Point(303, 22);
            this.btnbusqueda.Name = "btnbusqueda";
            this.btnbusqueda.Size = new System.Drawing.Size(75, 23);
            this.btnbusqueda.TabIndex = 0;
            this.btnbusqueda.Text = "Buscar";
            this.btnbusqueda.UseVisualStyleBackColor = true;
            this.btnbusqueda.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "Identificación";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(164, 22);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(130, 28);
            this.txtid.TabIndex = 2;
            this.txtid.TextChanged += new System.EventHandler(this.txtid_TextChanged);
            // 
            // txtnombre
            // 
            this.txtnombre.Enabled = false;
            this.txtnombre.Location = new System.Drawing.Point(116, 110);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(239, 28);
            this.txtnombre.TabIndex = 3;
            this.txtnombre.Visible = false;
            // 
            // btnsalir
            // 
            this.btnsalir.Location = new System.Drawing.Point(678, 336);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(75, 23);
            this.btnsalir.TabIndex = 4;
            this.btnsalir.Text = "Salir";
            this.btnsalir.UseVisualStyleBackColor = true;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // txtdireccion
            // 
            this.txtdireccion.Enabled = false;
            this.txtdireccion.Location = new System.Drawing.Point(116, 144);
            this.txtdireccion.Name = "txtdireccion";
            this.txtdireccion.Size = new System.Drawing.Size(239, 28);
            this.txtdireccion.TabIndex = 5;
            this.txtdireccion.Visible = false;
            // 
            // txttelefono
            // 
            this.txttelefono.Enabled = false;
            this.txttelefono.Location = new System.Drawing.Point(468, 104);
            this.txttelefono.Name = "txttelefono";
            this.txttelefono.Size = new System.Drawing.Size(100, 28);
            this.txttelefono.TabIndex = 6;
            this.txttelefono.Visible = false;
            // 
            // txtcorreo
            // 
            this.txtcorreo.Enabled = false;
            this.txtcorreo.Location = new System.Drawing.Point(468, 138);
            this.txtcorreo.Name = "txtcorreo";
            this.txtcorreo.Size = new System.Drawing.Size(201, 28);
            this.txtcorreo.TabIndex = 7;
            this.txtcorreo.Visible = false;
            // 
            // txttarjeta
            // 
            this.txttarjeta.Location = new System.Drawing.Point(205, 178);
            this.txttarjeta.Name = "txttarjeta";
            this.txttarjeta.Size = new System.Drawing.Size(203, 28);
            this.txttarjeta.TabIndex = 8;
            this.txttarjeta.Visible = false;
            // 
            // btntarjeta
            // 
            this.btntarjeta.Location = new System.Drawing.Point(416, 179);
            this.btntarjeta.Name = "btntarjeta";
            this.btntarjeta.Size = new System.Drawing.Size(75, 27);
            this.btntarjeta.TabIndex = 9;
            this.btntarjeta.Text = "Registrar Tarjeta";
            this.btntarjeta.UseVisualStyleBackColor = true;
            this.btntarjeta.Visible = false;
            this.btntarjeta.Click += new System.EventHandler(this.btntarjeta_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Stencil", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(380, 44);
            this.label2.TabIndex = 10;
            this.label2.Text = "Registro de Renta";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("NSimSun", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(-1, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(754, 24);
            this.label3.TabIndex = 11;
            this.label3.Text = "Para iniciar el registro ingrese la identifacación del cliente";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pic1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lblcorreo);
            this.groupBox1.Controls.Add(this.lbldireccion);
            this.groupBox1.Controls.Add(this.lbltelefono);
            this.groupBox1.Controls.Add(this.lblnombre);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtid);
            this.groupBox1.Controls.Add(this.btnbusqueda);
            this.groupBox1.Controls.Add(this.btntarjeta);
            this.groupBox1.Controls.Add(this.txtnombre);
            this.groupBox1.Controls.Add(this.txttarjeta);
            this.groupBox1.Controls.Add(this.txtdireccion);
            this.groupBox1.Controls.Add(this.txtcorreo);
            this.groupBox1.Controls.Add(this.txttelefono);
            this.groupBox1.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(14, 80);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(722, 212);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Personales";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lblnombre
            // 
            this.lblnombre.AutoSize = true;
            this.lblnombre.Font = new System.Drawing.Font("Yu Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnombre.Location = new System.Drawing.Point(6, 112);
            this.lblnombre.Name = "lblnombre";
            this.lblnombre.Size = new System.Drawing.Size(92, 27);
            this.lblnombre.TabIndex = 10;
            this.lblnombre.Text = "Nombre";
            this.lblnombre.Visible = false;
            // 
            // lbltelefono
            // 
            this.lbltelefono.AutoSize = true;
            this.lbltelefono.Font = new System.Drawing.Font("Yu Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltelefono.Location = new System.Drawing.Point(363, 108);
            this.lbltelefono.Name = "lbltelefono";
            this.lbltelefono.Size = new System.Drawing.Size(99, 27);
            this.lbltelefono.TabIndex = 11;
            this.lbltelefono.Text = "Teléfono";
            this.lbltelefono.Visible = false;
            // 
            // lbldireccion
            // 
            this.lbldireccion.AutoSize = true;
            this.lbldireccion.Font = new System.Drawing.Font("Yu Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldireccion.Location = new System.Drawing.Point(6, 149);
            this.lbldireccion.Name = "lbldireccion";
            this.lbldireccion.Size = new System.Drawing.Size(109, 27);
            this.lbldireccion.TabIndex = 12;
            this.lbldireccion.Text = "Dirección";
            this.lbldireccion.Visible = false;
            // 
            // lblcorreo
            // 
            this.lblcorreo.AutoSize = true;
            this.lblcorreo.Font = new System.Drawing.Font("Yu Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcorreo.Location = new System.Drawing.Point(364, 144);
            this.lblcorreo.Name = "lblcorreo";
            this.lblcorreo.Size = new System.Drawing.Size(79, 27);
            this.lblcorreo.TabIndex = 13;
            this.lblcorreo.Text = "Correo";
            this.lblcorreo.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Yu Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(196, 27);
            this.label4.TabIndex = 14;
            this.label4.Text = "Numero de tarjeta";
            this.label4.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("NSimSun", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 295);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(694, 24);
            this.label5.TabIndex = 13;
            this.label5.Text = "Si desea Rentar sin registrarse ingrese número de tarjeta";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Yu Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(9, 336);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(196, 27);
            this.label6.TabIndex = 15;
            this.label6.Text = "Numero de tarjeta";
            // 
            // txttarjeta1
            // 
            this.txttarjeta1.Location = new System.Drawing.Point(211, 336);
            this.txttarjeta1.Name = "txttarjeta1";
            this.txttarjeta1.Size = new System.Drawing.Size(203, 20);
            this.txttarjeta1.TabIndex = 15;
            // 
            // btntarjeta1
            // 
            this.btntarjeta1.Location = new System.Drawing.Point(430, 329);
            this.btntarjeta1.Name = "btntarjeta1";
            this.btntarjeta1.Size = new System.Drawing.Size(75, 27);
            this.btntarjeta1.TabIndex = 15;
            this.btntarjeta1.Text = "Registrar Tarjeta";
            this.btntarjeta1.UseVisualStyleBackColor = true;
            this.btntarjeta1.Click += new System.EventHandler(this.btntarjeta1_Click);
            // 
            // pic1
            // 
            this.pic1.Image = ((System.Drawing.Image)(resources.GetObject("pic1.Image")));
            this.pic1.Location = new System.Drawing.Point(412, 19);
            this.pic1.Name = "pic1";
            this.pic1.Size = new System.Drawing.Size(97, 79);
            this.pic1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic1.TabIndex = 15;
            this.pic1.TabStop = false;
            this.pic1.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(538, 336);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 368);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btntarjeta1);
            this.Controls.Add(this.txttarjeta1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnsalir);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnbusqueda;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.Button btnsalir;
        private System.Windows.Forms.TextBox txtdireccion;
        private System.Windows.Forms.TextBox txttelefono;
        private System.Windows.Forms.TextBox txtcorreo;
        private System.Windows.Forms.TextBox txttarjeta;
        private System.Windows.Forms.Button btntarjeta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblnombre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblcorreo;
        private System.Windows.Forms.Label lbldireccion;
        private System.Windows.Forms.Label lbltelefono;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txttarjeta1;
        private System.Windows.Forms.PictureBox pic1;
        private System.Windows.Forms.Button btntarjeta1;
        private System.Windows.Forms.Button button1;
    }
}

