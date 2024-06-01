namespace Enunciado_2
{
    partial class Enunciado2_Listas
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
            this.RTBMostrar = new System.Windows.Forms.RichTextBox();
            this.txtInsert = new System.Windows.Forms.TextBox();
            this.GBListas = new System.Windows.Forms.GroupBox();
            this.lblInsertNumber = new System.Windows.Forms.Label();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnOrdenarAsc = new System.Windows.Forms.Button();
            this.btnOrdenarDesc = new System.Windows.Forms.Button();
            this.btnDeleteNumber = new System.Windows.Forms.Button();
            this.GBListas.SuspendLayout();
            this.SuspendLayout();
            // 
            // RTBMostrar
            // 
            this.RTBMostrar.Location = new System.Drawing.Point(17, 132);
            this.RTBMostrar.Name = "RTBMostrar";
            this.RTBMostrar.Size = new System.Drawing.Size(618, 65);
            this.RTBMostrar.TabIndex = 0;
            this.RTBMostrar.Text = "";
            // 
            // txtInsert
            // 
            this.txtInsert.Location = new System.Drawing.Point(145, 35);
            this.txtInsert.Name = "txtInsert";
            this.txtInsert.Size = new System.Drawing.Size(317, 20);
            this.txtInsert.TabIndex = 1;
            // 
            // GBListas
            // 
            this.GBListas.Controls.Add(this.btnDeleteNumber);
            this.GBListas.Controls.Add(this.btnOrdenarDesc);
            this.GBListas.Controls.Add(this.btnOrdenarAsc);
            this.GBListas.Controls.Add(this.btnInsert);
            this.GBListas.Controls.Add(this.lblInsertNumber);
            this.GBListas.Controls.Add(this.txtInsert);
            this.GBListas.Controls.Add(this.RTBMostrar);
            this.GBListas.Location = new System.Drawing.Point(12, 15);
            this.GBListas.Name = "GBListas";
            this.GBListas.Size = new System.Drawing.Size(657, 213);
            this.GBListas.TabIndex = 2;
            this.GBListas.TabStop = false;
            this.GBListas.Text = "Listas";
            // 
            // lblInsertNumber
            // 
            this.lblInsertNumber.AutoSize = true;
            this.lblInsertNumber.Location = new System.Drawing.Point(27, 38);
            this.lblInsertNumber.Name = "lblInsertNumber";
            this.lblInsertNumber.Size = new System.Drawing.Size(98, 13);
            this.lblInsertNumber.TabIndex = 2;
            this.lblInsertNumber.Text = "Ingrese un número:";
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(500, 29);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(135, 31);
            this.btnInsert.TabIndex = 3;
            this.btnInsert.Text = "Insertar";
            this.btnInsert.UseVisualStyleBackColor = true;
            // 
            // btnOrdenarAsc
            // 
            this.btnOrdenarAsc.Location = new System.Drawing.Point(72, 78);
            this.btnOrdenarAsc.Name = "btnOrdenarAsc";
            this.btnOrdenarAsc.Size = new System.Drawing.Size(135, 31);
            this.btnOrdenarAsc.TabIndex = 4;
            this.btnOrdenarAsc.Text = "Ordenar Ascendente";
            this.btnOrdenarAsc.UseVisualStyleBackColor = true;
            // 
            // btnOrdenarDesc
            // 
            this.btnOrdenarDesc.Location = new System.Drawing.Point(279, 78);
            this.btnOrdenarDesc.Name = "btnOrdenarDesc";
            this.btnOrdenarDesc.Size = new System.Drawing.Size(135, 31);
            this.btnOrdenarDesc.TabIndex = 5;
            this.btnOrdenarDesc.Text = "Ordenar Descendente";
            this.btnOrdenarDesc.UseVisualStyleBackColor = true;
            // 
            // btnDeleteNumber
            // 
            this.btnDeleteNumber.Location = new System.Drawing.Point(500, 78);
            this.btnDeleteNumber.Name = "btnDeleteNumber";
            this.btnDeleteNumber.Size = new System.Drawing.Size(135, 31);
            this.btnDeleteNumber.TabIndex = 6;
            this.btnDeleteNumber.Text = "Eliminar número";
            this.btnDeleteNumber.UseVisualStyleBackColor = true;
            // 
            // Enunciado2_Listas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 242);
            this.Controls.Add(this.GBListas);
            this.Name = "Enunciado2_Listas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Enunciado2_Listas";
            this.GBListas.ResumeLayout(false);
            this.GBListas.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox RTBMostrar;
        private System.Windows.Forms.TextBox txtInsert;
        private System.Windows.Forms.GroupBox GBListas;
        private System.Windows.Forms.Button btnDeleteNumber;
        private System.Windows.Forms.Button btnOrdenarDesc;
        private System.Windows.Forms.Button btnOrdenarAsc;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Label lblInsertNumber;
    }
}