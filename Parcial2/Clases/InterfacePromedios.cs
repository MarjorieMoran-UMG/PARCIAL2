using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial2.Clases
{
    interface InterfacePromedios
    {
        /// <summary>
        /// retorna el promedio en base a una columna especifica 
        /// </summary>
        /// <param name="matriz"></param>
        /// <param name="columna_parcial"></param>
        /// <returns></returns>
        int promedios_por_parcial(string[,] matriz, int columna_parcial);

        /// <summary>
        /// retorna el promedio de un parcial y una seccion en especial
        /// </summary>
        /// <param name="matriz"></param>
        /// <param name="columna_parcial"></param>
        /// <param name="seccion"></param>
        /// <returns></returns>
        int promedios_por_seccion(string[,] matriz, int columna_seccion, string seccion);

        /// <summary>
        /// retorna el promedio de todos los alumnos por seccion
        /// </summary>
        /// <param name="matriz"></param>
        /// <param name="columna"></param>
        /// <param name="seccion"></param>
        /// <returns></returns>
        int promedios_general_seccion(string[,] matriz, string seccion);

        /// <summary>
        /// retorna una matriz con el nombre y la otra columna es la suamtoria del parcial del 1 al 3
        /// </summary>
        /// <param name="matriz"></param>
        /// <param name="columna"></param>
        /// <returns></returns>
        string[,] Clasificar_Alumnos(string[,] matriz, int columna);

        /// <summary>
        /// busca el mejor promedio general o por sección
        /// </summary>
        /// <param name="matriz"></param>
        /// <param name="seccion"></param>
        /// <returns></returns>

        string[,] nombre_nota_mayor(string[,] matriz);
        int nombre_nota_mayor(string[,] matriz, string[]arreglo);
    }
}
