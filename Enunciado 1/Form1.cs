using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Enunciado_1
{
    public partial class Registro : Form
    {
        private List<Registrar> G2_listaDueños; // Lista para almacenar dueños
        private List<Mascota> G2_listaMascotas; // Lista para almacenar mascotas
        public Registro()
        {
            InitializeComponent();
            G2_listaDueños = new List<Registrar>(); //Iicializa la lista de dueños
            G2_listaMascotas = new List<Mascota>(); //Inicializa la lista de mascotas

            //Inicializa las opciones de unidad de tiempo para la edad de la mascota
            cmbEdadUnidad.Items.Add("Semanas");
            cmbEdadUnidad.Items.Add("Meses");
            cmbEdadUnidad.Items.Add("Años");
            cmbEdadUnidad.SelectedIndex = 0; //Selecciona la primera opción por defecto
        }

        private void btnRegistrarD_Click(object sender, EventArgs e)
        {
            try
            {
                //Obtener datos del formulario
                string G2_nombre = txtNombre.Text;
                string G2_apellidos = txtApellidos.Text;
                string G2_direccion = txtDireccion.Text;
                string G2_telefono = txtTelefono.Text;

                //Validar datos (ejemplo: verificar que no estén vacíos y que el teléfono sea numérico)

                if (string.IsNullOrWhiteSpace(G2_nombre) || string.IsNullOrWhiteSpace(G2_apellidos))
                {
                throw new Exception("Por favor, ingresa nombre y apellidos válidos.");
                }
                if (!EsNumero(G2_telefono))
                {
                throw new Exception("El teléfono debe contener solo números");
                }
                if (string.IsNullOrWhiteSpace(G2_direccion))
                {
                    throw new Exception("Por favor, ingresa una dirección válida.");
                }

                //Agregar un nuevo dueño a la lista
                G2_listaDueños.Add(new Registrar(G2_nombre, G2_apellidos, G2_direccion, G2_telefono));

                //Mostrar mensaje de éxito
                MessageBox.Show("Registro exitoso.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //Borrar las entradas
                txtNombre.Text = "";
                txtApellidos.Text = "";
                txtDireccion.Text = "";
                txtTelefono.Text = "";
            }
            catch (Exception ex)
            {
                //Mostrar mensaje de error
                MessageBox.Show("Error al registrar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //Actualizar el ComboBox de dueños
            cmbDueño.DataSource = null;
            cmbDueño.DataSource = G2_listaDueños;
        }

        private bool EsNumero(string G2_texto)
        {
            foreach (char c in G2_texto)
            {
                if (!char.IsDigit(c))
                {
                    return false;
                }
            }
            return true;
        }

        private void btnCancelarD_Click(object sender, EventArgs e)
        {
            this.Close(); // Cierra la ventana actual
        }

        /// <summary>
        /// Registrar una nueva mascota
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMascotaRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                //Obtener datos del formulario
                string G2_nombreMascota = txtMascotaNombre.Text;
                int G2_edadMascota = int.Parse(txtEdad.Text);
                string G2_razaMascota = txtRaza.Text;
                string G2_edadUnidad = cmbEdadUnidad.SelectedItem.ToString();
                Registrar G2_dueñoMascota = (Registrar)cmbDueño.SelectedItem;

                // Validar que la edad no sea negativa
                try
                {
                    if (G2_edadMascota < 0)
                    {
                        throw new ArgumentOutOfRangeException("edad", "La edad no puede ser un número negativo.");
                    }
                }
                catch (ArgumentOutOfRangeException ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                // Validar que la selección de dueño no sea nula
                try
                {
                    if (G2_dueñoMascota == null)
                    {
                        throw new ArgumentNullException("dueño", "Por favor, selecciona un dueño.");
                    }
                }
                catch (ArgumentNullException ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                //Agregar una nueva mascota a la lista
                G2_listaMascotas.Add(new Mascota(G2_nombreMascota, G2_edadMascota, G2_razaMascota, G2_dueñoMascota, G2_edadUnidad));

                //Mostrar mensaje de éxito
                MessageBox.Show("Registro de mascota exitoso.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //Borrar las entradas
                txtMascotaNombre.Text = "";
                txtEdad.Text = "";
                txtRaza.Text = "";
                cmbDueño.SelectedIndex = -1; // Esto deseleccionará cualquier dueño seleccionado en el ComboBox
                cmbEdadUnidad.SelectedIndex = 0; //Esto seleccionará la primera opción de unidad de tiempo por defecto
            }
            catch (Exception ex)
            {
                //Mostrar mensaje de error
                MessageBox.Show("Error al registrar mascota: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void btnMascotaCancelar_Click(object sender, EventArgs e)
        {
            this.Close(); // Cierra la ventana actual
        }

        // Método para buscar una mascota por nombre
        private int G2_BuscarMascotaRecursiva(List<Mascota> G2_mascotas, string G2_nombre, int G2_inicio, int G2_fin)
        {
            if (G2_inicio > G2_fin)
            {
                return -1; // No se encontró la mascota
            }

            int G2_medio = G2_inicio + (G2_fin - G2_inicio) / 2;
            int G2_comparacion = string.Compare(G2_mascotas[G2_medio].G2_Nombre, G2_nombre);

            if (G2_comparacion == 0)
            {
                return G2_medio; // Se encontró la mascota
            }
            else if (G2_comparacion < 0)
            {
                return G2_BuscarMascotaRecursiva(G2_mascotas, G2_nombre, G2_medio + 1, G2_fin); // Buscar en la mitad derecha
            }
            else
            {
                return G2_BuscarMascotaRecursiva(G2_mascotas, G2_nombre, G2_inicio, G2_medio - 1); // Buscar en la mitad izquierda
            }
        }
        /// <summary>
        /// Iniciar la búsqueda de una mascota por nombre
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string G2_nombre = txtBuscar.Text;
            int G2_indice = G2_BuscarMascotaRecursiva(G2_listaMascotas, G2_nombre, 0, G2_listaMascotas.Count - 1);
            if (G2_indice != -1)
            {
                MessageBox.Show("Mascota encontrada: " + G2_listaMascotas[G2_indice].G2_Nombre, "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Mascota G2_mascota = G2_listaMascotas[G2_indice];

                // Crear y configurar los controles para mostrar la información de la mascota
                Label lblNombre = new Label();
                lblNombre.Text = "Nombre: " + G2_mascota.G2_Nombre;
                Label lblEdad = new Label();
                lblEdad.Text = "Edad: " + G2_mascota.G2_Edad.ToString() + " " + G2_mascota.G2_Unidad;
                Label lblRaza = new Label();
                lblRaza.Text = "Raza: " + G2_mascota.G2_Raza;
                Label lblDueño = new Label();
                lblDueño.Text = "Dueño: " + G2_mascota.G2_Dueño.ToString();

                // Agregar los controles al panel
                pnlBuscar.Controls.Clear(); // Limpiar el panel antes de agregar los nuevos controles
                pnlBuscar.Controls.Add(lblNombre);
                pnlBuscar.Controls.Add(lblEdad);
                pnlBuscar.Controls.Add(lblRaza);
                pnlBuscar.Controls.Add(lblDueño);

                // Ajustar la posición de los controles
                lblNombre.Location = new Point(10, 10);
                lblEdad.Location = new Point(10, lblNombre.Bottom + 10);
                lblRaza.Location = new Point(10, lblEdad.Bottom + 10);
                lblDueño.Location = new Point(10, lblRaza.Bottom + 10);
            }
            else
            {
                MessageBox.Show("Mascota no encontrada.", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }

}
