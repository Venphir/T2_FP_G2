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
            this.btnAscendente.Click += new System.EventHandler(this.btnAscendente_Click); // Evento Click del botón btnAscendente
            this.btnDescendente.Click += new System.EventHandler(this.btnDescendente_Click); // Evento Click del botón btnDescendente

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
        private void btnInsertar_Click(object sender, EventArgs e)
        {
            try
            {
                double G2_numero;
                if (double.TryParse(txtNumero.Text, out G2_numero))
                {
                    G2_lista.AgregarNumero(G2_numero);
                    txtNumero.Clear(); // Limpia el cuadro de texto
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

        /// <summary>
        /// Se ordenan los números de la lista de forma ascendente
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAscendente_Click(object sender, EventArgs e)
        {
            // Ordenar los números
            G2_lista.OrdenarNumeros(0, G2_lista.G2_numeros.Count - 1);

            // Limpiar el GroupBox antes de mostrar los números
            gbMostrar.Controls.Clear();

            // Mostrar los números ordenados
            MostrarNumeros(G2_lista.G2_numeros, 0, 10, 20);
        }

        /// <summary>
        /// Se ordenan los números de la lista de forma descendente
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDescendente_Click(object sender, EventArgs e)
        {
            // Ordenar los números
            G2_lista.OrdenarNumerosDesc(0, G2_lista.G2_numeros.Count - 1);

            // Limpiar el GroupBox antes de mostrar los números
            gbMostrar.Controls.Clear();

            // Mostrar los números ordenados
            MostrarNumeros(G2_lista.G2_numeros, 0, 10, 20);
        }

        /// <summary>
        /// Se busca un número en la lista de números
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                double G2_numero;
                if (double.TryParse(txtNumero.Text, out G2_numero))
                {
                    // Restablecer el color de todos los números
                    foreach (Label lbl in gbMostrar.Controls)
                    {
                        lbl.ForeColor = Color.Black;
                    }

                    // Variable para verificar si se encontró el número
                    bool G2_encontrado = false;

                    // Buscar el número en el GroupBox
                    foreach (Label lbl in gbMostrar.Controls)
                    {
                        if (lbl.Text == G2_numero.ToString())
                        {
                            // Resaltar el número encontrado
                            lbl.ForeColor = Color.Red;
                            G2_encontrado = true;
                        }
                    }

                    if (G2_encontrado)
                    {
                        MessageBox.Show("Número encontrado: " + G2_numero, "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        // Si llegamos aquí, el número no se encontró
                        throw new Exception("Número no encontrado.");
                    }
                }
                else
                {
                    throw new FormatException("Por favor, ingresa un número válido.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Se elimina un número de la lista de números
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                double G2_numero;
                if (double.TryParse(txtNumero.Text, out G2_numero))
                {
                    // Buscar el número en la lista
                    int G2_indice = G2_lista.BuscarNumero(G2_numero, 0, G2_lista.G2_numeros.Count - 1);

                    if (G2_indice != -1)
                    {
                        // Eliminar todas las ocurrencias del número de la lista
                        G2_lista.G2_numeros.RemoveAll(num => num == G2_numero);

                        // Limpiar el GroupBox y mostrar los números restantes
                        gbMostrar.Controls.Clear();
                        MostrarNumeros(G2_lista.G2_numeros, 0, 10, 20);

                        MessageBox.Show("Número eliminado: " + G2_numero, "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        // Si llegamos aquí, el número no se encontró
                        throw new Exception("Número no encontrado.");
                    }
                }
                else
                {
                    throw new FormatException("Por favor, ingresa un número válido.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
