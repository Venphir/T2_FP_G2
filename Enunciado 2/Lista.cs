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

        /// <summary>
        /// Se ordenan los números de la lista usando el algoritmo de QuickSort
        /// </summary>
        /// <param name="inicio"></param>
        /// <param name="fin"></param>
        public void OrdenarNumeros(int inicio, int fin)
        {
            if (inicio < fin)
            {
                int G2_pivote = Particionar(inicio, fin);
                OrdenarNumeros(inicio, G2_pivote - 1);
                OrdenarNumeros(G2_pivote + 1, fin);
            }
        }

        /// <summary>
        /// Se particiona la lista de números
        /// </summary>
        /// <param name="inicio"></param>
        /// <param name="fin"></param>
        /// <returns></returns>
        private int Particionar(int inicio, int fin)
        {
            double G2_pivote = G2_numeros[fin];
            int i = inicio - 1;

            for (int j = inicio; j < fin; j++)
            {
                if (G2_numeros[j] <= G2_pivote)
                {
                    i++;
                    Swap(i, j);
                }
            }
            Swap(i + 1, fin);
            return i + 1;
        }

        /// <summary>
        /// Se intercambian los números
        /// </summary>
        /// <param name="i"></param>
        /// <param name="j"></param>
        private void Swap(int i, int j)
        {
            double G2_temp = G2_numeros[i];
            G2_numeros[i] = G2_numeros[j];
            G2_numeros[j] = G2_temp;
        }

        /// <summary>
        /// Se ordenan los números de la lista en orden descendente usando el algoritmo de QuickSort
        /// </summary>
        /// <param name="inicio"></param>
        /// <param name="fin"></param>
        public void OrdenarNumerosDesc(int inicio, int fin)
        {
            if (inicio < fin)
            {
                int G2_pivote = ParticionarDesc(inicio, fin);
                OrdenarNumerosDesc(inicio, G2_pivote - 1);
                OrdenarNumerosDesc(G2_pivote + 1, fin);
            }
        }

        /// <summary>
        /// Se particiona la lista de números en orden descendente
        /// </summary>
        /// <param name="inicio"></param>
        /// <param name="fin"></param>
        /// <returns></returns>
        private int ParticionarDesc(int inicio, int fin)
        {
            double G2_pivote = G2_numeros[fin];
            int i = inicio - 1;

            for (int j = inicio; j < fin; j++)
            {
                if (G2_numeros[j] >= G2_pivote)
                {
                    i++;
                    Swap(i, j);
                }
            }
            Swap(i + 1, fin);
            return i + 1;
        }

        /// <summary>
        /// Se busca un número en la lista de números
        /// </summary>
        /// <param name="G2_numero"></param>
        /// <param name="inicio"></param>
        /// <param name="fin"></param>
        /// <returns></returns>
        public int BuscarNumero(double G2_numero, int inicio, int fin)
        {
            // Ordenar la lista antes de realizar la búsqueda
            OrdenarNumeros(0, G2_numeros.Count - 1);

            if (inicio > fin)
            {
                return -1; // No se encontró el número
            }

            int G2_medio = inicio + (fin - inicio) / 2;

            if (G2_numeros[G2_medio] == G2_numero)
            {
                return G2_medio; // Se encontró el número
            }
            else if (G2_numeros[G2_medio] < G2_numero)
            {
                return BuscarNumero(G2_numero, G2_medio + 1, fin); // Buscar en la mitad derecha
            }
            else
            {
                return BuscarNumero(G2_numero, inicio, G2_medio - 1); // Buscar en la mitad izquierda
            }
        }

    }
}
