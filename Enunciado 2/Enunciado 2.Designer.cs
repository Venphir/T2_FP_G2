namespace Enunciado_2
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
            this.gbListas = new System.Windows.Forms.GroupBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.gbMostrar = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDescendente = new System.Windows.Forms.Button();
            this.btnAscendente = new System.Windows.Forms.Button();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.lblNumero = new System.Windows.Forms.Label();
            this.gbListas.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbListas
            // 
            this.gbListas.BackColor = System.Drawing.SystemColors.Info;
            this.gbListas.Controls.Add(this.btnBuscar);
            this.gbListas.Controls.Add(this.btnEliminar);
            this.gbListas.Controls.Add(this.gbMostrar);
            this.gbListas.Controls.Add(this.groupBox1);
            this.gbListas.Controls.Add(this.btnInsertar);
            this.gbListas.Controls.Add(this.txtNumero);
            this.gbListas.Controls.Add(this.lblNumero);
            this.gbListas.Location = new System.Drawing.Point(35, 19);
            this.gbListas.Name = "gbListas";
            this.gbListas.Size = new System.Drawing.Size(733, 411);
            this.gbListas.TabIndex = 0;
            this.gbListas.TabStop = false;
            this.gbListas.Text = "Listas";
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.SystemColors.MenuBar;
            this.btnBuscar.Location = new System.Drawing.Point(574, 126);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(127, 37);
            this.btnBuscar.TabIndex = 7;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.SystemColors.MenuBar;
            this.btnEliminar.Location = new System.Drawing.Point(574, 171);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(127, 37);
            this.btnEliminar.TabIndex = 6;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // gbMostrar
            // 
            this.gbMostrar.Location = new System.Drawing.Point(24, 245);
            this.gbMostrar.Name = "gbMostrar";
            this.gbMostrar.Size = new System.Drawing.Size(689, 146);
            this.gbMostrar.TabIndex = 4;
            this.gbMostrar.TabStop = false;
            this.gbMostrar.Text = "Lista Insertada:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDescendente);
            this.groupBox1.Controls.Add(this.btnAscendente);
            this.groupBox1.Location = new System.Drawing.Point(169, 116);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(382, 100);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Métodos de Ordenamiento";
            // 
            // btnDescendente
            // 
            this.btnDescendente.BackColor = System.Drawing.SystemColors.MenuBar;
            this.btnDescendente.Location = new System.Drawing.Point(207, 28);
            this.btnDescendente.Name = "btnDescendente";
            this.btnDescendente.Size = new System.Drawing.Size(170, 37);
            this.btnDescendente.TabIndex = 5;
            this.btnDescendente.Text = "Ordenar Descendentemente";
            this.btnDescendente.UseVisualStyleBackColor = false;
            this.btnDescendente.Click += new System.EventHandler(this.btnDescendente_Click);
            // 
            // btnAscendente
            // 
            this.btnAscendente.BackColor = System.Drawing.SystemColors.MenuBar;
            this.btnAscendente.Location = new System.Drawing.Point(5, 28);
            this.btnAscendente.Name = "btnAscendente";
            this.btnAscendente.Size = new System.Drawing.Size(170, 37);
            this.btnAscendente.TabIndex = 4;
            this.btnAscendente.Text = "Ordenar Ascendentemente";
            this.btnAscendente.UseVisualStyleBackColor = false;
            this.btnAscendente.Click += new System.EventHandler(this.btnAscendente_Click);
            // 
            // btnInsertar
            // 
            this.btnInsertar.BackColor = System.Drawing.SystemColors.MenuBar;
            this.btnInsertar.Location = new System.Drawing.Point(24, 144);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(127, 37);
            this.btnInsertar.TabIndex = 2;
            this.btnInsertar.Text = "Insertar";
            this.btnInsertar.UseVisualStyleBackColor = false;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(169, 64);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(194, 20);
            this.txtNumero.TabIndex = 1;
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(53, 67);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(98, 13);
            this.lblNumero.TabIndex = 0;
            this.lblNumero.Text = "Ingrese un número:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gbListas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Números";
            this.gbListas.ResumeLayout(false);
            this.gbListas.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbListas;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnDescendente;
        private System.Windows.Forms.Button btnAscendente;
        private System.Windows.Forms.GroupBox gbMostrar;
        private System.Windows.Forms.Button btnBuscar;
    }
}

