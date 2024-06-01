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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelIngresar = new System.Windows.Forms.Label();
            this.txtInsertar = new System.Windows.Forms.TextBox();
            this.btnInsetar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tabNumeros.SuspendLayout();
            this.tabEliminar.SuspendLayout();
            this.groupBox1.SuspendLayout();
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
            this.tabEliminar.Controls.Add(this.groupBox2);
            this.tabEliminar.Controls.Add(this.groupBox1);
            this.tabEliminar.Location = new System.Drawing.Point(4, 22);
            this.tabEliminar.Name = "tabEliminar";
            this.tabEliminar.Padding = new System.Windows.Forms.Padding(3);
            this.tabEliminar.Size = new System.Drawing.Size(737, 400);
            this.tabEliminar.TabIndex = 4;
            this.tabEliminar.Text = "Eliminar número";
            this.tabEliminar.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.groupBox1.Controls.Add(this.btnInsetar);
            this.groupBox1.Controls.Add(this.txtInsertar);
            this.groupBox1.Controls.Add(this.labelIngresar);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(52, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(636, 138);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Insertar números a una lista:";
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
            // txtInsertar
            // 
            this.txtInsertar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInsertar.Location = new System.Drawing.Point(42, 85);
            this.txtInsertar.Name = "txtInsertar";
            this.txtInsertar.Size = new System.Drawing.Size(132, 24);
            this.txtInsertar.TabIndex = 1;
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
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.Info;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(52, 208);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(636, 138);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Números insertados:";
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
            this.tabEliminar.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabNumeros;
        private System.Windows.Forms.TabPage tabInsertar;
        private System.Windows.Forms.TabPage tabAscendente;
        private System.Windows.Forms.TabPage tabDescendente;
        private System.Windows.Forms.TabPage tabBuscar;
        private System.Windows.Forms.TabPage tabEliminar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnInsetar;
        private System.Windows.Forms.TextBox txtInsertar;
        private System.Windows.Forms.Label labelIngresar;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

