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
            this.tabNumeros = new System.Windows.Forms.TabControl();
            this.tabInsertar = new System.Windows.Forms.TabPage();
            this.tabAscendente = new System.Windows.Forms.TabPage();
            this.tabDescendente = new System.Windows.Forms.TabPage();
            this.tabBuscar = new System.Windows.Forms.TabPage();
            this.tabEliminar = new System.Windows.Forms.TabPage();
            this.tabNumeros.SuspendLayout();
            this.SuspendLayout();
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
            // tabInsertar
            // 
            this.tabInsertar.Location = new System.Drawing.Point(4, 22);
            this.tabInsertar.Name = "tabInsertar";
            this.tabInsertar.Padding = new System.Windows.Forms.Padding(3);
            this.tabInsertar.Size = new System.Drawing.Size(737, 400);
            this.tabInsertar.TabIndex = 0;
            this.tabInsertar.Text = "Insertar números";
            this.tabInsertar.UseVisualStyleBackColor = true;
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
            this.tabNumeros.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabNumeros;
        private System.Windows.Forms.TabPage tabInsertar;
        private System.Windows.Forms.TabPage tabAscendente;
        private System.Windows.Forms.TabPage tabDescendente;
        private System.Windows.Forms.TabPage tabBuscar;
        private System.Windows.Forms.TabPage tabEliminar;
    }
}

