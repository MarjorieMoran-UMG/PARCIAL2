using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial2.Clases
{
    class ClsPromedio : InterfacePromedios
    {
        public string[,] Clasificar_Alumnos(string[,] matriz, int columna)
        {
            throw new NotImplementedException();
        }

        public string[,] nombre_nota_mayor(string[,] matriz)
        {
            throw new NotImplementedException();
        }

        public int nombre_nota_mayor(string[,] matriz, string[] arreglo)
        {
            int Acum = 0;
            int Suma = 0;
            int promedio = 0;
            int Mayor = 0;
            int Almacen = 0;
            int[] PromedioMayor = new int[arreglo.Length];
            int TotalFilas = matriz.GetLength(0);
            int FilasSeccion = TotalFilas;
            int TotalColumnas = matriz.GetLength(1);
            for (int fila = 1; fila < TotalFilas; fila++)
            {
                Suma = Convert.ToInt32(matriz[fila, 2]) + Convert.ToInt32(matriz[fila, 3]) + Convert.ToInt32(matriz[fila, 4]);
                promedio = Suma / 3;
                if (Acum !=0)
                {
                    PromedioMayor[Acum] = promedio;
                    if (PromedioMayor[Acum]>Almacen)
                    {
                        Mayor = PromedioMayor[Acum];
                        Almacen = PromedioMayor[Acum];
                    }
                }

                Acum++;
            }

            return Mayor;
        }

        public int promedios_general_seccion(string[,] matriz, string seccion)
        {
            {
                int acumulador = 0;
                int promedio;
                int TotalFilas = matriz.GetLength(0);
                int filasSeccion = TotalFilas;
                int TotalColumnas = matriz.GetLength(1);
                for (int fila = 1; fila < TotalFilas; fila++)
                {
                    if (matriz[fila, enumColumnas.Seccion] == seccion)
                    {
                        acumulador = acumulador
                            + Convert.ToInt32(matriz[fila, enumColumnas.Parcial1])
                            + Convert.ToInt32(matriz[fila, enumColumnas.Parcial2])
                            + Convert.ToInt32(matriz[fila, enumColumnas.Parcial3]);
                    }
                    else
                    {
                        filasSeccion--;
                    }

                }

                promedio = (acumulador / (filasSeccion - 1)) / 3;
                return promedio;
            }

        }

        public int promedios_por_parcial(string[,] matriz, int columna_parcial)
        {
            {
                int acumulador = 0;
                int promedio;
                int totalFilas = matriz.GetLength(0);
                int totalColumnas = matriz.GetLength(1);
                for (int fila = 1; fila < totalFilas; fila++)
                {
                    acumulador = acumulador + Convert.ToInt32(matriz[fila, columna_parcial]);
                }
                promedio = acumulador / (totalFilas - 1);
                return promedio;

            }

        }

        public int promedios_por_seccion(string[,] matriz, int columna_seccion, string seccion)
        {
            int acumulador = 0;
            int promedio;
            int totalFilas = matriz.GetLength(0);
            int filasSeccion = totalFilas;
            int TotalColumnas = matriz.GetLength(1);
            for (int fila = 1; fila < totalFilas; fila++)
            {
                if (matriz[fila, enumColumnas.Seccion] == seccion)
                {
                    acumulador = acumulador
                        + Convert.ToInt32(matriz[fila, enumColumnas.Parcial1])
                        + Convert.ToInt32(matriz[fila, enumColumnas.Parcial2])
                        + Convert.ToInt32(matriz[fila, enumColumnas.Parcial3]);
                }
                else
                {
                    filasSeccion--;
                }

            }

            promedio = (acumulador / (filasSeccion - 1)) / 3;
            return promedio;
        }

    }
}
