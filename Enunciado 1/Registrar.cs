using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Enunciado_1
{
    /// <summary>
    /// Se almacenan los datos de los dueños
    /// </summary>
    public class Registrar
    {
        public string G2_Nombre {  get; set; }
        public string G2_Apellidos { get; set; }
        public string G2_Dirección { get; set; }
        public string G2_Teléfono { get; set; }
        
        public Registrar(string nombre, string apellidos, string dirección, string teléfono)
        {
            G2_Nombre = nombre;
            G2_Apellidos = apellidos;
            G2_Dirección = dirección;
            G2_Teléfono =  teléfono;
        }
        public override string ToString()
        {
            return $"{G2_Nombre} {G2_Apellidos}";
        }
    }
    /// <summary>
    /// Se almacenan los datos de las mascotas
    /// </summary>
    public class Mascota
    {
        public string G2_Nombre { get; set; }
        public int G2_Edad { get; set; }
        public string G2_Raza { get; set; }
        public Registrar G2_Dueño { get; set; }
        public string G2_Unidad { get; set; }

        public Mascota(string nombre, int edad, string raza, Registrar dueño, string unidad)
        {
            G2_Nombre = nombre;
            G2_Edad = edad;
            G2_Raza = raza;
            G2_Dueño = dueño;
            G2_Unidad = unidad;

        }
    }
    
}
