using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enunciado_2
{
    public class Lista
    {
        /// <summary>
        /// Se crea una lista de números para almacenar los números
        /// </summary>
        public List<double> G2_numeros { get; set; }

        /// <summary>
        /// Se inicializa la lista de números
        /// </summary>
        public Lista()
        {
            G2_numeros = new List<double>();
        }

        /// <summary>
        /// Se agrega un número a la lista
        /// </summary>
        /// <param name="G2_numero"></param>
        public void AgregarNumero(double G2_numero)
        {
            G2_numeros.Add(G2_numero);
        }
    }
}
