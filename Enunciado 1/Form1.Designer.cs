namespace Enunciado_1
{
    partial class Registro
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registro));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabDueño = new System.Windows.Forms.TabPage();
            this.btnRegistrarD = new System.Windows.Forms.Button();
            this.btnCancelarD = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.lblApellidos = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.tabMascota = new System.Windows.Forms.TabPage();
            this.btnMascotaRegistrar = new System.Windows.Forms.Button();
            this.btnMascotaCancelar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbEdadUnidad = new System.Windows.Forms.ComboBox();
            this.cmbDueño = new System.Windows.Forms.ComboBox();
            this.lblDueño = new System.Windows.Forms.Label();
            this.txtRaza = new System.Windows.Forms.TextBox();
            this.lblRaza = new System.Windows.Forms.Label();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.lblEdad = new System.Windows.Forms.Label();
            this.txtMascotaNombre = new System.Windows.Forms.TextBox();
            this.lblMascotaNombre = new System.Windows.Forms.Label();
            this.tabBuscar = new System.Windows.Forms.TabPage();
            this.pnlBuscar = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.registroBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabControl1.SuspendLayout();
            this.tabDueño.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabMascota.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabBuscar.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.registroBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabDueño);
            this.tabControl1.Controls.Add(this.tabMascota);
            this.tabControl1.Controls.Add(this.tabBuscar);
            this.tabControl1.Location = new System.Drawing.Point(27, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(751, 426);
            this.tabControl1.TabIndex = 0;
            // 
            // tabDueño
            // 
            this.tabDueño.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.tabDueño.Controls.Add(this.btnRegistrarD);
            this.tabDueño.Controls.Add(this.btnCancelarD);
            this.tabDueño.Controls.Add(this.groupBox1);
            this.tabDueño.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.tabDueño.Location = new System.Drawing.Point(4, 22);
            this.tabDueño.Name = "tabDueño";
            this.tabDueño.Padding = new System.Windows.Forms.Padding(3);
            this.tabDueño.Size = new System.Drawing.Size(743, 400);
            this.tabDueño.TabIndex = 0;
            this.tabDueño.Text = "Registrar dueño";
            // 
            // btnRegistrarD
            // 
            this.btnRegistrarD.BackColor = System.Drawing.Color.Blue;
            this.btnRegistrarD.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarD.ForeColor = System.Drawing.Color.White;
            this.btnRegistrarD.Location = new System.Drawing.Point(427, 280);
            this.btnRegistrarD.Name = "btnRegistrarD";
            this.btnRegistrarD.Size = new System.Drawing.Size(209, 54);
            this.btnRegistrarD.TabIndex = 7;
            this.btnRegistrarD.Text = "Registrar";
            this.btnRegistrarD.UseVisualStyleBackColor = false;
            this.btnRegistrarD.Click += new System.EventHandler(this.btnRegistrarD_Click);
            // 
            // btnCancelarD
            // 
            this.btnCancelarD.BackColor = System.Drawing.Color.DarkGray;
            this.btnCancelarD.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarD.ForeColor = System.Drawing.Color.White;
            this.btnCancelarD.Location = new System.Drawing.Point(88, 280);
            this.btnCancelarD.Name = "btnCancelarD";
            this.btnCancelarD.Size = new System.Drawing.Size(209, 54);
            this.btnCancelarD.TabIndex = 8;
            this.btnCancelarD.Text = "Cancelar";
            this.btnCancelarD.UseVisualStyleBackColor = false;
            this.btnCancelarD.Click += new System.EventHandler(this.btnCancelarD_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Info;
            this.groupBox1.Controls.Add(this.txtTelefono);
            this.groupBox1.Controls.Add(this.lblTelefono);
            this.groupBox1.Controls.Add(this.txtDireccion);
            this.groupBox1.Controls.Add(this.lblDireccion);
            this.groupBox1.Controls.Add(this.txtApellidos);
            this.groupBox1.Controls.Add(this.lblApellidos);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.lblNombre);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Location = new System.Drawing.Point(36, 47);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(673, 187);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del dueño:";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefono.Location = new System.Drawing.Point(181, 141);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(371, 22);
            this.txtTelefono.TabIndex = 6;
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefono.Location = new System.Drawing.Point(49, 144);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(64, 16);
            this.lblTelefono.TabIndex = 5;
            this.lblTelefono.Text = "Teléfono:";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDireccion.Location = new System.Drawing.Point(181, 106);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(371, 22);
            this.txtDireccion.TabIndex = 4;
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccion.Location = new System.Drawing.Point(49, 109);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(67, 16);
            this.lblDireccion.TabIndex = 3;
            this.lblDireccion.Text = "Dirección:";
            // 
            // txtApellidos
            // 
            this.txtApellidos.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellidos.Location = new System.Drawing.Point(181, 73);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(371, 22);
            this.txtApellidos.TabIndex = 2;
            // 
            // lblApellidos
            // 
            this.lblApellidos.AutoSize = true;
            this.lblApellidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellidos.Location = new System.Drawing.Point(49, 76);
            this.lblApellidos.Name = "lblApellidos";
            this.lblApellidos.Size = new System.Drawing.Size(67, 16);
            this.lblApellidos.TabIndex = 2;
            this.lblApellidos.Text = "Apellidos:";
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(181, 40);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(371, 22);
            this.txtNombre.TabIndex = 1;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(49, 43);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(59, 16);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre:";
            // 
            // tabMascota
            // 
            this.tabMascota.Controls.Add(this.btnMascotaRegistrar);
            this.tabMascota.Controls.Add(this.btnMascotaCancelar);
            this.tabMascota.Controls.Add(this.groupBox2);
            this.tabMascota.Location = new System.Drawing.Point(4, 22);
            this.tabMascota.Name = "tabMascota";
            this.tabMascota.Padding = new System.Windows.Forms.Padding(3);
            this.tabMascota.Size = new System.Drawing.Size(743, 400);
            this.tabMascota.TabIndex = 1;
            this.tabMascota.Text = "Registrar mascota";
            this.tabMascota.UseVisualStyleBackColor = true;
            // 
            // btnMascotaRegistrar
            // 
            this.btnMascotaRegistrar.BackColor = System.Drawing.Color.Blue;
            this.btnMascotaRegistrar.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMascotaRegistrar.ForeColor = System.Drawing.Color.White;
            this.btnMascotaRegistrar.Location = new System.Drawing.Point(417, 279);
            this.btnMascotaRegistrar.Name = "btnMascotaRegistrar";
            this.btnMascotaRegistrar.Size = new System.Drawing.Size(209, 54);
            this.btnMascotaRegistrar.TabIndex = 10;
            this.btnMascotaRegistrar.Text = "Registrar";
            this.btnMascotaRegistrar.UseVisualStyleBackColor = false;
            this.btnMascotaRegistrar.Click += new System.EventHandler(this.btnMascotaRegistrar_Click);
            // 
            // btnMascotaCancelar
            // 
            this.btnMascotaCancelar.BackColor = System.Drawing.Color.DarkGray;
            this.btnMascotaCancelar.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMascotaCancelar.ForeColor = System.Drawing.Color.White;
            this.btnMascotaCancelar.Location = new System.Drawing.Point(86, 279);
            this.btnMascotaCancelar.Name = "btnMascotaCancelar";
            this.btnMascotaCancelar.Size = new System.Drawing.Size(209, 54);
            this.btnMascotaCancelar.TabIndex = 9;
            this.btnMascotaCancelar.Text = "Cancelar";
            this.btnMascotaCancelar.UseVisualStyleBackColor = false;
            this.btnMascotaCancelar.Click += new System.EventHandler(this.btnMascotaCancelar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.groupBox2.Controls.Add(this.cmbEdadUnidad);
            this.groupBox2.Controls.Add(this.cmbDueño);
            this.groupBox2.Controls.Add(this.lblDueño);
            this.groupBox2.Controls.Add(this.txtRaza);
            this.groupBox2.Controls.Add(this.lblRaza);
            this.groupBox2.Controls.Add(this.txtEdad);
            this.groupBox2.Controls.Add(this.lblEdad);
            this.groupBox2.Controls.Add(this.txtMascotaNombre);
            this.groupBox2.Controls.Add(this.lblMascotaNombre);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox2.Location = new System.Drawing.Point(34, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(673, 187);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos de la mascota:";
            // 
            // cmbEdadUnidad
            // 
            this.cmbEdadUnidad.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEdadUnidad.FormattingEnabled = true;
            this.cmbEdadUnidad.Location = new System.Drawing.Point(493, 74);
            this.cmbEdadUnidad.Name = "cmbEdadUnidad";
            this.cmbEdadUnidad.Size = new System.Drawing.Size(121, 23);
            this.cmbEdadUnidad.TabIndex = 7;
            // 
            // cmbDueño
            // 
            this.cmbDueño.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDueño.FormattingEnabled = true;
            this.cmbDueño.Location = new System.Drawing.Point(181, 144);
            this.cmbDueño.Name = "cmbDueño";
            this.cmbDueño.Size = new System.Drawing.Size(371, 23);
            this.cmbDueño.TabIndex = 6;
            // 
            // lblDueño
            // 
            this.lblDueño.AutoSize = true;
            this.lblDueño.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDueño.Location = new System.Drawing.Point(49, 144);
            this.lblDueño.Name = "lblDueño";
            this.lblDueño.Size = new System.Drawing.Size(50, 16);
            this.lblDueño.TabIndex = 5;
            this.lblDueño.Text = "Dueño:";
            // 
            // txtRaza
            // 
            this.txtRaza.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRaza.Location = new System.Drawing.Point(181, 106);
            this.txtRaza.Name = "txtRaza";
            this.txtRaza.Size = new System.Drawing.Size(371, 22);
            this.txtRaza.TabIndex = 4;
            // 
            // lblRaza
            // 
            this.lblRaza.AutoSize = true;
            this.lblRaza.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRaza.Location = new System.Drawing.Point(49, 109);
            this.lblRaza.Name = "lblRaza";
            this.lblRaza.Size = new System.Drawing.Size(42, 16);
            this.lblRaza.TabIndex = 3;
            this.lblRaza.Text = "Raza:";
            // 
            // txtEdad
            // 
            this.txtEdad.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEdad.Location = new System.Drawing.Point(181, 73);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(293, 22);
            this.txtEdad.TabIndex = 2;
            // 
            // lblEdad
            // 
            this.lblEdad.AutoSize = true;
            this.lblEdad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEdad.Location = new System.Drawing.Point(49, 76);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(43, 16);
            this.lblEdad.TabIndex = 2;
            this.lblEdad.Text = "Edad:";
            // 
            // txtMascotaNombre
            // 
            this.txtMascotaNombre.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMascotaNombre.Location = new System.Drawing.Point(181, 40);
            this.txtMascotaNombre.Name = "txtMascotaNombre";
            this.txtMascotaNombre.Size = new System.Drawing.Size(371, 22);
            this.txtMascotaNombre.TabIndex = 1;
            // 
            // lblMascotaNombre
            // 
            this.lblMascotaNombre.AutoSize = true;
            this.lblMascotaNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMascotaNombre.Location = new System.Drawing.Point(49, 43);
            this.lblMascotaNombre.Name = "lblMascotaNombre";
            this.lblMascotaNombre.Size = new System.Drawing.Size(59, 16);
            this.lblMascotaNombre.TabIndex = 0;
            this.lblMascotaNombre.Text = "Nombre:";
            // 
            // tabBuscar
            // 
            this.tabBuscar.Controls.Add(this.pnlBuscar);
            this.tabBuscar.Controls.Add(this.groupBox3);
            this.tabBuscar.Location = new System.Drawing.Point(4, 22);
            this.tabBuscar.Name = "tabBuscar";
            this.tabBuscar.Padding = new System.Windows.Forms.Padding(3);
            this.tabBuscar.Size = new System.Drawing.Size(743, 400);
            this.tabBuscar.TabIndex = 2;
            this.tabBuscar.Text = "Buscar mascota";
            this.tabBuscar.UseVisualStyleBackColor = true;
            // 
            // pnlBuscar
            // 
            this.pnlBuscar.BackColor = System.Drawing.Color.RosyBrown;
            this.pnlBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlBuscar.ForeColor = System.Drawing.Color.Black;
            this.pnlBuscar.Location = new System.Drawing.Point(35, 139);
            this.pnlBuscar.Name = "pnlBuscar";
            this.pnlBuscar.Size = new System.Drawing.Size(673, 228);
            this.pnlBuscar.TabIndex = 3;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.groupBox3.Controls.Add(this.btnBuscar);
            this.groupBox3.Controls.Add(this.txtBuscar);
            this.groupBox3.Controls.Add(this.lblBuscar);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox3.Location = new System.Drawing.Point(35, 18);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(673, 100);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Búsqueda:";
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBuscar.Location = new System.Drawing.Point(479, 56);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(140, 30);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.Location = new System.Drawing.Point(52, 60);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(371, 22);
            this.txtBuscar.TabIndex = 0;
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscar.Location = new System.Drawing.Point(49, 32);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(261, 16);
            this.lblBuscar.TabIndex = 0;
            this.lblBuscar.Text = "Ingrese el nombre de la mascota a buscar:";
            // 
            // registroBindingSource
            // 
            this.registroBindingSource.DataSource = typeof(Enunciado_1.Registro);
            // 
            // Registro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Registro";
            this.Text = "Registro";
            this.tabControl1.ResumeLayout(false);
            this.tabDueño.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabMascota.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabBuscar.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.registroBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabDueño;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TabPage tabMascota;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblApellidos;
        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Button btnCancelarD;
        private System.Windows.Forms.Button btnRegistrarD;
        private System.Windows.Forms.TabPage tabBuscar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblDueño;
        private System.Windows.Forms.TextBox txtRaza;
        private System.Windows.Forms.Label lblRaza;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.Label lblEdad;
        private System.Windows.Forms.TextBox txtMascotaNombre;
        private System.Windows.Forms.Label lblMascotaNombre;
        private System.Windows.Forms.Button btnMascotaRegistrar;
        private System.Windows.Forms.Button btnMascotaCancelar;
        private System.Windows.Forms.ComboBox cmbDueño;
        private System.Windows.Forms.ComboBox cmbEdadUnidad;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.BindingSource registroBindingSource;
        private System.Windows.Forms.Panel pnlBuscar;
    }
}

