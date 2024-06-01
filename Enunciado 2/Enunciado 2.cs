using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Enunciado_2
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// Se solicita que se cree una lista de números enteros en la clase Lista
        /// </summary>
        private Lista G2_lista;
        public Form1()
        {
            InitializeComponent();
            G2_lista = new Lista();
        }
        /// <summary>
        /// Se muestra la lista de números en el formulario usando recursividad
        /// </summary>
        /// <param name="G2_numeros"></param>
        /// <param name="index"></param>
        private void MostrarNumeros(List<double> G2_numeros, int index, int x, int y)
        {
            if (index < G2_numeros.Count)
            {
                Label lbl = new Label(); // Crea una nueva etiqueta
                lbl.Text = G2_numeros[index].ToString(); // Texto de la etiqueta
                lbl.Location = new Point(x, y); // Posición de la etiqueta
                gbMostrar.Controls.Add(lbl); // Agrega la etiqueta al formulario

                if (y + lbl.Height * 2 > gbMostrar.Height)
                {
                    // Si la siguiente etiqueta no cabe en la columna actual, comienza una nueva columna
                    MostrarNumeros(G2_numeros, index + 1, x + lbl.Width + 10, 20);
                }
                else
                {
                    // De lo contrario, coloca la siguiente etiqueta debajo de la actual
                    MostrarNumeros(G2_numeros, index + 1, x, y + lbl.Height + 10);
                }
            }
        }

        /// <summary>
        /// Se inserta un número en la lista de números
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnInsetar_Click(object sender, EventArgs e)
        {
            try
            {
                double G2_numero;
                if (double.TryParse(txtInsertar.Text, out G2_numero))
                {
                    G2_lista.AgregarNumero(G2_numero);
                    txtInsertar.Clear(); // Limpia el cuadro de texto
                    gbMostrar.Controls.Clear(); // Limpia el panel antes de mostrar los números
                    MostrarNumeros(G2_lista.G2_numeros, 0, 10, 20); // Muestra los números en el formulario
                }
                else
                {
                    throw new FormatException("Por favor, ingresa un número válido.");
                }
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
