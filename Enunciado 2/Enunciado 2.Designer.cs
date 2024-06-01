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
            this.tabEliminar = new System.Windows.Forms.TabPage();
            this.tabBuscar = new System.Windows.Forms.TabPage();
            this.tabDescendente = new System.Windows.Forms.TabPage();
            this.tabAscendente = new System.Windows.Forms.TabPage();
            this.tabInsertar = new System.Windows.Forms.TabPage();
            this.tabNumeros = new System.Windows.Forms.TabControl();
            this.gbMostrar = new System.Windows.Forms.GroupBox();
            this.gbInsertar = new System.Windows.Forms.GroupBox();
            this.btnInsetar = new System.Windows.Forms.Button();
            this.txtInsertar = new System.Windows.Forms.TextBox();
            this.labelIngresar = new System.Windows.Forms.Label();
            this.tabInsertar.SuspendLayout();
            this.tabNumeros.SuspendLayout();
            this.gbInsertar.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabEliminar
            // 
            this.tabEliminar.Location = new System.Drawing.Point(4, 22);
            this.tabEliminar.Name = "tabEliminar";
            this.tabEliminar.Padding = new System.Windows.Forms.Padding(3);
            this.tabEliminar.Size = new System.Drawing.Size(737, 400);
            this.tabEliminar.TabIndex = 4;
            this.tabEliminar.Text = "Eliminar número";
            this.tabEliminar.UseVisualStyleBackColor = true;
            // 
            // tabBuscar
            // 
            this.tabBuscar.Location = new System.Drawing.Point(4, 22);
            this.tabBuscar.Name = "tabBuscar";
            this.tabBuscar.Padding = new System.Windows.Forms.Padding(3);
            this.tabBuscar.Size = new System.Drawing.Size(737, 400);
            this.tabBuscar.TabIndex = 3;
            this.tabBuscar.Text = "Buscar número";
            this.tabBuscar.UseVisualStyleBackColor = true;
            // 
            // tabDescendente
            // 
            this.tabDescendente.Location = new System.Drawing.Point(4, 22);
            this.tabDescendente.Name = "tabDescendente";
            this.tabDescendente.Padding = new System.Windows.Forms.Padding(3);
            this.tabDescendente.Size = new System.Drawing.Size(737, 400);
            this.tabDescendente.TabIndex = 2;
            this.tabDescendente.Text = "Ordenar de forma descendente";
            this.tabDescendente.UseVisualStyleBackColor = true;
            // 
            // tabAscendente
            // 
            this.tabAscendente.Location = new System.Drawing.Point(4, 22);
            this.tabAscendente.Name = "tabAscendente";
            this.tabAscendente.Padding = new System.Windows.Forms.Padding(3);
            this.tabAscendente.Size = new System.Drawing.Size(737, 400);
            this.tabAscendente.TabIndex = 1;
            this.tabAscendente.Text = "Ordenar de forma ascendente";
            this.tabAscendente.UseVisualStyleBackColor = true;
            // 
            // tabInsertar
            // 
            this.tabInsertar.Controls.Add(this.gbMostrar);
            this.tabInsertar.Controls.Add(this.gbInsertar);
            this.tabInsertar.Location = new System.Drawing.Point(4, 22);
            this.tabInsertar.Name = "tabInsertar";
            this.tabInsertar.Padding = new System.Windows.Forms.Padding(3);
            this.tabInsertar.Size = new System.Drawing.Size(737, 400);
            this.tabInsertar.TabIndex = 0;
            this.tabInsertar.Text = "Insertar números";
            this.tabInsertar.UseVisualStyleBackColor = true;
            // 
            // tabNumeros
            // 
            this.tabNumeros.Controls.Add(this.tabInsertar);
            this.tabNumeros.Controls.Add(this.tabAscendente);
            this.tabNumeros.Controls.Add(this.tabDescendente);
            this.tabNumeros.Controls.Add(this.tabBuscar);
            this.tabNumeros.Controls.Add(this.tabEliminar);
            this.tabNumeros.Location = new System.Drawing.Point(26, 12);
            this.tabNumeros.Name = "tabNumeros";
            this.tabNumeros.SelectedIndex = 0;
            this.tabNumeros.Size = new System.Drawing.Size(745, 426);
            this.tabNumeros.TabIndex = 0;
            // 
            // gbMostrar
            // 
            this.gbMostrar.BackColor = System.Drawing.Color.Transparent;
            this.gbMostrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbMostrar.Location = new System.Drawing.Point(50, 214);
            this.gbMostrar.Name = "gbMostrar";
            this.gbMostrar.Size = new System.Drawing.Size(636, 138);
            this.gbMostrar.TabIndex = 7;
            this.gbMostrar.TabStop = false;
            this.gbMostrar.Text = "Números insertados:";
            // 
            // gbInsertar
            // 
            this.gbInsertar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.gbInsertar.Controls.Add(this.btnInsetar);
            this.gbInsertar.Controls.Add(this.txtInsertar);
            this.gbInsertar.Controls.Add(this.labelIngresar);
            this.gbInsertar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbInsertar.Location = new System.Drawing.Point(50, 49);
            this.gbInsertar.Name = "gbInsertar";
            this.gbInsertar.Size = new System.Drawing.Size(636, 138);
            this.gbInsertar.TabIndex = 6;
            this.gbInsertar.TabStop = false;
            this.gbInsertar.Text = "Insertar números a una lista:";
            // 
            // btnInsetar
            // 
            this.btnInsetar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnInsetar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsetar.Location = new System.Drawing.Point(202, 78);
            this.btnInsetar.Name = "btnInsetar";
            this.btnInsetar.Size = new System.Drawing.Size(138, 38);
            this.btnInsetar.TabIndex = 2;
            this.btnInsetar.Text = "Insertar";
            this.btnInsetar.UseVisualStyleBackColor = false;
            this.btnInsetar.Click += new System.EventHandler(this.btnInsetar_Click);
            // 
            // txtInsertar
            // 
            this.txtInsertar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInsertar.Location = new System.Drawing.Point(42, 85);
            this.txtInsertar.Name = "txtInsertar";
            this.txtInsertar.Size = new System.Drawing.Size(132, 24);
            this.txtInsertar.TabIndex = 1;
            // 
            // labelIngresar
            // 
            this.labelIngresar.AutoSize = true;
            this.labelIngresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIngresar.Location = new System.Drawing.Point(39, 52);
            this.labelIngresar.Name = "labelIngresar";
            this.labelIngresar.Size = new System.Drawing.Size(135, 18);
            this.labelIngresar.TabIndex = 0;
            this.labelIngresar.Text = "Ingrese un número:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabNumeros);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Números";
            this.tabInsertar.ResumeLayout(false);
            this.tabNumeros.ResumeLayout(false);
            this.gbInsertar.ResumeLayout(false);
            this.gbInsertar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabEliminar;
        private System.Windows.Forms.TabPage tabBuscar;
        private System.Windows.Forms.TabPage tabDescendente;
        private System.Windows.Forms.TabPage tabAscendente;
        private System.Windows.Forms.TabPage tabInsertar;
        private System.Windows.Forms.TabControl tabNumeros;
        private System.Windows.Forms.GroupBox gbMostrar;
        private System.Windows.Forms.GroupBox gbInsertar;
        private System.Windows.Forms.Button btnInsetar;
        private System.Windows.Forms.TextBox txtInsertar;
        private System.Windows.Forms.Label labelIngresar;
    }
}

